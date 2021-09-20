using System.Collections.Generic;
using System.Drawing;

namespace SignumGenerator.Signum
{
    public class Shield: SignumData
    {
        private readonly Pen _penMain;
        private readonly Brush _brushMain;
        private readonly Brush _brushBackGround;

        public Shield(Pen penMain, Brush brushMain, Brush brushBackGround, int x, int y, int unitX, int unitY,
            int unitStep) : base(x, y, unitX, unitY, unitStep)
        {
            this._penMain = penMain;
            this._brushMain = brushMain;
            this._brushBackGround = brushBackGround;
        }

        public void Draw(Graphics g, int x, int y)
        {
            var p = CreateMainShield();
            g.DrawPolygon(this._penMain, p);
        }

        private Point[] CreateMainShield()
        {
            var points = new List<Point>
            {
                this._pointLeftTop,
                this._pointLeftBottom,
                this._pointCenterBottom,
                this._pointRightBottom,
                this._pointRightTop,
                this._pointLeftTop
            };

            return points.ToArray();
        }
    }
}
