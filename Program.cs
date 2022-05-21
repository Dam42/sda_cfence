﻿using System;

namespace sda_cfence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("2D ->");
            MyPoint point = new();
            MyPoint anotherPoint = new(5, 10);
            LineSegment firstLine = new(point, anotherPoint);
            Console.WriteLine(firstLine);

            Console.WriteLine("3D ->");
            MyPoint3D point3D = new();
            Console.WriteLine(point3D);
            MyPoint3D anotherPoint3D = new(5, 10, 20);
            Console.WriteLine(anotherPoint3D);

            LineSegment firstLine3D = new(point3D, anotherPoint3D);
            Console.WriteLine(firstLine3D);
        }
    }
}