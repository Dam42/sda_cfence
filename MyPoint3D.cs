using System;

namespace sda_cfence
{
    public class MyPoint3D : MyPoint
    {
        public double Z { get; }

        public MyPoint3D(double x, double y, double z) : base(x, y)
        {
            this.Z = z;
        }

        public override double GetDistanceFromPoint(MyPoint otherPoint)
        {
            return Math.Sqrt(Math.Pow((this.X - otherPoint.X), 2) + Math.Pow((this.Y - otherPoint.Y), 2) + Math.Pow((this.Z - otherPoint.Z), 2));
        }
    }
}
