using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumPen
    {
        private const int _width = 4;

        public static Pen CreatePen(ETincture eTincture)
        {
            return new Pen(SignumColor.GetColor(eTincture));
        }

        public static Pen CreatePen(Color color, int width = 1)
        {
            return new Pen(color, width);
        }
    }
}
