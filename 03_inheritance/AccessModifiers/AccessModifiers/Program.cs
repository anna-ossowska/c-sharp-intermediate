using System;
using Client;

namespace AccessModifiers
{

    class Program
    {
        static void Main(string[] args)
        {
            Client.Customer customer = new Customer();

            // RateCalculator is not accesible outside of the Client assembly, this code will not work:
            // Client.RateCalculator calculator = new RateCalculator();
        }
    }
}
