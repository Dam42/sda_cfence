namespace sda_cfence
{
    public class LineSegment
    {
        protected MyPoint start;
        protected MyPoint end;

        public LineSegment(MyPoint start, MyPoint end)
        {
            this.start = start;
            this.end = end;
        }

        public double GetLength()
        {
            return start.GetDistanceFromPoint(end);
        }

        public double Length => GetLength();

        public override string ToString()
        {
            return $"{start} -> {end}: {Length}";
        }
    }
}