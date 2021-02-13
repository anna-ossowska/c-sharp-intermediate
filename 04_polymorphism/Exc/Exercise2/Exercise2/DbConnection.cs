using System;

namespace Exercise2
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("The connection cannot be null or an empty string.");
            }
            else
            {
                this.ConnectionString = connectionString;
            }
        }

        public abstract void Open();

        public abstract void Close();
    }
}
