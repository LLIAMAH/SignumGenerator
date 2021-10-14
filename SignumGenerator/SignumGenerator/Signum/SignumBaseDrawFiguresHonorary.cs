using System.Drawing;

namespace SignumGenerator.Signum
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
        private static void DrawPal(Graphics g, Pen pen, SignumData data)
        {
            g.DrawLine(pen, new Point(data.CenterX, data.Top), new Point(data.CenterX, data.Bottom));
        }

        private static void DrawPalNormal(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width / 3; // defined heraldic value
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawPal(g, pen, data);
            }
        }

        private static void DrawPalTight(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value 
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawPal(g, pen, data);
            }
        }

        private static void DrawHead(Graphics g, Pen pen, SignumData data)
        {
            throw new System.NotImplementedException();
        }

        private static void DrawHeadNormal(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width / 3; // defined heraldic value
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawHead(g, pen, data);
            }
        }

        private static void DrawHeadTight(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawHead(g, pen, data);
            }
        }

        private static void DrawBelt(Graphics g, Pen pen, SignumData data)
        {
            g.DrawLine(pen, new Point(data.Left, data.CenterY), new Point(data.Right, data.CenterY));
        }

        private static void DrawBeltNormal(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 3; // defined heraldic value
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawBelt(g, pen, data);
            }
        }

        private static void DrawBeltTight(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawBelt(g, pen, data);
            }
        }

    }
}
