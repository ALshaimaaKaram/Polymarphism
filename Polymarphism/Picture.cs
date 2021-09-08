using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    class Picture
    {
        //rectangles, circles & squares;

        Shape[] sh;

        public Picture()
        {

        }

        public Picture(Shape[] sh)
        {
            this.sh = sh;
        }

        //public void CalArea(Shape[] sh)
        //{
        //    for (int i = 0; i < this.sh.Length; i++)
        //    {
        //        sh[i].CalculateArea();
        //    }
        //}


        public void DisplayAllShapesArea()
        {
            for (int i = 0; i < this.sh.Length; i++)
            {
                Console.WriteLine("The Area of the Shape is " + sh[i].CalculateArea());
            }
        }
    }
}
