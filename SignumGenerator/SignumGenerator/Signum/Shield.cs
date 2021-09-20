using System;
using System.Drawing;

namespace SignumGenerator.Signum
{
    public abstract class Figure
    {
        public abstract void Draw(Graphics g, int x, int y);
        public abstract void Draw(Graphics g, int x, int y, int width, int height);
    }

    public class Shield: Figure
    {
        private readonly Pen _penMain;
        private readonly Brush _brushMain;
        private readonly Brush _brushBackGround;
        
        private const int _unitX = 6;
        private const int _unitY = 12;
        private const int _unitStep = 10;

        public Shield(Pen penMain, Brush brushMain, Brush brushBackGround)
        {
            this._penMain = penMain;
            this._brushMain = brushMain;
            this._brushBackGround = brushBackGround;
        }

        public override void Draw(Graphics g, int x, int y)
        {
            var p = SignumFigure.CreateMainShield(x, y, _unitX, _unitY, _unitStep);
            g.FillPolygon(this._brushMain, p);
        }

        public override void Draw(Graphics g, int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}
