using System;

namespace sda_cfence
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment line = new(5, 2, 8, 5);

            Console.WriteLine(line.LineLenght()); 
        }
    }
}
