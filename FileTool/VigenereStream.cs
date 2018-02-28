//
// ICT2106 Software Design - File tool example.
//
// Vigenere stream cipher. This is an example of the Decorator pattern.
//
// See http://www.vigenere.net/ for a description of how the cipher itself works.
//
// Author: Nicholas Sheppard
//

using System.IO;

namespace ICT2106.FileTool
{
    //
    // Modes for use of the stream cipher
    //
    enum VigenereStreamMode
    {
        Encrypt, Decrypt
    }

    //
    // Vigenere stream cipher, implemented as a decorator for the .NET Stream class
    //
    class VigenereStream : Stream
    {
        // the encryption or decryption mode
        private VigenereStreamMode mode;

        // the stream to be encrypted or decrypted
        private Stream stream;

        // the key
        private byte[] key;

        // for looping through the key bytes
        private int pos = 0;


        //
        // Constructor.
        //
        public VigenereStream(Stream streamIn, byte[] keyIn, VigenereStreamMode modeIn) : base()
        {
            // save references to the input for later
            stream = streamIn;
            key = new byte[keyIn.Length];
            for (int i = 0; i < keyIn.Length; i++)
                key[i] = keyIn[i];
            mode = modeIn;

            // initialise the counter to the first position
            pos = 0;
        }


        //
        // Encrypt or decrypt the next byte in the stream.
        //
        private byte NextByte(byte byteIn)
        {
            // shift the input byte according to the current position in the key bytes
            int byteOut = (mode == VigenereStreamMode.Encrypt) ? byteIn + key[pos] : byteIn - key[pos];

            // ensure that the byte value is between 0 and 255
            if (byteOut > 255)
                byteOut -= 255;
            if (byteOut < 0)
                byteOut += 255;

            // update the position in the key bytes
            if (++pos >= key.Length)
                pos = 0;

            return (byte)byteOut;
        }


        //
        // Position property. Setting the position requires the position in the key
        // bytes array to be updated.
        //
        public override long Position
        {
            get { return stream.Position; }
            set { pos = (int)(value % key.Length); stream.Position = value; }
        }


        //
        // Read bytes from the stream.
        //
        public override int Read(byte[] buffer, int offset, int count)
        {
            // read the buffer from the underlying stream
            int n = stream.Read(buffer, offset, count);

            // encrypt or decrypt the buffer
            for (int i = offset; i < offset + n; i++)
            {
                buffer[i] = NextByte(buffer[i]);
            }

            return n;
        }


        //
        // Read a byte from the stream.
        //
        public override int ReadByte()
        {
            // get a byte from the underlying stream
            int b = stream.ReadByte();

            if (b != -1)
                return NextByte((byte)b);
            else
                return -1;
        }


        //
        // Seek within the stream.
        //
        public override long Seek(long offset, SeekOrigin origin)
        {
            // seek in the underlying stream
            long newOffset = stream.Seek(offset, origin);

            // update the position in the key bytes
            pos = (int)(newOffset % key.Length);

            return newOffset;
        }


        //
        // Write bytes to the stream.
        //
        public override void Write(byte[] buffer, int offset, int count)
        {
            // encrypt or decrypt the buffer
            byte[] bufferOut = new byte[buffer.Length];
            for (int i = offset; i < offset + count; i++)
            {
                bufferOut[i] = NextByte(buffer[i]);
            }

            // write to the underlying stream
            stream.Write(bufferOut, offset, count);
        }


        //
        // Write a single byte to the stream.
        //
        public override void WriteByte(byte value)
        {
            stream.WriteByte(NextByte(value));
        }


        //
        // All of the remaining properties and methods just invoke the corresponding
        // property or method of the underlying stream because we don't do any
        // encryption or decryption for them.
        //
        public override bool CanRead { get { return stream.CanRead; } }
        public override bool CanSeek { get { return stream.CanSeek; } }
        public override bool CanWrite { get { return stream.CanWrite; } }
        public override void Flush() { stream.Flush(); }
        public override long Length { get { return stream.Length; } }
        public override void SetLength(long length) { stream.SetLength(length);  }
    }
}
