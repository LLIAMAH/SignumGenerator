using System.Collections.Generic;
using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumLine: SignumBase
    {
        private readonly Brush _brush;
        private readonly SignumData _data;

        public SignumLine(Brush brush, SignumData signum)
        {
            this._brush = brush;
            this._data = signum;
        }

        public override void Draw(Graphics g)
        {
            var p1 = CreateLine1();
            var p2 = CreateLine2();
            var p3 = CreateLine3();

            //g.FillPolygon(this._brush, p1);
            //g.FillPolygon(this._brush, p2);
            g.FillPolygon(this._brush, p3);
        }

        private Point[] CreateLine1()
        {
            var points = new List<Point>
            {
                this._data.PointLeftTop,
                this._data.PointLeftBottomHead,
                this._data.PointRightBottomHead,
                this._data.PointRightTop,
                this._data.PointLeftTop
            };

            return points.ToArray();
        }

        private Point[] CreateLine2()
        {
            var points = new List<Point>
            {
                this._data.PointLeftTopBelt,
                this._data.PointLeftBottomBelt,
                this._data.PointRightBottomBelt,
                this._data.PointRightTopBelt,
                this._data.PointLeftTopBelt
            };

            return points.ToArray();
        }

        private Point[] CreateLine3()
        {
            var points = new List<Point>
            {
                this._data.PointLeftTopExtremity,
                this._data.PointLeftBottom,
                this._data.PointCenterBottom,
                this._data.PointRightBottom,
                this._data.PointRightTopExtremity,
                this._data.PointLeftTopExtremity
            };

            return points.ToArray();
        }
    }
}
