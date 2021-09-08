using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    class Rectangle : Shape
    {
        _2DPoint p1, p2;

        public Rectangle()
        {

        }

        public Rectangle(_2DPoint p1, _2DPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public override double CalculateArea()
        {

            double len = p1.x - p2.x;
            double wid = p1.y - p2.y;

            return Math.Abs(len * wid);
        }
    }
}
