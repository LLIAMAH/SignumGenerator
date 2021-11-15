using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Simple
{
    internal class PatternBar : PatternAbstract, IPatternLayer
    {
        private readonly PatternBarType _type;

        public PatternBar(PatternBarType type)
        {
            this._type = type;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._type)
            {
                case PatternBarType.Bar:
                    {
                        DrawBar(g, data, input);
                        break;
                    }
                case PatternBarType.Billet:
                    {
                        DrawBillet(g, data, input);
                        break;
                    }
            }
        }

        private void DrawBar(Graphics g, SignumData data, InputLayerData input)
        {
            var barWidth = (double)input.Param1.Value * Width / 100;
            var barHeight = barWidth / 2;

            var barWidthHalf = barWidth / 2;
            var barHeightHalf = barHeight / 2;

            var points = new Point[]
            {
                new Point(data.CenterX - (int)barWidthHalf, data.CenterY - (int)barHeightHalf),
                new Point(data.CenterX + (int)barWidthHalf, data.CenterY - (int)barHeightHalf),
                new Point(data.CenterX + (int)barWidthHalf, data.CenterY + (int)barHeightHalf),
                new Point(data.CenterX - (int)barWidthHalf, data.CenterY + (int)barHeightHalf)
            };

            var region = points.ToRegion();
            DrawRegion(g, region, input);
        }

        private void DrawBillet(Graphics g, SignumData data, InputLayerData input)
        {
            var barHeight = (double)input.Param1.Value * Height / 100;
            var barWidth = barHeight / 2;

            var barWidthHalf = barWidth / 2;
            var barHeightHalf = barHeight / 2;

            var points = new Point[]
            {
                new Point(data.CenterX - (int)barWidthHalf, data.CenterY - (int)barHeightHalf),
                new Point(data.CenterX + (int)barWidthHalf, data.CenterY - (int)barHeightHalf),
                new Point(data.CenterX + (int)barWidthHalf, data.CenterY + (int)barHeightHalf),
                new Point(data.CenterX - (int)barWidthHalf, data.CenterY + (int)barHeightHalf)
            };

            var region = points.ToRegion();
            DrawRegion(g, region, input);
        }
    }
}
