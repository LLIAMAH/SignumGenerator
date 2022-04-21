using System;
using System.Drawing;

namespace SignumLib.Base
{
    public class SignumData
    {
        private readonly int _width;
        private readonly int _height;
        private readonly double _angleSmall;
        private readonly double _angleBig;

        public int Width => _width;
        public int Height => _height;

        public int Top => 0;
        public int Left => 0;
        public int Bottom => _height;
        public int Right => _width;

        public int CenterX => _width / 2;
        public int CenterY => _height / 2;

        public int Horizontal2 => _width / 2;
        public int Horizontal3 => _width / 3;
        public int Horizontal4 => _width / 4;
        public int Horizontal5 => _width / 5;
        public int Horizontal6 => _width / 6;
        public int Horizontal8 => _width / 8;
        public int Horizontal10 => _width / 10;
        public int Horizontal12 => _width / 12;

        public int Vertical2 => _height / 2;
        public int Vertical3 => _height / 3;
        public int Vertical4 => _height / 4;
        public int Vertical5 => _height / 5;
        public int Vertical6 => _height / 6;
        public int Vertical8 => _height / 8;
        public int Vertical10 => _height / 10;
        public int Vertical12 => _height / 12;

        public Point PointCenter => new(CenterX, CenterY);
        public Point PointTopCenter => new(CenterX, Top);
        public Point PointBottomCenter => new(CenterX, Bottom);
        public Point PointCenterLeft => new(Left, CenterY);
        public Point PointCenterRight => new(Right, CenterY);

        public Point PointTopLeft => new(Left, Top);
        public Point PointTopRight => new(Right, Top);
        public Point PointBottomLeft => new(Left, Bottom);
        public Point PointBottomRight => new(Right, Bottom);

        public SignumData(int width, int height)
        {
            this._width = width;
            this._height = height;
            this._angleSmall = (180 / Math.PI) * Math.Atan((double)width / height);
            this._angleBig = 90 - this._angleSmall;
        }

        public SignumData(Bitmap bmp)
        {
            this._width = bmp.Width;
            this._height = bmp.Height;
        }

        public static double GetPercents(int input, double percents)
        {
            return input * percents / 100;
        }
    }
}
