using System;

namespace sda_cfence
{
    class Square : IShape
    {
        private double side;

        public Square(double side)
        {
            this.side = side;

        }

        public double GetArea()
        {
            return side * side;
        }
    }
}
