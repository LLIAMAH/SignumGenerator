using System.Drawing;

namespace SignumGenerator.Signum
{
    public static class SignumBrush
    {
        public static Brush CreateBrush(EColor eColor)
        {
            return new SolidBrush(SignumColor.GetColor(eColor));
        }

        public static Brush CreateBrush(Color color)
        {
            return new SolidBrush(color);
        }
    }
}
