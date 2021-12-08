using SignumLib.Tincture;

namespace SignumLib.Helpers
{
    public class InputBaseData
    {
        private readonly SignumTincture _tinctureMain;
        private readonly SignumTincture _tinctureSub;
        private readonly SignumTincture _tinctureBg;
        private readonly int _stepBG;

        public SignumTincture TinctureMain => this._tinctureMain;
        public SignumTincture TinctureSub => this._tinctureSub;
        public SignumTincture TinctureBg => this._tinctureBg;

        public int StepBG => this._stepBG;
        public bool IsEmpty => _tinctureMain.Tincture == ETincture.Default;

        public InputBaseData(SignumTincture tinctureMain, int stepBg, SignumTincture tinctureSub, SignumTincture tinctureBg)
        {
            this._tinctureMain = tinctureMain;
            this._stepBG = stepBg;
            this._tinctureSub = tinctureSub;
            this._tinctureBg = tinctureBg;
        }
    }

    public class InputLayerData
    {
        private readonly SignumBasePattern _pattern;
        private readonly SignumTincture _tinctureMain;
        private readonly SignumTincture _tinctureSub;
        private readonly SignumTincture _tinctureBg;
        private readonly int _stepBG;
        private readonly int? _param1;
        private readonly int? _param2;
        private readonly int? _param3;

        public SignumBasePattern Pattern => this._pattern;
        public SignumTincture TinctureMain => this._tinctureMain;
        public SignumTincture TinctureSub => this._tinctureSub;
        public SignumTincture TinctureBg => this._tinctureBg;

        public int StepBG => this._stepBG;
        public int? Param1 => this._param1;
        public int? Param2 => this._param2;
        public int? Param3 => this._param3;
        public bool IsEmpty => _pattern == SignumBasePattern.Default;

        public InputLayerData(SignumBasePattern pattern,
            SignumTincture tinctureMain, int stepBg,
            SignumTincture tinctureSub = null, SignumTincture tinctureBg = null,
            int? param1 = null, int? param2 = null, int? param3 = null)
        {
            this._pattern = pattern;
            this._tinctureMain = tinctureMain;
            this._stepBG = stepBg;
            this._tinctureSub = tinctureSub;
            this._tinctureBg = tinctureBg;
            this._param1 = param1;
            this._param2 = param2;
            this._param3 = param3;
        }
    }
}