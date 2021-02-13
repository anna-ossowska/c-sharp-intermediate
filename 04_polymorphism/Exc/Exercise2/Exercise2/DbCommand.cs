using System;

namespace Exercise2
{
    public class DbCommand
    {
        private string _instruction;
        private DbConnection _connection;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || String.IsNullOrEmpty(instruction))
            {
                throw new InvalidOperationException("Instruction and connection cannot be null or empty.");
            }
            else
            {
                this._connection = connection;
                this._instruction = instruction;
            }
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine(_instruction);
            _connection.Close();
        }
    }
}
