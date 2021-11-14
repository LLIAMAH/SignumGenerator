using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternCroix : PatternAbstract, IPattern
    {
        private readonly PatternPosition _position;

        public PatternCroix(PatternPosition common)
        {
            this._position = common;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._position)
            {
                case PatternPosition.Common:
                    {
                        DrawHonoraryCroix(g, data, input);
                        break;
                    }
                case PatternPosition.Diagonal:
                    {
                        DrawHonoraryCroixDiagonal(g, data, input);
                        break ;
                    }
                default:
                    {
                        DrawHonoraryCroix(g, data, input);
                        break;
                    }
            }
        }

        private static void DrawHonoraryCroix(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthNormal(data)
                : input.Param1.Value;

            var lineWidthHalf = lineWidth / 2;
            var rect = new Rectangle(
                new Point(data.CenterX - lineWidthHalf, data.Top),
                new Size(lineWidth, data.Height));
            var region = rect
                .ToRegion(
                    new Rectangle(
                            new Point(data.Left, data.CenterY - lineWidthHalf),
                            new Size(data.Width, lineWidth))
                        .ToRegion());
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryCroixDiagonal(Graphics g, SignumData data, InputLayerData input)
        {
            var lineHalfSizeForSling = input.Param1 is null or 0
                ? GetHeraldicWidthSling() / 2
                : input.Param1.Value / 2;

            var points1 = new Point[]
            {
                new(data.Left, data.Top - lineHalfSizeForSling),
                new(data.Right, data.Bottom - lineHalfSizeForSling),
                new(data.Right, data.Bottom + lineHalfSizeForSling),
                new(data.Left, data.Top + lineHalfSizeForSling)
            };
            var points2 = new Point[]
            {
                new(data.Left, data.Bottom - lineHalfSizeForSling),
                new(data.Right, data.Top - lineHalfSizeForSling),
                new(data.Right, data.Top + lineHalfSizeForSling),
                new(data.Left, data.Bottom + lineHalfSizeForSling)
            };

            var region1 = CreateRegion(points1);
            var region2 = CreateRegion(points2);
            region1.Union(region2);

            DrawRegion(g, region1, input);
        }
    }
}
