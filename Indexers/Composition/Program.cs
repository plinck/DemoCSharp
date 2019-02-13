using System;

namespace Composition
{
    // Generally speaking, favor composition over inheritance since it is less tightly coupled.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composition Hello World!");

            DbMigrator dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

            Console.ReadKey();
        }
    }
}
