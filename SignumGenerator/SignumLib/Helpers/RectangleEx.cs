using System.Drawing;
using System.Drawing.Drawing2D;

namespace SignumLib.Helpers
{
    public static class RectangleEx
    {
        internal static Point[] ToPoints(this Rectangle rect)
        {
            return new Point[]
            {
                new(rect.X, rect.Y),
                new(rect.X + rect.Width, rect.Y),
                new(rect.X + rect.Width, rect.Y + rect.Height),
                new(rect.X, rect.Y + rect.Height)
            };
        }

        internal static Region ToRegion(this Rectangle rect)
        {
            var gf = new GraphicsPath();
            gf.AddPolygon(rect.ToPoints());
            return new Region(gf);
        }

        internal static Region ToRegion(this Rectangle rect, Region region)
        {
            var result = rect.ToRegion();
            result.Union(region);
            return result;
        }

        internal static Region ToRegion(this Rectangle rect, Region[] regions)
        {
            var result = rect.ToRegion();
            foreach (var region in regions)
                result.Union(region);
            return result;
        }
    }
}
