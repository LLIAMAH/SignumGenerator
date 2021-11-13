using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternLines : IPattern
    {
        private PatternLinesType _linesType;
        private PatternView _view;

        public PatternLines(PatternLinesType linesType, PatternView view)
        {
            this._linesType = linesType;
            this._view = view;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }
    }
}
