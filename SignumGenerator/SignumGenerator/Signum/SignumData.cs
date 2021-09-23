using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumData
    {
        public readonly int _unitX;
        public readonly int _unitY;
        public readonly int _unitStep;
        public readonly int _left;
        public readonly int _right;
        public readonly int _top;
        public readonly int _bottom;
        public readonly int _bottomExt;
        public readonly int _centerX;
        public readonly int _centerY;

        public readonly Point PointLeftTop;
        public readonly Point PointLeftBottom;
        public readonly Point PointCenterBottom;
        public readonly Point PointRightBottom;
        public readonly Point PointRightTop;
        public readonly Point PointCenter;
        public readonly Point PointLeftBottomHead;
        public readonly Point PointRightBottomHead;
        public readonly Point PointLeftTopBelt;
        public readonly Point PointLeftBottomBelt;
        public readonly Point PointRightTopBelt;
        public readonly Point PointRightBottomBelt;
        public readonly Point PointLeftTopExtremity;
        public readonly Point PointRightTopExtremity;
        public readonly int Third1;
        public readonly int Third2;

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
            this._centerY = (y + y + (_unitY * _unitStep)) / 2;
            this.Third1 = this._top + this._unitY / 3;
            this.Third2 = this._top + this._unitY * 2 / 3;

            this.PointLeftTop = new Point(this._left, this._top);
            this.PointLeftBottom = new Point(this._left, this._bottom);
            this.PointCenterBottom = new Point(this._centerX, this._bottomExt);
            this.PointRightBottom = new Point(this._right, this._bottom);
            this.PointRightTop = new Point(this._right, this._top);

            this.PointCenter = new Point(this._centerX, this._centerY);

            this.PointLeftBottomHead = new Point(this._left, this._top + this.Third1 - _unitStep / 2);
            this.PointRightBottomHead = new Point(this._right, this._top + this.Third1 - _unitStep / 2);

            this.PointLeftTopBelt = new Point(this._left,  this._centerY - this._unitY - this._unitY / 2);
            this.PointLeftBottomBelt = new Point(this._left, this._centerY + this._unitY + this._unitY / 2);
            this.PointRightTopBelt = new Point(this._right, this._centerY - this._unitY - this._unitY / 2);
            this.PointRightBottomBelt = new Point(this._right, this._centerY + this._unitY + this._unitY / 2);

            this.PointLeftTopExtremity = new Point(this._left, this._top + this.Third2 + _unitStep / 2);
            this.PointRightTopExtremity = new Point(this._right, this._top + this.Third2 + _unitStep / 2);
        }
    }
}
