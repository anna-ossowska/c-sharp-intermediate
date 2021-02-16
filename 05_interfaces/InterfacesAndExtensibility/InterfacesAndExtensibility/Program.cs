using System;

namespace InterfacesAndExtensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\Users\tomas\Desktop\my_files\folder1\notes.txt"));
            dbMigrator.Migrate();
        }
    }
}
