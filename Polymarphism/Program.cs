using System;

namespace Polymarphism
{
    class Program
    {
        static void Main(string[] args)
        {
            _2DPoint p1 = new _2DPoint(1, 5);
            _2DPoint p2 = new _2DPoint(3, 6);
            Line line = new Line(p1, p2);
            Console.WriteLine("The length is " + line.GetLength());


            Shape[] sh = new Shape[3];
            sh[0] = new Circle(p1,p2);
            sh[1] = new Rectangle(p1, p2);
            sh[2] = new Square(p1, p2);

            Picture p = new Picture(sh);
            p.DisplayAllShapesArea();
        }
    }
}
