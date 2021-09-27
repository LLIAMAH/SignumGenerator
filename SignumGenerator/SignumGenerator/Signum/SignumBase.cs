using System.Drawing;
using System.Drawing.Drawing2D;

namespace SignumGenerator.Signum
{
    public enum SignumBasePattern
    {
        StripesHorizontal,
        StripesVertical,
        Quarter,
        Quarters_1_4,
        Quarters_2_3,
        QuartersDiagonalTopBottom,
        QuartersDiagonalLeftRight,
        SlingLeft,
        SlingRight,
        CheckersNormal,
        CheckersInverse,
        CheckersDiagonal,
        ChevronMiddleNormal,
        ChevronMiddleInvert,
        ChevronFullNormal,
        ChevronFullInvert,
        SplitHorizontalNormal,
        SplitHorizontalInvert,
        SplitVerticalNormal,
        SplitVerticalInvert,
        SliceLeftNormal,
        SliceLeftInvert,
        SliceRightNormal,
        SliceRightInvert
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
                    DrawSlingRight(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.SlingLeft:
                {
                    DrawSlingLeft(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.Quarters_1_4:
                {
                    DrawQuarters14(_g, primary, _data);
                    break;
                }
                case SignumBasePattern.Quarters_2_3:
                {
                    DrawQuarters23(_g, primary, _data);
                    break;
                }
                case SignumBasePattern.QuartersDiagonalTopBottom:
                {
                    DrawQuartersDiagonalTopBottom(_g, primary, _data);
                    break;
                }
                case SignumBasePattern.QuartersDiagonalLeftRight:
                {
                    DrawQuartersDiagonalLeftRight(_g, primary, _data);
                    break;
                }
                case SignumBasePattern.CheckersNormal:
                {
                    DrawCheckersNormal(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.CheckersInverse:
                {
                    DrawCheckersInverse(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.CheckersDiagonal:
                {
                    DrawCheckersDiagonal(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.Quarter:
                {
                    DrawQuarter(_g, primary, _data);
                    break;
                }
                case SignumBasePattern.ChevronMiddleNormal:
                {
                    DrawChevronMiddleNormal(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.ChevronMiddleInvert:
                {
                    DrawChevronMiddleInvert(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.ChevronFullNormal:
                {
                    DrawChevronFullNormal(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.ChevronFullInvert:
                {
                    DrawChevronFullInvert(_g, primary, _data, size);
                    break;
                }
                case SignumBasePattern.SplitHorizontalNormal:
                {
                    DrawSplitHorizontalNormal(_g, primary, _data);
                    break;
                }
                case SignumBasePattern.SplitHorizontalInvert:
                {
                    DrawSplitHorizontalInvert(_g, primary, _data);
                    break;
                }

                case SignumBasePattern.SplitVerticalNormal:{ break;}
                case SignumBasePattern.SplitVerticalInvert:{ break;}
                case SignumBasePattern.SliceLeftNormal:{ break;}
                case SignumBasePattern.SliceLeftInvert:{ break;}
                case SignumBasePattern.SliceRightNormal:{ break;}
                case SignumBasePattern.SliceRightInvert:{ break;}
                default: {break;}
            }
        }

        private static void DrawSplitHorizontalNormal(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillRectangle(brush, new Rectangle(data.Left, data.Top, data.Width, data.Height / 2));
        }

        private static void DrawSplitHorizontalInvert(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillRectangle(brush, new Rectangle(data.Left, data.Height / 2, data.Width, data.Height / 2));
        }

        private static void DrawChevronFullInvert(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
            var points = new Point[]
            {
                new Point(data.Left, data.Top),
                new Point(data.CenterX, data.Bottom - size),
                new Point(data.Right, data.Top),
                new Point(data.Right, data.Top + size),
                new Point(data.CenterX, data.Bottom),
                new Point(data.Left, data.Top + size),
                new Point(data.Left, data.Top),
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronFullNormal(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
            var points = new Point[]
            {
                new Point(data.Left, data.Bottom - size),
                new Point(data.CenterX, data.Top),
                new Point(data.Right, data.Bottom - size),
                new Point(data.Right, data.Bottom),
                new Point(data.CenterX, data.Top + size),
                new Point(data.Left, data.Bottom),
                new Point(data.Left, data.Bottom - size)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronMiddleInvert(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
            var points = new Point[]
            {
                new Point(data.Left, data.CenterY - size / 2 - data.Width / 2),
                new Point(data.CenterX, data.CenterY - size / 2),
                new Point(data.Right, data.CenterY - size / 2 - data.Width / 2),
                new Point(data.Right, data.CenterY + size / 2 - data.Width / 2),
                new Point(data.CenterX, data.CenterY + size / 2),
                new Point(data.Left, data.CenterY + size / 2 - data.Width / 2),
                new Point(data.Left, data.CenterY - size / 2 - data.Width / 2)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronMiddleNormal(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
            var points = new Point[]
            {
                new Point(data.Left, data.CenterY - size / 2 + data.Width / 2),
                new Point(data.CenterX, data.CenterY - size / 2),
                new Point(data.Right, data.CenterY - size / 2 + data.Width / 2),
                new Point(data.Right, data.CenterY + size / 2 + data.Width / 2),
                new Point(data.CenterX, data.CenterY + size / 2),
                new Point(data.Left, data.CenterY + size / 2 + data.Width / 2),
                new Point(data.Left, data.CenterY - size / 2 + data.Width / 2)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawQuarter(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillRectangle(brush,
                new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2));
        }

        private static void DrawQuartersDiagonalLeftRight(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Left, data.Top),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Left, data.Bottom),
                    new Point(data.Left, data.Top)
                });
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Right, data.Top),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Right, data.Bottom),
                    new Point(data.Right, data.Top)
                });
        }

        private static void DrawQuartersDiagonalTopBottom(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Left, data.Top),
                    new Point(data.Right, data.Top),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Left, data.Top),
                });
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Left, data.Bottom),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Right, data.Bottom),
                    new Point(data.Left, data.Bottom),
                });
        }

        private static void DrawQuarters23(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillRectangles(brush,
                new[]
                {
                    new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2),
                    new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2)
                });
        }

        private static void DrawQuarters14(Graphics g, Color color, SignumData data)
        {
            using var brush = SignumBrush.CreateBrush(color);
            g.FillRectangles(brush,
                new[]
                {
                    new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2),
                    new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2)
                });
        }

