using SignumGenerator.Signum;

namespace SignumGenerator.Helpers
{
    public class InputData
    {
        private readonly EColor _color;
        private readonly SignumBasePattern _pattern;
        private readonly int _param;

        public EColor Color => this._color;
        public SignumBasePattern Pattern => this._pattern;
        public int Param => this._param;

        public bool IsEmpty => _color == EColor.Default || _pattern == SignumBasePattern.Default;

        public InputData(EColor color, SignumBasePattern pattern, int param)
        {
            this._color = color;
            this._pattern = pattern;
            this._param = param;
        }
    }
}