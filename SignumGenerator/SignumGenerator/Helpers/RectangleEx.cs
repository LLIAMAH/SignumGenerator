using System.Drawing;

namespace SignumGenerator.Helpers
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
    }
}
