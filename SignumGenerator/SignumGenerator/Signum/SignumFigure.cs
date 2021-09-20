using System.Collections.Generic;
using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumFigure
    {
        public static Point[] CreateMainShield(int x, int y, int unitX, int unitY, int unitStep)
        {
            var points = new List<Point>
            {
                new Point(x, y), // LeftTop, //new(150, 100),
                new Point(x, y + (unitY * unitStep)), //LeftBottom, //new(150, 400),
                new Point((x + x + (unitX * unitStep))/2, y + (unitY * unitStep) + unitStep), //CenterBottom,//new(300, 450),
                new Point(x + (unitX * unitStep), y + (unitY * unitStep)), // RightBottom,//new(450, 400),
                new Point(x + (unitX * unitStep), y), // RightTop,//new(450, 100),
                new Point(x, y) //LeftTop,//new(150, 100)// LastOne loop
            };

            return points.ToArray();
        }
    }
}
