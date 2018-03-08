namespace ICT2106.DocumentCreator.Models.Plain
{
    public abstract class PlainElement
    {
        // create a deep clone of the element
        public abstract PlainElement Clone();

        // get a string representing the element
        public abstract string GetString();
    }
}