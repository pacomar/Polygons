using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons
{
    public class Triangle
    {
        private Point a;
        private Point b;
        private Point c;

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.a = p1;
            this.b = p2;
            this.c = p3;
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
