using System.Collections.Generic;
using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumShield: SignumBase
    {
        private readonly Pen _penMain;
        private readonly Brush _brushMain;
        private readonly Brush _brushBackGround;
        private readonly SignumData _data;

        public SignumShield(Pen penMain, Brush brushMain, Brush brushBackGround, SignumData data)
        {
            this._penMain = penMain;
            this._brushMain = brushMain;
            this._brushBackGround = brushBackGround;
            this._data = data;
        }

        public override void Draw(Graphics g)
        {
            var p = CreateMainShield();
            g.DrawPolygon(this._penMain, p);
        }

        private Point[] CreateMainShield()
        {
            var points = new List<Point>
            {
                this._data.PointLeftTop,
                this._data.PointLeftBottom,
                this._data.PointCenterBottom,
                this._data.PointRightBottom,
                this._data.PointRightTop,
                this._data.PointLeftTop
            };

            return points.ToArray();
        }
    }
}
