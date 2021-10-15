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
        private static void DrawHonoraryPal(Graphics g, Pen pen, SignumData data)
        {
            g.DrawLine(pen, new Point(data.CenterX, data.Top), new Point(data.CenterX, data.Bottom));
        }

        private static void DrawHonoraryPalNormal(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width / 3; // defined heraldic value
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawHonoraryPal(g, pen, data);
            }
        }

        private static void DrawHonoraryPalTight(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value 
            using (var pen = tincture.CreatePen(lineWidth))
            {
                DrawHonoraryPal(g, pen, data);
            }
        }

        private static void DrawHonoraryHead(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var brush = tincture.CreateBrush())
            {
                g.FillRectangle(brush, new Rectangle(new Point(data.Left, data.Top), new Size(data.Width, lineWidth)));
            }
        }

        private static void DrawHonoraryBelt(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var brush = tincture.CreateBrush())
            {
                g.FillRectangle(brush, new Rectangle(new Point(data.Left, data.CenterY - lineWidth / 2), new Size(data.Width, lineWidth)));
            }
        }

        private static void DrawHonoraryEnd(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var brush = tincture.CreateBrush())
            {
                g.FillRectangle(brush, new Rectangle(new Point(data.Left, data.Bottom - lineWidth), new Size(data.Width, lineWidth)));
            }
        }

        private static void DrawHonoraryFlankLeft(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var brush = tincture.CreateBrush())
            {
                g.FillRectangle(brush, new Rectangle(new Point(data.Left, data.Top), new Size(lineWidth, data.Height)));
            }
        }

        private static void DrawHonoraryFlankRight(Graphics g, SignumData data, SignumTincture tincture)
        {
            var lineWidth = data.Width * 2 / 7; // defined heraldic value
            using (var brush = tincture.CreateBrush())
            {
                g.FillRectangle(brush, new Rectangle(new Point(data.Right - lineWidth, data.Top), new Size(lineWidth, data.Height)));
            }
        }
    }
}
