using System;

namespace sda_cfence
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[]
            {
                new Circle(3),
                new Circle(5.5),
                new Square(11),
                new Square(7.2)
            };

            double totalArea = 0;
            foreach(IShape shape in shapes)
            {
                totalArea += shape.GetArea();
            }

            Console.WriteLine(totalArea);
        }
    }
}
