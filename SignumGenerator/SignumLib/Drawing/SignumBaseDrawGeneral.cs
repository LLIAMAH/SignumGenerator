using System.Drawing;
using System.Drawing.Drawing2D;
using SignumLib.Helpers;

namespace SignumLib.Drawing
{
    public partial class SignumBase
    {
        private static Region CreateRegion(Point[] points)
        {
            var gf = new GraphicsPath();
            gf.AddPolygon(points);
            return new Region(gf);
        }

        private static void DrawRegion(Graphics g, Region region, InputBaseData input)
        {
            g.SetClip(region, CombineMode.Replace);
            if (input.TinctureMain.IsFur)
            {
                using (var brush = input.TinctureBg.CreateBrush())
                {
                    g.FillRegion(brush, region);
                }

                using (var image = input.TinctureMain.CreateFur(input.TinctureSub))
                {
                    DrawFur(g, image, _furStep, region, input.TinctureMain);
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

        private static void DrawRegion(Graphics g, Region region, InputLayerData input)
        {
            g.SetClip(region, CombineMode.Replace);
            if (input.TinctureMain.IsFur)
            {
                using (var brush = input.TinctureBg.CreateBrush())
                {
                    g.FillRegion(brush, region);
                }

                using (var image = input.TinctureMain.CreateFur(input.TinctureSub))
                {
                    DrawFur(g, image, _furStep, region, input.TinctureMain);
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
    }
}
