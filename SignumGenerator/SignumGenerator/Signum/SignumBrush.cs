using System.Drawing;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;

namespace SignumGenerator.Signum
{
    public static class SignumBrush
    {
        public static Brush CreateBrush(ETincture eTincture)
        {
            return new SolidBrush(SignumColor.GetColor(eTincture));
        }

        public static Image CreateBrushSpecific(ETincture eTincture)
        {
            return SignumColor.GetColorFur(eTincture);
        }

        public static Brush CreateBrush(Color color)
        {
            return new SolidBrush(color);
        }
    }
}