        private static void DrawSlingLeft(Graphics g, Color color, SignumData data, int size)
        {
            using var pen = SignumPen.CreatePen(color, size == 0 ? 1 : size);
            g.DrawLine(pen, data.PointTopRight, data.PointBottomLeft);
        }

        private static void DrawSlingRight(Graphics g, Color color, SignumData data, int size)
        {
            using var pen = SignumPen.CreatePen(color, size == 0 ? 1 : size);
            g.DrawLine(pen, data.PointTopLeft, data.PointBottomRight);
        }

        private static void DrawCheckersNormal(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
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

        private static void DrawCheckersInverse(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
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

        private static void DrawCheckersDiagonal(Graphics g, Color color, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            using var brush = SignumBrush.CreateBrush(color);
            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    var points = new Point[]
                    {
                        new Point(i + size / 2, j),
                        new Point(i + size, j + size / 2),
                        new Point(i + size / 2, j + size),
                        new Point(i, j + size / 2),
                        new Point(i + size / 2, j)
                    };

                    g.FillPolygon(brush, points);
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
            //this.ApplyShield(g);
            g.DrawImage(this._bmp, 0, 0);
        }

        private void ApplyShield(Graphics g)
        {
            var paramOffset = 200;
            var path = new GraphicsPath();
            path.AddLine(new Point(_data.Left, _data.Bottom - paramOffset), new Point(_data.Left, _data.Top));
            path.AddLine(new Point(_data.Left, _data.Top), new Point(_data.Right, _data.Top));
            path.AddLine(new Point(_data.Right, _data.Top), new Point(_data.Right, _data.Bottom - paramOffset));
            path.AddLine(new Point(_data.Right, _data.Bottom - paramOffset), new Point(_data.CenterX, _data.Bottom));
            path.AddLine(new Point(_data.CenterX, _data.Bottom), new Point(_data.Left, _data.Bottom - paramOffset));
            //path.AddArc(new Rectangle(_data.Right, _data.Bottom - paramOffset, _data.Width / 2, paramOffset),  270, 180);
            //path.AddArc(new Rectangle(_data.Left, _data.Bottom - paramOffset, _data.Width / 2, paramOffset), 270, 180);

            var region = new Region(path);

            g.DrawImage(this._bmp, new Point(0, 0));
            g.SetClip(region, CombineMode.Replace);
        }
    }
}
