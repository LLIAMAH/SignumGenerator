using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternCheckers : IPattern
    {
        private PatternPosition _position;
        private PatternDirection _direction;

        public PatternCheckers(PatternPosition position, PatternDirection direction)
        {
            this._position = position;
            this._direction = direction;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
