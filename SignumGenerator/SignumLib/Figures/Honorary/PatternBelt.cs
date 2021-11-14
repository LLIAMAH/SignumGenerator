using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternBelt : PatternAbstract, IPatternLayer
    {
        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            DrawHonoraryBelt(g, data, input);
        }

        private static void DrawHonoraryBelt(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthNormal(data)
                : input.Param1.Value;

            var rect = new Rectangle(new Point(data.Left, data.CenterY - lineWidth / 2),
                new Size(data.Width, lineWidth));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }
    }
}
