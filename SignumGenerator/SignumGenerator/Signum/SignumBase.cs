using System.Drawing;
using System.Drawing.Drawing2D;
using SignumGenerator.Helpers;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

// ReSharper disable All

namespace SignumGenerator.Signum
{
    public enum SignumBasePattern
    {
        Default,
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
        ChevronPointOffsetSizeNormal,
        ChevronPointOffsetSizeInvert,
        SplitHorizontalNormal,
        SplitHorizontalInvert,
        SplitVerticalLeft,
        SplitVerticalRight,
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

        public void ApplyPattern(InputData input)
        {
            switch (input.Pattern)
            {
                case SignumBasePattern.StripesHorizontal:
                {
                    var lineWidth = _data.Height / (input.Param * 2);
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), lineWidth))
                    {
                        DrawStripesHorizontal(_g, pen, _data, lineWidth, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.StripesVertical:
                {
                    var lineWidth = _data.Width / (input.Param * 2);
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), lineWidth))
                    {
                        DrawStripesVertical(_g, pen, _data, lineWidth, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.SlingRight:
                {
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), input.Param == 0 ? 1 : input.Param))
                    {
                        DrawSlingRight(_g, pen, _data);
                    }

                    break;
                }
                case SignumBasePattern.SlingLeft:
                {
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), input.Param == 0 ? 1 : input.Param))
                    {
                        DrawSlingLeft(_g, pen, _data);
                    }

                    break;
                }
                case SignumBasePattern.Quarters_1_4:
                {
                    if (input.IsTinctureColor || input.IsTinctureMetal)
                    {
                        using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                        {
                            DrawQuarters14(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var image = SignumColor.GetColorFur(input.Tincture))
                        {
                            DrawQuarters14(_g, image, _data);
                        }
                    }

                    break;
                }
                case SignumBasePattern.Quarters_2_3:
                {
                    if (input.IsTinctureColor || input.IsTinctureMetal)
                    {
                        using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                        {
                            DrawQuarters23(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var image = SignumColor.GetColorFur(input.Tincture))
                        {
                            DrawQuarters23(_g, image, _data);
                        }
                    }

                    break;
                }
                case SignumBasePattern.QuartersDiagonalTopBottom:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawQuartersDiagonalTopBottom(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.QuartersDiagonalLeftRight:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawQuartersDiagonalLeftRight(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.CheckersNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawCheckersNormal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.CheckersInverse:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawCheckersInverse(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.CheckersDiagonal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawCheckersDiagonal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.Quarter:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawQuarter(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.ChevronMiddleNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronMiddleNormal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronMiddleInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronMiddleInvert(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronFullNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronFullNormal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronFullInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronFullInvert(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                {
                    var point = 100;
                    var offset = 200;
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronPointOffsetSizeNormal(_g, brush, _data, point, offset, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                {
                    var point = 400;
                    var offset = 200;
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronPointOffsetSizeInvert(_g, brush, _data, point, offset, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.SplitHorizontalNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitHorizontalNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitHorizontalInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitHorizontalInvert(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitVerticalLeft:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitVerticalLeft(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitVerticalRight:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitVerticalRight(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceLeftNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceLeftNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceLeftInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceLeftInvert(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceRightNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceRightNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceRightInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceRightInvert(_g, brush, _data);
                    }

                    break;
                }
                default: {break;}
            }
        }

        private static void DrawChevronPointOffsetSizeNormal(Graphics g, Brush brush, SignumData data, int point,
            int offset, int size)
        {
            if (size == 0)
                size = 100;

            var halfSize = size / 2;
            var points = new Point[]
            {
                new Point(data.Left, point + offset - halfSize),
                new Point(data.CenterX, point - halfSize),
                new Point(data.Right, point + offset - halfSize),
                new Point(data.Right, point + offset + halfSize),
                new Point(data.CenterX, point + halfSize),
                new Point(data.Left, point + offset + halfSize)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronPointOffsetSizeInvert(Graphics g, Brush brush, SignumData data, int point, int offset, int size)
        {
            if (size == 0)
                size = 100;

            var halfSize = size / 2;
            var points = new Point[]
            {
                new Point(data.Left, point - offset - halfSize),
                new Point(data.CenterX, point - halfSize),
                new Point(data.Right, point - offset - halfSize),
                new Point(data.Right, point - offset + halfSize),
                new Point(data.CenterX, point + halfSize),
                new Point(data.Left, point - offset + halfSize)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawSliceLeftNormal(Graphics g, Brush brush, SignumData data)
        {
            g.FillPolygon(brush, new Point[]
            {
                new Point(data.Left, data.Top),
                new Point(data.Right, data.Top),
                new Point(data.Left, data.Bottom)
            });
        }

        private static void DrawSliceLeftInvert(Graphics g, Brush brush, SignumData data)
        {
            g.FillPolygon(brush, new Point[]
            {
                new Point(data.Left, data.Bottom),
                new Point(data.Right, data.Top),
                new Point(data.Right, data.Bottom)
            });
        }

        private static void DrawSliceRightNormal(Graphics g, Brush brush, SignumData data)
        {
            g.FillPolygon(brush, new Point[]
            {
                new Point(data.Left, data.Top),
                new Point(data.Right, data.Top),
                new Point(data.Right, data.Bottom)
            });
        }

        private static void DrawSliceRightInvert(Graphics g, Brush brush, SignumData data)
        {
            g.FillPolygon(brush, new Point[]
            {
                new Point(data.Left, data.Top),
                new Point(data.Right, data.Bottom),
                new Point(data.Left, data.Bottom)
            });
        }

        private static void DrawSplitVerticalRight(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangle(brush, new Rectangle(data.Width / 2, data.Top, data.Width / 2, data.Height));
        }

        private static void DrawSplitVerticalLeft(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangle(brush, new Rectangle(data.Left, data.Top, data.Width / 2, data.Height));
        }

        private static void DrawSplitHorizontalNormal(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangle(brush, new Rectangle(data.Left, data.Top, data.Width, data.Height / 2));
        }

        private static void DrawSplitHorizontalInvert(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangle(brush, new Rectangle(data.Left, data.Height / 2, data.Width, data.Height / 2));
        }

        private static void DrawChevronFullInvert(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            var points = new Point[]
            {
                new Point(data.Left, data.Top), 
                new Point(data.CenterX, data.Bottom - size),
                new Point(data.Right, data.Top),
                new Point(data.Right, data.Top + size),
                new Point(data.CenterX, data.Bottom),
                new Point(data.Left, data.Top + size)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronFullNormal(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            var points = new Point[]
            {
                new Point(data.Left, data.Bottom - size),
                new Point(data.CenterX, data.Top),
                new Point(data.Right, data.Bottom - size),
                new Point(data.Right, data.Bottom),
                new Point(data.CenterX, data.Top + size),
                new Point(data.Left, data.Bottom)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronMiddleInvert(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            var points = new Point[]
            {
                new Point(data.Left, data.CenterY - size / 2 - data.Width / 2),
                new Point(data.CenterX, data.CenterY - size / 2),
                new Point(data.Right, data.CenterY - size / 2 - data.Width / 2),
                new Point(data.Right, data.CenterY + size / 2 - data.Width / 2),
                new Point(data.CenterX, data.CenterY + size / 2),
                new Point(data.Left, data.CenterY + size / 2 - data.Width / 2)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawChevronMiddleNormal(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            var points = new Point[]
            {
                new Point(data.Left, data.CenterY - size / 2 + data.Width / 2),
                new Point(data.CenterX, data.CenterY - size / 2),
                new Point(data.Right, data.CenterY - size / 2 + data.Width / 2),
                new Point(data.Right, data.CenterY + size / 2 + data.Width / 2),
                new Point(data.CenterX, data.CenterY + size / 2),
                new Point(data.Left, data.CenterY + size / 2 + data.Width / 2)
            };
            g.FillPolygon(brush, points);
        }

        private static void DrawQuarter(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangle(brush,
                new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2));
        }

        private static void DrawQuartersDiagonalLeftRight(Graphics g, Brush brush, SignumData data)
        {
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Left, data.Top),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Left, data.Bottom)
                });
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Right, data.Top),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Right, data.Bottom)
                });
        }

        private static void DrawQuartersDiagonalTopBottom(Graphics g, Brush brush, SignumData data)
        {
            
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Left, data.Top),
                    new Point(data.Right, data.Top),
                    new Point(data.CenterX, data.CenterY)
                });
            g.FillPolygon(brush,
                new Point[]
                {
                    new Point(data.Left, data.Bottom),
                    new Point(data.CenterX, data.CenterY),
                    new Point(data.Right, data.Bottom)
                });
        }

        private static void DrawQuarters14(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangles(brush,
                new[]
                {
                    new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2),
                    new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2)
                });
        }

        private static void DrawQuarters14(Graphics g, Image image, SignumData data)
        {
            g.DrawImage(image, new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2));
            g.DrawImage(image, new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2));
        }

        private static void DrawQuarters23(Graphics g, Brush brush, SignumData data)
        {
            //using var brush = SignumBrush.CreateBrush(color);
            g.FillRectangles(brush,
                new[]
                {
                    new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2),
                    new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2)
                });
        }

        private static void DrawQuarters23(Graphics g, Image image, SignumData data)
        {
            //using var brush = SignumBrush.CreateBrush(color);
            g.DrawImage(image, new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2));
            g.DrawImage(image, new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2));
        }

        private static void DrawSlingLeft(Graphics g, Pen pen, SignumData data)
        {
            g.DrawLine(pen, data.PointTopRight, data.PointBottomLeft);
        }

        private static void DrawSlingRight(Graphics g, Pen pen, SignumData data)
        {
            g.DrawLine(pen, data.PointTopLeft, data.PointBottomRight);
        }

        private static void DrawCheckersNormal(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

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
            if (size == 0)
                size = 100;

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

        private static void DrawCheckersDiagonal(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            
            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    var points = new Point[]
                    {
                        new Point(i + size / 2, j),
                        new Point(i + size, j + size / 2),
                        new Point(i + size / 2, j + size),
                        new Point(i, j + size / 2)
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

        private static void DrawStripesHorizontal(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if(count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary tincture
            //// 1- means 1 primary stripe and 1 background tincture
            var i = 0;
            while (i < data.Height)
            {
                var lineCenter = i * lineWidth + lineWidth / 2;
                if (i % 2 == 0)
                    g.DrawLine(pen, new Point(data.Left, lineCenter), new Point(data.Right, lineCenter));
                i++;
            }
        }

        private static void DrawStripesVertical(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if (count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary tincture
            //// 1- means 1 primary stripe and 1 background tincture
            var i = 0;
            
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
