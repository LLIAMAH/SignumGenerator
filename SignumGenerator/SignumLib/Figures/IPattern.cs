using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;

namespace SignumLib.Figures
{
    public interface IPatternBase
    {
        void Draw(Graphics g, SignumData data, InputBaseData input);
    }

    public interface IPatternLayer
    {
        void Draw(Graphics g, SignumData data, InputLayerData input);
    }
}
