using System;

namespace Exercise2
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Open the connection.");
        }

        public override void Close()
        {
            Console.WriteLine("Close the connection.");
        }
    }
}
