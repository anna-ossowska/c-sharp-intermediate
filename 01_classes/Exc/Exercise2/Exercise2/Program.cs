using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("OOP", "Quick intro to C# OOP");

            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Description);
            Console.WriteLine(post1.Date);

            Console.WriteLine(post1.UpVote());
            Console.WriteLine(post1.UpVote());
            Console.WriteLine(post1.DownVote());
            Console.WriteLine(post1.UpVote());
            Console.WriteLine(post1.UpVote());

            Console.WriteLine(post1.Total());

        }
    }
}
