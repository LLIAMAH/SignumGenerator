using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternBase : PatternAbstract, IPatternBase
    {
        public void Draw(Graphics g, SignumData data, InputBaseData input)
        {
            var rect = new Rectangle(new(data.Top, data.Left), new(data.Width, data.Height));
            var region = rect.ToRegion();
            DrawRegion(g, region, input);
        }
    }
}
