using System;

namespace sda_cfence
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment line = new(new MyPoint(5, 2), new MyPoint(8, 5));

            Console.WriteLine(line.LineLenght() ); 
        }
    }
}
