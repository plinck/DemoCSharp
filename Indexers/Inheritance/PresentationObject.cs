using System;

namespace Inheritance
{
    public class PresentationObject
    {
        // common base
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("object duplicated");
        }
    }
}