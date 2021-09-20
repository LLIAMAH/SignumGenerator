using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumData
    {
        protected readonly int _unitX;
        protected readonly int _unitY;
        protected readonly int _unitStep;
        protected readonly int _left;
        protected readonly int _right;
        protected readonly int _top;
        protected readonly int _bottom;
        protected readonly int _bottomExt;
        protected readonly int _centerX;
        protected readonly int _centerY;

        protected readonly Point _pointLeftTop;
        protected readonly Point _pointLeftBottom;
        protected readonly Point _pointCenterBottom;
        protected readonly Point _pointRightBottom;
        protected readonly Point _pointRightTop;
        protected readonly Point _pointCenter;
        protected readonly Point _pointLeftBottomHead;
        protected readonly Point _pointRightBottomHead;
        protected readonly Point _pointLeftTopBelt;
        protected readonly Point _pointLeftBottomBelt;
        protected readonly Point _pointRightTopBelt;
        protected readonly Point _pointRightBottomBelt;

        public SignumData(int x, int y, int unitX, int unitY, int unitStep)
        {
            this._unitX = unitX;
            this._unitY = unitY;
            this._unitStep = unitStep;

            this._left = x;
            this._right = x + (_unitX * _unitStep);
            this._top = y;
            this._bottom = y + (_unitY * _unitStep);
            this._bottomExt = this._bottom + _unitStep;
            this._centerX = (x + x + (_unitX * _unitStep)) / 2;
            this._centerY = y + y + (_unitY * _unitStep) / 2;

            this._pointLeftTop = new Point(this._left, this._top); // LeftTop, //new(150, 100),
            this._pointLeftBottom = new Point(this._left, this._bottom); //LeftBottom, //new(150, 400),
            this._pointCenterBottom = new Point(this._centerX, this._bottomExt); //CenterBottom,//new(300, 450),
            this._pointRightBottom = new Point(this._right, this._bottom); // RightBottom,//new(450, 400),
            this._pointRightTop = new Point(this._right, this._top); // RightTop,//new(450, 100),

            this._pointCenter = new Point(this._centerX, this._centerY); //CenterBottom,//new(300, 450),

            this._pointLeftBottomHead = new Point(this._left, y + 2 * _unitY * _unitStep - _unitStep / 2);
            this._pointRightBottomHead = new Point(this._right, y + 2 * _unitY * _unitStep - _unitStep / 2);

            this._pointLeftTopBelt = new Point(this._left, this._pointLeftTop.Y - _unitStep);
            this._pointLeftBottomBelt = new Point(this._left, this._pointLeftTop.Y + _unitStep);
            this._pointRightTopBelt = new Point(this._right, this._pointLeftTop.Y - _unitStep);
            this._pointRightBottomBelt = new Point(this._right, this._pointLeftTop.Y + _unitStep);
        }
    }
}
