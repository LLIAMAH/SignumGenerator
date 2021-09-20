using System.Drawing;

namespace SignumGenerator.Signum
{
    public static class SignumBrush
    {
        public static Brush CreateBrush(Electrum electrum)
        {
            return new SolidBrush(SignumColor.GetColor(electrum));
        }

        public static Brush CreateBrush(Metal metal)
        {
            return new SolidBrush(SignumColor.GetColor(metal));
        }
    }
}
