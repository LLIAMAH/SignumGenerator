using SignumGenerator.Signum;

namespace SignumGenerator.Helpers
{
    public class InputData
    {
        private readonly SignumTincture _tincture;
        private readonly SignumBasePattern _pattern;
        private readonly int _param;

        public SignumTincture Tincture => this._tincture;
        public SignumBasePattern Pattern => this._pattern;
        public int Param => this._param;

        public bool IsEmpty => _tincture.Tincture == ETincture.Default || _pattern == SignumBasePattern.Default;

        public InputData(ETincture tincture, SignumBasePattern pattern, int param)
        {
            this._tincture = new SignumTincture(tincture);
            this._pattern = pattern;
            this._param = param;
        }
    }
}