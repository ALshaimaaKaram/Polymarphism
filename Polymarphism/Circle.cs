using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    class Circle : Shape
    {
        _2DPoint p1, p2;
        public Circle() { }

        public Circle(_2DPoint p1, _2DPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public override double CalculateArea()
        {
            Line l = new Line(p1, p2);
            double r = l.GetLength();
            return  r * r * 3.14;
        }
    }
}
