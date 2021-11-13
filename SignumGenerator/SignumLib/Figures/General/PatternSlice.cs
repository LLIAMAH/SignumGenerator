using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternSlice : IPattern
    {
        private PatternDirection _direction;
        private PaternSide _side;

        public PatternSlice(PatternDirection direction, PaternSide side)
        {
            this._direction = direction;
            this._side = side;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
