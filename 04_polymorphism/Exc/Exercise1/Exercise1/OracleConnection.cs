using System;

namespace Exercise1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
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
