using System;

namespace AbstractClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape is declared as abstract. Thus, we cannot create an instance of this class.
            // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
