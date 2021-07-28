using System;

namespace Composition
{

    class Program
    {
        static void Main(string[] args)
        {

            var dbMIgrator = new DbMigrator(new Logger());

            var installer = new Installer(new Logger());

            dbMIgrator.Migrate();
            installer.Install();

        }
    }
}
