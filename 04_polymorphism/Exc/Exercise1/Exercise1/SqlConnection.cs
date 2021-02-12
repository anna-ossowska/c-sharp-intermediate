using System;

namespace Exercise1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Connection has been opened.");
        }

        public override void Close()
        {
            Console.WriteLine("Connection has been closed.");
        }
    }
}
