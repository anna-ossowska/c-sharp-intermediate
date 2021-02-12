using System;

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Shape has been copied into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Shape has been selcted");
        }
    }
}
