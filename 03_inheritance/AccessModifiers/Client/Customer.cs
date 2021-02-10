using System;

namespace Client
{
    public class Customer
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public void Promote()
        {   
            // RateCalculator is accessible only inside the Client assembly
            var calculator = new RateCalculator();

            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");
        }

    }
}
