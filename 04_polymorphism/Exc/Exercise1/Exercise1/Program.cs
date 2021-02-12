using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("data data data...");
            sqlConnection.Open();
            sqlConnection.Close();

            var oracleConnection = new OracleConnection("some string");
            sqlConnection.Open();
            sqlConnection.Close();
        }
    }
}
