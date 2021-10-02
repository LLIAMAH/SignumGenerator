using System.Drawing;

namespace SignumGenerator.Signum
{
    public enum ETincture
    {
        Default,
        Gules, // Scarlet
        Azure, // Blue
        Vert, // Green
        Purpure, // Purple
        Sable, // Black
        Or, // 255, 215, 0
        Argent, // 192, 192, 192 left as White? 
        Ermine,
        Vair,
        Sanguine,
        Murrey,
        Tenne
    }

    public static class SignumColor
    {
        public static Color GetColor(ETincture eTincture)
        {
            return eTincture switch
            {
                ETincture.Azure => Color.FromArgb(255, 0, 125, 255),
                ETincture.Gules => Color.FromArgb(255, 255, 36, 0),
                ETincture.Purpure => Color.FromArgb(255, 160, 32, 240),
                ETincture.Sable => Color.FromArgb(255, 0, 0, 0),
                ETincture.Vert => Color.FromArgb(255, 0, 75, 0),
                ETincture.Or => Color.FromArgb(255, 255, 215, 0),
                ETincture.Argent => Color.FromArgb(255, 192, 192, 192),
                ETincture.Sanguine => Color.FromArgb(255, 188, 63, 74),
                ETincture.Murrey => Color.FromArgb(255, 139, 0, 75),
                ETincture.Tenne => Color.FromArgb(255, 205, 87, 00),
                _ => Color.FromArgb(255, 0, 0, 0)
            };
        }
    }
}
