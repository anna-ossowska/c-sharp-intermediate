using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("data");

            var command = new DbCommand(sqlConnection, "This is my instruction.");
            command.Execute();
        }
    }
}
