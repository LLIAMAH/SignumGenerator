using System.Drawing;

namespace SignumGenerator.Signum
{
    public enum SignumBasePattern
    {
        StripesHorizontal,
        StripesVertical,
        Quarter,
        Quarters_1_3,
        Quarters_2_4,
        SlingLeft,
        SlingRight
    }

    public class SignumBase : SignumAbstract
    {
        private readonly Graphics _g;
        private readonly SignumData _data;

        public SignumBase()
        {
            _bmp = new Bitmap(Width, Height);
            _data = new SignumData(Width, Height);
            _g = Graphics.FromImage(_bmp);
        }

        public void ApplyPattern(SignumBasePattern pattern, Color primary, Color secondary, int size = 0)
        {
            var brushSecondary = SignumBrush.CreateBrush(secondary);
            _g.FillRectangle(brushSecondary, 0,0, Width, Height);

            switch (pattern)
            {
                case SignumBasePattern.StripesHorizontal:
                {
                    DrawStripesHorizontal(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.SlingRight:
                {
                    using var pen = SignumPen.CreatePen(primary, size == 0 ? 1 : size);
                    _g.DrawLine(pen, _data.PointTopLeft, _data.PointBottomRight);
                    break;
                }
                case SignumBasePattern.SlingLeft:
                {
                    using var pen = SignumPen.CreatePen(primary, size == 0 ? 1 : size);
                    _g.DrawLine(pen, _data.PointTopRight, _data.PointBottomLeft);
                    break;
                }

                default: break;
            }
        }

        private static void DrawStripesHorizontal(Graphics g, Color primary, SignumData data, int count)
        {
            if(count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary color
            //// 1- means 1 primary stripe and 1 background color
            var i = 0;
            var lineWidth = data.Height / (count * 2);// data.Vertical6;
            using var pen = SignumPen.CreatePen(primary, lineWidth);
            while (i < data.Height)
            {
                var lineCenter = i * lineWidth + lineWidth / 2;
                if (i % 2 == 0)
                    g.DrawLine(pen, new Point(data.Left, lineCenter), new Point(data.Right, lineCenter));
                i++;
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(this._bmp, 0, 0);
        }
    }
}
