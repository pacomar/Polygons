using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons
{
    public class Line
    {
        private Point a;
        private Point b;

        public Line(Point p1, Point p2)
        {
            this.a = p1;
            this.b = p2;
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }
    }
}
