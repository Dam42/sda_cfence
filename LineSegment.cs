using System;

namespace sda_cfence
{
    internal class LineSegment
    {
        MyPoint LineStart, LineEnd;

        public LineSegment(MyPoint LineStart, MyPoint LineEnd)
        {
            this.LineStart = LineStart;
            this.LineEnd = LineEnd;
        }

        public double LineLenght()
        {
            return Math.Sqrt(Math.Pow((LineStart.x - LineEnd.x), 2) + Math.Pow((LineStart.y - LineEnd.y), 2));
        }
    }
}