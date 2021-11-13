using SignumLib.Base;
using SignumLib.Helpers;
using System.Drawing;

namespace SignumLib.Figures
{
    public interface IPattern
    {
        void Draw(Graphics g, SignumData data, InputLayerData input);
    }
}
