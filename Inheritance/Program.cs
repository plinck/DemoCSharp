using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World Inheritance");

            var text = new Text();
            text.FontName = "SF Pro";
            text.Height = 50;
            text.Width = 100;
            text.AddHyperlink("https://linck.net");
            text.Copy();
            text.Duplicate();

            // alternate method using object initializer
            var text2 = new Text
            {
                FontName = "SF Pro",
                Height = 50,
                Width = 100
            };
            text2.AddHyperlink("https://linck.net");
            text2.Copy();
            text2.Duplicate();

            Console.ReadKey();

        }
    }
}
