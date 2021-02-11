using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            // Boxing happens, since int is a value type
            list.Add(1);
            // Boxing does not happen, since string is a reference type
            list.Add("text");
            // Boxing happens, since DateTime is a struct and value type
            list.Add(DateTime.Today);

            // Unboxing
            var number = (int)list[0];
            Console.WriteLine(number);

            var anotherList = new List<int>();
            // No boxing happens, we get the 'type safety' with the Generic Lists
            anotherList.Add(3);
        }
    }
}
