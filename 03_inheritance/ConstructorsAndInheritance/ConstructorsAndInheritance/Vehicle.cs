using System;

namespace ConstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle is being initialized {registrationNumber}");
        }
    }
}
