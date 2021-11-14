using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternEnd : PatternAbstract, IPattern
    {
        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            DrawHonoraryEnd(g, data, input);
        }

        private static void DrawHonoraryEnd(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthNormal(data)
                : input.Param1.Value;

            var rect = new Rectangle(new Point(data.Left, data.Bottom - lineWidth), new Size(data.Width, lineWidth));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }
    }
}
