using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type an action: start | stop | exit");
                var input = (Console.ReadLine()).ToLower();

                if (input == "start")
                {
                    Stopwatch.Start();
                    Console.WriteLine("The program has started...");
                }
                else if (input == "stop")
                {
                    var duration = Stopwatch.Stop();
                    Console.WriteLine($"The program was stopped after: {duration} seconds.");
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Closing the program...");
                    break;
                }
            }

        }
    }
}
