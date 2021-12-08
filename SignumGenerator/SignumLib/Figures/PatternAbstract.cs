using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SignumLib.Figures
{
    public abstract class PatternAbstract
    {
        protected static int Width { get; private set; } = 800;
        protected static int Height { get; private set; } = 1000;        

        protected static int GetHeraldicWidthFull(SignumData data)
        {
            return data.Width / 3;
        }

        protected static int GetHeraldicWidthNormal(SignumData data)
        {
            return data.Width * 2 / 7; // defined heraldic value 
        }

        protected static int GetHeraldicWidthSling()
        {
            // value taken empirically
            // TODO: calculate correct data by required size and diagonal angle.
            return 228;
        }

        protected static Region CreateRegion(Point[] points)
        {
            var gf = new GraphicsPath();
            gf.AddPolygon(points);
            return new Region(gf);
        }

        protected static void DrawRegion(Graphics g, Region region, InputBaseData input)
        {
            g.SetClip(region, CombineMode.Replace);
            if (input.TinctureMain.IsFur || input.TinctureMain.IsComplex)
            {
                using (var brush = input.TinctureBg.CreateBrush())
                {
                    g.FillRegion(brush, region);
                }

                using (var image = input.TinctureMain.CreateFur(input.TinctureSub))
                {
                    DrawFur(g, image, input.StepBG, region, input.TinctureMain);
                }
            }
            else
            {
                using (var brush = input.TinctureMain.CreateBrush())
                {
                    g.FillRegion(brush, region);
                }
            }
        }

        protected static void DrawRegion(Graphics g, Region region, InputLayerData input)
        {
            g.SetClip(region, CombineMode.Replace);
            if (input.TinctureMain.IsFur || input.TinctureMain.IsComplex)
            {
                using (var brush = input.TinctureBg.CreateBrush())
                {
                    g.FillRegion(brush, region);
                }

                using (var image = input.TinctureMain.CreateFur(input.TinctureSub))
                {
                    DrawFur(g, image, input.StepBG, region, input.TinctureMain);
                }
            }
            else
            {
                using (var brush = input.TinctureMain.CreateBrush())
                {
                    g.FillRegion(brush, region);
                }
            }
        }

        protected static void DrawFur(Graphics g, Image image, int step, Region region, SignumTincture tincture)
        {
            var rect = region.GetBounds(g);
            g.SetClip(region, CombineMode.Replace);
            DrawFur(g, image, step, new Rectangle((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height),
                tincture);
        }

        protected static void DrawFur(Graphics g, Image image, int step, Rectangle rect, SignumTincture tincture)
        {
            var localBmp = new Bitmap(rect.Width, rect.Height);
            var localG = Graphics.FromImage(localBmp);
            var localRect = new Rectangle(0, 0, Width, Height);

            var i = localRect.Left;
            var j = localRect.Top;
            while (j - step < localRect.Bottom)
            {
                while (i - step < localRect.Right)
                {
                    Rectangle tempRect;
                    if (tincture.Tincture is ETincture.VairVs)
                        tempRect = new Rectangle(i, j, step, step);
                    else
                    {
                        var isEven = (j / step) % 2 == 0;
                        tempRect = isEven
                            ? new Rectangle(i, j, step, step)
                            : new Rectangle(i - step / 2, j, step, step);
                    }

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

        protected static void FillRect(Graphics g, Brush brush, int x, int y, int width, int height)
        {
            var rect = new Rectangle(x, y, width, height);
            g.FillRectangle(brush, rect);
        }
    }
}
