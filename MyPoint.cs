using System;

namespace sda_cfence
{
    public class MyPoint
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public MyPoint(double x, double y, double Z = 0)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual double GetDistanceFromPoint(MyPoint otherPoint)
        {
            return Math.Sqrt(Math.Pow((this.X - otherPoint.X), 2) + Math.Pow((this.Y - otherPoint.Y), 2));
        }
    }
}