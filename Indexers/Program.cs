using System;

namespace Indexers
{

    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "paul";

            Console.WriteLine($"Hello World! {cookie["name"]}");
        }
    }
}
