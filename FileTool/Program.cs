//
// ICT2106 Software Design - File tool example.
//
// Main program.
//
// Author: Nicholas Sheppard
//

using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ICT2106.FileTool
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length < 1)
            {
                // no arguments; print help and exit
                Console.WriteLine("ICT2106 FileTool - Process files.");
                Console.WriteLine("Usage:");
                Console.WriteLine("    ICT2106.FileTool [options] <inputfile> <outputfile>");
                Console.WriteLine();
                Console.WriteLine("Valid options:");
                Console.WriteLine("    +v  encrypt with Vigenere cipher");
                Console.WriteLine("    -v  decrypt with Vigenere cipher");
                Console.WriteLine("    +z  compress with gzip");
                Console.WriteLine("    -z  decompress with gzip");

                return;
            }

            // parse command line and set options
            bool useVigenereEncryption = false;
            bool useVigenereDecryption = false;
            bool useGzipCompression = false;
            bool useGzipDecompression = false;
            int i = 0;
            while ((args[i][0] == '-' || args[i][0] == '+') && i < args.Length)
            {
                switch (args[i])
                {
                    case "+v": useVigenereEncryption = true; break;
                    case "-v": useVigenereDecryption = true; break;
                    case "+z": useGzipCompression = true; break;
                    case "-z": useGzipDecompression = true; break;
                    default: Console.WriteLine("Ignoring unknown option {0}.", args[i]); break;
                }
                i++;
            }

            // get the input and output filenames
            string inputFilename;
            string outputFilename;
            if (i < args.Length)
            {
                inputFilename = args[i];
                i++;
            } else
            {
                Console.WriteLine("Missing input filename. Run the program without arguments for help.");
                return;
            }
            if (i < args.Length)
            {
                outputFilename = args[i];
                i++;
            }
            else
            {
                Console.WriteLine("Missing output filename. Run the program without arguments for help.");
                return;
            }

            // open the input stream and decorate it according to the options
            Stream inputStream;
            try
            {
                inputStream = new FileStream(inputFilename, FileMode.Open);
                if (useGzipDecompression)
                {
                    inputStream = new GZipStream(inputStream, CompressionMode.Decompress);
                }
                if (useVigenereDecryption)
                {
                    Console.Write("Enter the decryption password: ");
                    string key = Console.ReadLine();
                    inputStream = new VigenereStream(inputStream, Encoding.ASCII.GetBytes(key), VigenereStreamMode.Decrypt);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // open the output stream and decorate it according to the options
            Stream outputStream;
            try
            {
                outputStream = new FileStream(outputFilename, FileMode.Create);
                if (useGzipCompression)
                {
                    outputStream = new GZipStream(outputStream, CompressionMode.Compress);
                }
                if (useVigenereEncryption)
                {
                    Console.Write("Enter the encryption password: ");
                    string key = Console.ReadLine();
                    outputStream = new VigenereStream(outputStream, Encoding.ASCII.GetBytes(key), VigenereStreamMode.Encrypt);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                inputStream.Dispose();
                return;
            }

            // performing copying
			try {
				inputStream.CopyTo(outputStream);
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (NotSupportedException e)
			{
				Console.WriteLine(e.Message);
			}

            // clean up
            inputStream.Dispose();
            outputStream.Dispose();

            return;

        }
    }
}
