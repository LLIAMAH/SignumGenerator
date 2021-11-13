using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternCroix : IPattern
    {
        private PatternPosition _position;

        public PatternCroix(PatternPosition common)
        {
            this._position = common;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
