using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternSplit : PatternAbstract, IPattern
    {
        private PatternView _view;
        private PatternDirection _direction;

        public PatternSplit(PatternView view, PatternDirection direction)
        {
            this._view = view;
            this._direction = direction;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
