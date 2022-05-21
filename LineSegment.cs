using System;

namespace sda_cfence
{
    internal class LineSegment
    {
        MyPoint LineStart, LineEnd;

        public LineSegment(double startX, double startY, double endX, double endY)
        {
            this.LineStart = new MyPoint(startX, startY);
            this.LineEnd = new MyPoint(endX, endY);
        }

        public double LineLenght()
        {
            return Math.Sqrt(Math.Pow((LineStart.x - LineEnd.x), 2) + Math.Pow((LineStart.y - LineEnd.y), 2));
        }
    }
}