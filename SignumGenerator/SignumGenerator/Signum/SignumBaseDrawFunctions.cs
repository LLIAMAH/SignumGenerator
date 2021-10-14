﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace SignumGenerator.Signum
{
    public partial class SignumBase
    {
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

        private static void DrawQuarters14Tincture(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangles(brush,
                new[]
                {
                    new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2),
                    new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2)
                });
        }

        private static void DrawQuarters14Fur(Graphics g, Image image, SignumData data, SignumTincture tincture)
        {
            DrawFur(g, image, _furStep, new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2), tincture);
            DrawFur(g, image, _furStep, new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2), tincture);
        }

        private static void DrawQuarters23Tincture(Graphics g, Brush brush, SignumData data)
        {
            g.FillRectangles(brush,
                new[]
                {
                    new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2),
                    new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2)
                });
        }

        private static void DrawQuarters23Fur(Graphics g, Image image, SignumData data, SignumTincture tincture)
        {
            DrawFur(g, image, _furStep, new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2), tincture);
            DrawFur(g, image, _furStep, new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2), tincture);
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
            if (count == 0)
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

        private static void DrawStripesPal(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if(count == 0)
                return;

            var pileZone  = data.Width / count;
            var pileZoneCenter = pileZone / 2;
            var i = 0;
            while (i < count)
            {
                g.DrawLine(pen, new Point(pileZoneCenter, data.Top), new Point(pileZoneCenter, data.Bottom));
                pileZoneCenter += pileZone;
                i++;
            }
        }

        private static void DrawStripesBar(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if (count == 0)
                return;

            var pileZone = data.Height / count;
            var pileZoneCenter = pileZone / 2;
            var i = 0;
            while (i < count)
            {
                g.DrawLine(pen, new Point(data.Left, pileZoneCenter), new Point(data.Right, pileZoneCenter));
                pileZoneCenter += pileZone;
                i++;
            }
        }

        private static void DrawFur(Graphics g, Image image, int step, Region region, SignumTincture tincture)
        {
            var rect = region.GetBounds(g);
            g.SetClip(region, CombineMode.Union);
        }

        private static void DrawFur(Graphics g, Image image, int step, Rectangle rect, SignumTincture tincture)
        {
            var localBmp = new Bitmap(rect.Width, rect.Height);
            var localG = Graphics.FromImage(localBmp);
            var localRect = new Rectangle(0, 0, rect.Width, rect.Height);

            var i = localRect.Left;
            var j = localRect.Top;
            while (j - step < localRect.Bottom)
            {
                while (i - step < localRect.Right)
                {
                    var isEven = (j / step) % 2 == 0;
                    var tempRect = isEven
                        ? new Rectangle(i, j, step, step)
                        : (tincture.IsShifted
                            ? new Rectangle(i, j, step, step)
                            : new Rectangle(i - step / 2, j, step, step));

                    localG.DrawImage(image, tempRect);
                    i += step;
                }

                if(tincture.IsCounter)
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);

                i = 0;
                j += step;
            }

            g.DrawImage(localBmp, rect);
        }
    }
}
