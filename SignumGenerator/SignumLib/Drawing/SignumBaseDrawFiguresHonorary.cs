using SignumLib.Base;

namespace SignumLib.Drawing
{
    /*
     * Drawing Honorary heraldic figures
     * ====================================
     * - Head - Chef,
     * - Belt,
     * - Extremity
     * - Pile - Pal
     * - Flank Left
     * - Flank Right,
     * - Sling Left
     * - Sling Right
     * - Chevron
     * - Cross
     * - CrossOblique
     * - CrossForked
     * - CrossForkedInverse
     * - Mince
     * - QuorterFree
     */
    public partial class SignumBase
    {
        private static int GetHeraldicWidthFull(SignumData data)
        {
            return data.Width / 3;
        }

        private static int GetHeraldicWidthNormal(SignumData data)
        {
            return data.Width * 2 / 7; // defined heraldic value 
        }

        private static int GetHeraldicWidthSling()
        {
            // value taken empirically
            // TODO: calculate correct data by required size and diagonal angle.
            return 228;
        }
    }
}
