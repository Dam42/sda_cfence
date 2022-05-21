using System;

namespace sda_cfence
{
    internal class LineSegment
    {
        MyPoint LineStart, LineEnd;

        public LineSegment(double Xa, double Xb, double Ya, double Yb)
        {
            this.LineStart = new MyPoint(Xa, Ya);
            this.LineEnd = new MyPoint(Xb, Yb);
        }

        public double LineLenght()
        {
            return Math.Sqrt(Math.Pow((LineStart.X - LineEnd.X), 2) + Math.Pow((LineStart.Y - LineEnd.Y), 2));
        }
    }
}