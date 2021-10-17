using System.Drawing;
using System.Drawing.Drawing2D;
using SignumGenerator.Helpers;

namespace SignumGenerator.Signum
{
    public partial class SignumBase
    {
        private static void DrawSliceLeftNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.Left, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSliceLeftInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Bottom),
                new(data.Right, data.Top),
                new(data.Right, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSliceRightNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.Right, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSliceRightInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Bottom),
                new(data.Left, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSplitVerticalRight(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Width / 2, data.Top, data.Width / 2, data.Height);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawSplitVerticalLeft(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Top, data.Width / 2, data.Height);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawSplitHorizontalNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Top, data.Width, data.Height / 2);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawSplitHorizontalInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Height / 2, data.Width, data.Height / 2);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawChevronPointOffsetSizeNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var halfSize = input?.Param1 is null or 0 ? GetHeraldicWidthSling() / 2 : input.Param1.Value / 2;
            var point = input?.Param2 is null or 0 ? data.CenterY : input.Param2.Value;
            var offset = input?.Param3 is null or 0 ? data.Width / 2 : input.Param3.Value;

            var points = new Point[]
            {
                new(data.Left, point + offset - halfSize),
                new(data.CenterX, point - halfSize),
                new(data.Right, point + offset - halfSize),
                new(data.Right, point + offset + halfSize),
                new(data.CenterX, point + halfSize),
                new(data.Left, point + offset + halfSize)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronPointOffsetSizeInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var halfSize = input?.Param1 is null or 0 ? GetHeraldicWidthSling() / 2 : input.Param1.Value / 2;
            var point = input?.Param2 is null or 0 ? data.CenterY : input.Param2.Value;
            var offset = input?.Param3 is null or 0 ? data.Width / 2 : input.Param3.Value;

            var points = new Point[]
            {
                new(data.Left, point - offset - halfSize),
                new(data.CenterX, point - halfSize),
                new(data.Right, point - offset - halfSize),
                new(data.Right, point - offset + halfSize),
                new(data.CenterX, point + halfSize),
                new(data.Left, point - offset + halfSize)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronFullNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var points = new Point[]
            {
                new(data.Left, data.Bottom - size),
                new(data.CenterX, data.Top),
                new(data.Right, data.Bottom - size),
                new(data.Right, data.Bottom),
                new(data.CenterX, data.Top + size),
                new(data.Left, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronFullInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.CenterX, data.Bottom - size),
                new(data.Right, data.Top),
                new(data.Right, data.Top + size),
                new(data.CenterX, data.Bottom),
                new(data.Left, data.Top + size)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronMiddleNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var halfSize = size / 2;
            var points = new Point[]
            {
                new(data.Left, data.CenterY - halfSize + data.Width / 2),
                new(data.CenterX, data.CenterY - halfSize),
                new(data.Right, data.CenterY - halfSize + data.Width / 2),
                new(data.Right, data.CenterY + halfSize + data.Width / 2),
                new(data.CenterX, data.CenterY + halfSize),
                new(data.Left, data.CenterY + halfSize + data.Width / 2)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronMiddleInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var halfSize = size / 2;
            var points = new Point[]
            {
                new(data.Left, data.CenterY - halfSize - data.Width / 2),
                new(data.CenterX, data.CenterY - halfSize),
                new(data.Right, data.CenterY - halfSize - data.Width / 2),
                new(data.Right, data.CenterY + halfSize - data.Width / 2),
                new(data.CenterX, data.CenterY + halfSize),
                new(data.Left, data.CenterY + halfSize - data.Width / 2)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawQuarter(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2);
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawQuartersDiagonalLeftRight(Graphics g, SignumData data, InputLayerData input)
        {
            var region = CreateRegion(new Point[]
            {
                new(data.Left, data.Top),
                new(data.CenterX, data.CenterY),
                new(data.Left, data.Bottom)
            });
            region.Union(CreateRegion(new Point[]
            {
                new(data.Right, data.Top),
                new(data.CenterX, data.CenterY),
                new(data.Right, data.Bottom)
            }));

            DrawRegion(g, region, input);
        }

        private static void DrawQuartersDiagonalTopBottom(Graphics g, SignumData data, InputLayerData input)
        {
            var region = CreateRegion(new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.CenterX, data.CenterY)
            });
            region.Union(CreateRegion(new Point[]
            {
                new(data.Left, data.Bottom),
                new(data.CenterX, data.CenterY),
                new(data.Right, data.Bottom)
            }));

            DrawRegion(g, region, input);
        }

        private static void DrawQuarters14(Graphics g, SignumData data, InputLayerData input)
        {
            var rect1 = new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2);
            var rect2 = new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2);
            var region = rect1.ToRegion(rect2.ToRegion());
            DrawRegion(g, region, input);
        }

        private static void DrawQuarters23(Graphics g, SignumData data, InputLayerData input)
        {
            var rect1 = new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2);
            var rect2 = new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2);
            var region = rect1.ToRegion(rect2.ToRegion());
            DrawRegion(g, region, input);
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
                        new(i + size / 2, j),
                        new(i + size, j + size / 2),
                        new(i + size / 2, j + size),
                        new(i, j + size / 2)
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
            if (count == 0)
                return;

            var pileZone = data.Width / count;
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
            g.SetClip(region, CombineMode.Replace);
            DrawFur(g, image, step, new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height),
                tincture);
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

                if (tincture.IsCounter)
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);

                i = 0;
                j += step;
            }

            g.DrawImage(localBmp, rect);
        }
    }
}
