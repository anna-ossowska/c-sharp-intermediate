using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solution 1
            try
            {
                var number1 = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            // Solution 2
            int number2;

            var result = int.TryParse("abc", out number2);

            if (result)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));
            Console.WriteLine(calculator.Add(new int[] { 54, 45, 21, 1 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine($"Point is at {point.X} and {point.Y}.");

                point.Move(100, 200);
                Console.WriteLine($"Point is at {point.X} and {point.Y}.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
