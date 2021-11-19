using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SignumLib.Figures.Simple
{
    internal class PatternBesant : PatternAbstract, IPatternLayer
    {
        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            var percentWidth = input.Param1.Value;
            var width = (double)percentWidth * Width / 100;
            var widthHalf = (int) width / 2;

            var gp = new GraphicsPath { FillMode = FillMode.Winding };
            gp.AddEllipse(new Rectangle(
                new Point(data.CenterX - widthHalf, data.CenterY - widthHalf),
                new Size(widthHalf * 2, widthHalf * 2)));
            
            var region = new Region(gp);
            DrawRegion(g, region, input);
        }
    }
}
