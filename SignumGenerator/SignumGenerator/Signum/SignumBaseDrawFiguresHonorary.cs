using System.Drawing;
using System.Drawing.Drawing2D;
using SignumGenerator.Helpers;

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

        private static void DrawHonoraryPalNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthFull(data);
            var lineHalf = lineWidth / 2;
            var points = new Point[]
            {
                new(data.CenterX - lineHalf, data.Top),
                new(data.CenterX + lineHalf, data.Top),
                new(data.CenterX + lineHalf, data.Bottom),
                new(data.CenterX - lineHalf, data.Bottom),
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryPalTight(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthNormal(data);

            var rect = new Rectangle(new Point(data.CenterX - lineWidth / 2, data.Top),
                new Size(lineWidth, data.Bottom));
            var region = CreateRegion(rect.ToPoints());

            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryHead(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthNormal(data);

            var rect = new Rectangle(new Point(data.Left, data.Top), new Size(data.Width, lineWidth));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryBelt(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthNormal(data);
            var rect = new Rectangle(new Point(data.Left, data.CenterY - lineWidth / 2), new Size(data.Width, lineWidth));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryEnd(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthNormal(data);
            var rect = new Rectangle(new Point(data.Left, data.Bottom - lineWidth), new Size(data.Width, lineWidth));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryFlankLeft(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthNormal(data);
            var rect = new Rectangle(new Point(data.Left, data.Top), new Size(lineWidth, data.Height));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryFlankRight(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = GetHeraldicWidthNormal(data);
            var rect = new Rectangle(new Point(data.Right - lineWidth, data.Top), new Size(lineWidth, data.Height));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawHonorarySlingLeft(Graphics g, SignumData data, InputLayerData input)
        {
            var lineHalfSizeForSling = GetHeraldicWidthSling();
            var points = new Point[]
            {
                new(data.Left, data.Top - lineHalfSizeForSling),
                new(data.Right, data.Bottom - lineHalfSizeForSling),
                new(data.Right, data.Bottom + lineHalfSizeForSling),
                new(data.Left, data.Top + lineHalfSizeForSling)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawHonorarySlingRight(Graphics g, SignumData data, InputLayerData input)
        {
            var lineHalfSizeForSling = GetHeraldicWidthSling();
            var points = new Point[]
            {
                new(data.Left, data.Bottom - lineHalfSizeForSling),
                new(data.Right, data.Top - lineHalfSizeForSling),
                new(data.Right, data.Top + lineHalfSizeForSling),
                new(data.Left, data.Bottom + lineHalfSizeForSling)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryChevron(Graphics g, SignumData data, InputLayerData input)
        {
            DrawChevronPointOffsetSizeNormal(g, data, input);
        }

        private static void DrawHonoraryChevronInverse(Graphics g, SignumData data, InputLayerData input)
        {
            DrawChevronPointOffsetSizeInvert(g, data, input);
        }

        

        private static void DrawHonoraryCroix(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }

        private static void DrawHonoraryCroixDiagonal(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
