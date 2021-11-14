using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternChevron : PatternAbstract, IPattern
    {
        private readonly PatternDirection _direction;

        public PatternChevron(PatternDirection normal)
        {
            this._direction = normal;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            DrawHonoraryChevron(g, data, input);
        }

        private static void DrawHonoraryChevron(Graphics g, SignumData data, InputLayerData input)
        {
            DrawChevronPointOffsetSizeNormal(g, data, input);
        }

        private static void DrawHonoraryChevronInverse(Graphics g, SignumData data, InputLayerData input)
        {
            DrawChevronPointOffsetSizeInvert(g, data, input);
        }

        private static void DrawChevronPointOffsetSizeNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var halfSize = input?.Param1 is null or 0 ? GetHeraldicWidthSling() / 2 : input.Param1.Value / 2;
            var point = input?.Param2 is null or 0 ? data.CenterY : input.Param2.Value;
            var offset = input?.Param3 is null or 0 ? data.Width / 2 : input.Param3.Value;

            var points = new Point[]
            {
                new(data.Left, point + offset - halfSize),
                new(data.CenterX, point - halfSize),
                new(data.Right, point + offset - halfSize),
                new(data.Right, point + offset + halfSize),
                new(data.CenterX, point + halfSize),
                new(data.Left, point + offset + halfSize)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronPointOffsetSizeInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var halfSize = input?.Param1 is null or 0 ? GetHeraldicWidthSling() / 2 : input.Param1.Value / 2;
            var point = input?.Param2 is null or 0 ? data.CenterY : input.Param2.Value;
            var offset = input?.Param3 is null or 0 ? data.Width / 2 : input.Param3.Value;

            var points = new Point[]
            {
                new(data.Left, point - offset - halfSize),
                new(data.CenterX, point - halfSize),
                new(data.Right, point - offset - halfSize),
                new(data.Right, point - offset + halfSize),
                new(data.CenterX, point + halfSize),
                new(data.Left, point - offset + halfSize)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }
    }
}
