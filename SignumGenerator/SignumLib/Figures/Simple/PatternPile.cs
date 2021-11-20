using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Simple
{
    internal class PatternPile : PatternAbstract, IPatternLayer
    {
        private PatternPileType _type;

        public PatternPile(PatternPileType type)
        {
            this._type = type;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._type)
            {
                case PatternPileType.Pile:
                    {
                        DrawPile(g, data, input);
                        break;
                    }
                case PatternPileType.Pyramid:
                    {
                        DrawPyramid(g, data, input);
                        break;
                    }
                case PatternPileType.Giron:
                    {
                        DrawGiron(g, data, input);
                        break;
                    }
            }
        }

        private static void DrawPile(Graphics g, SignumData data, InputLayerData input)
        {
            var baseWidthPercents = input.Param1.Value;
            var basePositionPercents = input.Param2.Value;

            if (basePositionPercents == 0)
                basePositionPercents = 100;

            var baseWidth = ((double)baseWidthPercents * Width / 100) / 2;
            var pileHeight = (double)basePositionPercents * Height / 100;

            var left = (int)(data.CenterX - baseWidth);
            var right = (int)(data.CenterX + baseWidth);

            var points = new Point[]
            {
                new (left, data.Top),
                new (right, data.Top),
                new (data.CenterX, (int)pileHeight)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawPyramid(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Bottom),
                new(data.CenterX, data.Top),
                new(data.Right, data.Bottom)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawGiron(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new (data.Left, data.Top),
                new (data.CenterX, data.CenterY),
                new (data.Left, data.CenterY)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }
    }
}
