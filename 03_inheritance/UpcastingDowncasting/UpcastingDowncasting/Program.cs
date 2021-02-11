using System;
using System.Collections;
using System.Collections.Generic;

namespace UpcastingDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // text and shape are both references to the same object
            // but they have different views (shape object does not have access to properties and methods specified inside the Text class)
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width); // 100


            // Another example of upcasting:
            // All the elements passed to the ArrayList are implicitly converted to the base Object class
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("text");
            list.Add(new Text());
        }
    }
}
