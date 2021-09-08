using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    class Square:Rectangle 
    {
         _2DPoint p1, p2;
        public Square() { }
        public Square(_2DPoint p1, _2DPoint p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public override double CalculateArea()
        {
            Line l = new Line(p1, p2);
            double len = l.GetLength();
            return len * len;
        }
    }
}
