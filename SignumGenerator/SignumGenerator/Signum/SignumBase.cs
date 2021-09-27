using System.Drawing;

namespace SignumGenerator.Signum
{
    public enum SignumBasePattern
    {
        StripesHorizontal,
        StripesVertical,
        Quarter,
        Quarters_1_4,
        Quarters_2_3,
        SlingLeft,
        SlingRight,
        CheckersNormal,
        CheckersInverse
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

        public void ApplyBase(Color color)
        {
            var brushSecondary = SignumBrush.CreateBrush(color);
            _g.FillRectangle(brushSecondary, 0, 0, Width, Height);
        }

        public void ApplyPattern(SignumBasePattern pattern, Color primary, int size = 0)
        {
            switch (pattern)
            {
                case SignumBasePattern.StripesHorizontal:
                {
                    DrawStripesHorizontal(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.StripesVertical:
                {
                    DrawStripesVertical(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.SlingRight:
                {
                    using (var pen = SignumPen.CreatePen(primary, size == 0 ? 1 : size))
                    {
                        _g.DrawLine(pen, _data.PointTopLeft, _data.PointBottomRight);
                    }
                    break;
                }
                case SignumBasePattern.SlingLeft:
                {
                    using (var pen = SignumPen.CreatePen(primary, size == 0 ? 1 : size))
                    {
                        _g.DrawLine(pen, _data.PointTopRight, _data.PointBottomLeft);
                    }
                    break;
                }
                case SignumBasePattern.Quarters_1_4:
                {
                    using (var brush = SignumBrush.CreateBrush(primary))
                    {
                        _g.FillRectangles(brush,
                            new[]
                            {
                                new Rectangle(_data.Left, _data.Top, _data.Width / 2, _data.Height / 2),
                                new Rectangle(_data.CenterX, _data.CenterY, _data.Width / 2, _data.Height / 2)
                            });
                    }
                    break;
                }
                case SignumBasePattern.Quarters_2_3:
                {
                    using (var brush = SignumBrush.CreateBrush(primary))
                    {
                        _g.FillRectangles(brush,
                            new[]
                            {
                                new Rectangle(_data.CenterX, _data.Top, _data.Width / 2, _data.Height / 2),
                                new Rectangle(_data.Left, _data.CenterY, _data.Width / 2, _data.Height / 2)
                            });
                    }
                    break;
                }
                case SignumBasePattern.CheckersNormal:
                {
                    if (size == 0)
                        size = 100;

                    using (var brush = SignumBrush.CreateBrush(primary))
                    {
                        DrawCheckersNormal(_g, brush, _data, size);
                    }
                    break;
                }
                case SignumBasePattern.CheckersInverse:
                {
                    if (size == 0)
                        size = 100;

                    using (var brush = SignumBrush.CreateBrush(primary))
                    {
                        DrawCheckersInverse(_g, brush, _data, size);
                    }
                    break;
                }
                case SignumBasePattern.Quarter:
                {
                    using (var brush = SignumBrush.CreateBrush(primary))
                    {
                        
                    }
                    break;
                }
                default: break;
            }
        }

        private static void DrawCheckersNormal(Graphics g, Brush brush, SignumData data, int size)
        {
            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    if ((j / size) % 2 == 0)
                    {
                        if ((i / size) % 2 == 0)
                            FillRect(g, brush, i, j, size, size);
                    }
                    else
                    {
                        if ((i / size) % 2 == 1)
                            FillRect(g, brush, i, j, size, size);
                    }
                }
            }
        }

        private static void DrawCheckersInverse(Graphics g, Brush brush, SignumData data, int size)
        {
            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    if ((j / size) % 2 == 0)
                    {
                        if ((i / size) % 2 == 1)
                            FillRect(g, brush, i, j, size, size);
                    }
                    else
                    {
                        if ((i / size) % 2 == 0)
                            FillRect(g, brush, i, j, size, size);
                    }
                }
            }
        }

        private static void FillRect(Graphics g, Brush brush, int x, int y, int width, int height)
        {
            var rect = new Rectangle(x, y, width, height);
            g.FillRectangle(brush, rect);
        }

        private static void DrawStripesHorizontal(Graphics g, Color primary, SignumData data, int count)
        {
            if(count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary color
            //// 1- means 1 primary stripe and 1 background color
            var i = 0;
            var lineWidth = data.Height / (count * 2);
            using var pen = SignumPen.CreatePen(primary, lineWidth);
            while (i < data.Height)
            {
                var lineCenter = i * lineWidth + lineWidth / 2;
                if (i % 2 == 0)
                    g.DrawLine(pen, new Point(data.Left, lineCenter), new Point(data.Right, lineCenter));
                i++;
            }
        }

        private static void DrawStripesVertical(Graphics g, Color primary, SignumData data, int count)
        {
            if (count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary color
            //// 1- means 1 primary stripe and 1 background color
            var i = 0;
            var lineWidth = data.Width / (count * 2);
            using var pen = SignumPen.CreatePen(primary, lineWidth);
            while (i < data.Width)
            {
                var lineCenter = i * lineWidth + lineWidth / 2;
                if (i % 2 == 0)
                    g.DrawLine(pen, new Point(lineCenter, data.Top), new Point(lineCenter, data.Bottom));
                i++;
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(this._bmp, 0, 0);
        }
    }
}
