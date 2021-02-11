using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push("hello");
            stack.Push("bye");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            Console.WriteLine(stack.Pop());
        }
    }
}
