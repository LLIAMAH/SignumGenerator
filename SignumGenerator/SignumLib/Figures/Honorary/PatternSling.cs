using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternSling : PatternAbstract, IPatternLayer
    {
        private readonly PatternSide _side;

        public PatternSling(PatternSide side)
        {
            this._side = side;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }

        private static void DrawHonorarySlingLeft(Graphics g, SignumData data, InputLayerData input)
        {
            var lineHalfSizeForSling = input.Param1 is null or 0
                ? GetHeraldicWidthSling() / 2
                : input.Param1.Value / 2;

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
            var lineHalfSizeForSling = input.Param1 is null or 0
                ? GetHeraldicWidthSling() / 2
                : input.Param1.Value / 2;

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
    }
}
