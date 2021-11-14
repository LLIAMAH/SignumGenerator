using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternQuarters : PatternAbstract, IPattern
    {
        private PatternPosition _position;
        private Quarter _quarters;

        public PatternQuarters(PatternPosition position, Quarter quarters)
        {
            this._position = position;
            this._quarters = quarters;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
