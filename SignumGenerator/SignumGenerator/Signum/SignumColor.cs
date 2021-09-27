using System.Drawing;

namespace SignumGenerator.Signum
{
    public enum EColor
    {
        Default,
        Gules, // Scarlet
        Azure, // Blue
        Vert, // Grreen
        Purpure, // Purple
        Sable, // Black
        Or, // 255, 215, 0
        Argent // 192, 192, 192 left as White? 
    }

    public static class SignumColor
    {
        public static Color GetColor(EColor eColor)
        {
            return eColor switch
            {
                EColor.Azure => Color.FromArgb(255, 0, 125, 255),
                EColor.Gules => Color.FromArgb(255, 255, 36, 0),
                EColor.Purpure => Color.FromArgb(255, 160, 32, 240),
                EColor.Sable => Color.FromArgb(255, 0, 0, 0),
                EColor.Vert => Color.FromArgb(255, 0, 75, 0),
                EColor.Or => Color.FromArgb(255, 255, 215, 0),
                EColor.Argent => Color.FromArgb(255, 192, 192, 192),
                _ => Color.FromArgb(255, 0, 0, 0)
            };
        }
    }
}
