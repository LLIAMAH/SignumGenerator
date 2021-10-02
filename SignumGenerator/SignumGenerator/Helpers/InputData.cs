using SignumGenerator.Signum;

namespace SignumGenerator.Helpers
{
    public class InputData
    {
        private readonly ETincture _tincture;
        private readonly SignumBasePattern _pattern;
        private readonly int _param;

        public ETincture Tincture => this._tincture;
        public SignumBasePattern Pattern => this._pattern;
        public int Param => this._param;

        public bool IsEmpty => _tincture == ETincture.Default || _pattern == SignumBasePattern.Default;
        public bool IsTinctureFur => _tincture == ETincture.Ermine || _tincture == ETincture.Vair;
        public bool IsTinctureMetal => _tincture == ETincture.Or || _tincture == ETincture.Argent;
        public bool IsTinctureColor => !(IsTinctureFur || IsTinctureMetal);

        public InputData(ETincture tincture, SignumBasePattern pattern, int param)
        {
            this._tincture = tincture;
            this._pattern = pattern;
            this._param = param;
        }
    }
}