using System;

namespace sda_cfence
{
    class Program
    {
        static void Main(string[] args)
        {
            LineSegment line = new(5, 2, 8, 5);

            MyPoint point = new(5, 9);
            MyPoint point2 = new(2, 11);

            MyPoint3D point3D = new(3, 5, 2);
            MyPoint3D point3D2 = new(5, 7, 8);

            Console.WriteLine( point.GetDistanceFromPoint(point2));

            Console.WriteLine(point3D.GetDistanceFromPoint(point3D2));
        }
    }
}
