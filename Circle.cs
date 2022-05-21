using System;

namespace sda_cfence
{
    class Circle : IShape
    {
        private double radius;
        private double pie = Math.PI;

        public Circle(double radius)
        {
            this.radius = radius;

        }

        public double GetArea()
        {
            return pie * (radius * radius);
        }
    }
}
