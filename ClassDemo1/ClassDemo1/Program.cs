using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Person paul = new Person("Paul");

                Console.WriteLine($"Hello {paul.Name}");
                Console.ReadLine();
            }

        }
    }
}
