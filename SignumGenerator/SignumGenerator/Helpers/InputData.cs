using SignumGenerator.Signum;

namespace SignumGenerator.Helpers
{
    public class InputData
    {
        private readonly SignumColor _color;
        private readonly SignumBasePattern _pattern;
        private readonly int _param;

        public ETincture Tincture => this._color.Tincture;
        public SignumColor Color => this._color;
        public SignumBasePattern Pattern => this._pattern;
        public int Param => this._param;

        public bool IsEmpty => _color.Tincture == ETincture.Default || _pattern == SignumBasePattern.Default;

        public InputData(ETincture tincture, SignumBasePattern pattern, int param)
        {
            this._color = new SignumColor(tincture);
            this._pattern = pattern;
            this._param = param;
        }
    }
}