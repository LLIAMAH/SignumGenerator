using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternPal : PatternAbstract, IPatternLayer
    {
        private readonly PatternSize _size;

        public PatternPal(PatternSize size)
        {
            this._size = size;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._size)
            {
                case PatternSize.Normal:
                    {
                        DrawHonoraryPalNormal(g, data, input);
                        break;
                    }
                case PatternSize.Specific:
                    {
                        DrawHonoraryPalTight(g, data, input);
                        break;
                    }
                default:
                    {
                        DrawHonoraryPalNormal(g, data, input);
                        break;
                    }
            }
        }

        private static void DrawHonoraryPalNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthFull(data)
                : input.Param1.Value;

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
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthNormal(data)
                : input.Param1.Value;

            var rect = new Rectangle(new Point(data.CenterX - lineWidth / 2, data.Top),
                new Size(lineWidth, data.Bottom));
            var region = CreateRegion(rect.ToPoints());

            DrawRegion(g, region, input);
        }
    }
}
