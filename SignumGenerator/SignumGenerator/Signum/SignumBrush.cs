using System.Drawing;

namespace SignumGenerator.Signum
{
    public static class SignumBrush
    {
        public static Brush CreateBrush(ETincture eTincture)
        {
            return new SolidBrush(SignumColor.GetColor(eTincture));
        }

        public static Brush CreateBrush(Color color)
        {
            return new SolidBrush(color);
        }
    }
}
