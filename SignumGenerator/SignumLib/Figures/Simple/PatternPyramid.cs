using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;

namespace SignumLib.Figures.Simple
{
    internal class PatternPyramid : PatternAbstract, IPatternLayer
    {
        public void Draw(Graphics g, SignumData data, InputLayerData input)
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
    }
}
