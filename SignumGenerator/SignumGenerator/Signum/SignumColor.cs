using System.Drawing;

namespace SignumGenerator.Signum
{
    public enum Electrum
    {
        Gules, // Scarlet
        Azure, // Blue
        Vert, // Grreen
        Purpure, // Purple
        Sable, // Black
    }

    public enum Metal
    {
        Or, // 255, 215, 0
        Argent // 192, 192, 192 left as White? 
    }

    public static class SignumColor
    {
        public static Color GetColor(Electrum electrum)
        {
            return electrum switch
            {
                Electrum.Azure => Color.FromArgb(255, 0, 125, 255),
                Electrum.Gules => Color.FromArgb(255, 255, 36, 0),
                Electrum.Purpure => Color.FromArgb(255, 160, 32, 240),
                Electrum.Sable => Color.FromArgb(255, 0, 0, 0),
                Electrum.Vert => Color.FromArgb(255, 0, 75, 0),
                _ => Color.FromArgb(255, 0, 0, 0)
            };
        }

        public static Color GetColor(Metal metal)
        {
            return metal switch
            {
                Metal.Or => Color.FromArgb(255, 255, 215, 0),
                Metal.Argent => Color.FromArgb(255, 192, 192, 192),
                _ => Color.FromArgb(255, 255, 255, 255)
            };
        }
    }
}
