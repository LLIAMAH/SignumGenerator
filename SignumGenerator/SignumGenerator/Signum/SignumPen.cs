using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumPen
    {
        private const int _width = 4;

        public static Pen CreatePen(Electrum electrum)
        {
            return new Pen(SignumColor.GetColor(electrum));
        }

        public static Pen CreatePen(Metal metal)
        {
            return new Pen(SignumColor.GetColor(metal));
        }

        public static Pen CreatePen(Color color, int width = 1)
        {
            return new Pen(color, width);
        }
    }
}
