using System;

namespace sda_cfence
{
    internal class LineSegment
    {
        private double Xa, Xb, Ya, Yb;

        public LineSegment(MyPoint LineStart, MyPoint LineEnd)
        {
            this.Xa = LineStart.x;
            this.Ya = LineStart.y;
            this.Xb = LineEnd.x;
            this.Yb = LineEnd.y;
        }

        public double LineLenght()
        {
            return Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
        }
    }
}