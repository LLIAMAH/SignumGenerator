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
            var baseWidthPerc = input.Param1.Value;
            var baseWidth = ((double)baseWidthPerc * Width / 100) / 2;

            var left = (int)(data.CenterX - baseWidth);
            var right = (int)(data.CenterX + baseWidth);

            var points = new Point[]
            {
                new (left, data.Top),
                new (right, data.Top),
                new (data.CenterX, data.Bottom)
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
