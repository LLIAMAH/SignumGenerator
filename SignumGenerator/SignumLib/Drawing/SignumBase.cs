using System.Collections.Generic;
using System.Drawing;
using SignumLib.Base;
using SignumLib.Figures;
using SignumLib.Helpers;

// ReSharper disable All
namespace SignumLib.Drawing
{
    public partial class SignumBase : SignumAbstract
    {
        private readonly Graphics _g;
        private readonly SignumData _data;
        private InputBaseData _inputBase;
        private List<InputLayerData> _inputLayers;

        public SignumBase(int width, int height)
        {
            Width = width;
            Height = height;
            _bmp = new Bitmap(Width, Height);
            _data = new SignumData(Width, Height);
            _g = Graphics.FromImage(_bmp);
            _inputLayers = new List<InputLayerData>();
        }

        public void SetBase(InputBaseData inputBase)
        {
            this._inputBase = inputBase;
        }

        public void Add(InputLayerData inputLayer)
        {
            if(inputLayer != null && !inputLayer.IsEmpty)
                this._inputLayers.Add(inputLayer);
        }

        public void Apply()
        {
            IPatternsFactory factory = new PatternsFactory();
            ApplyBase(factory, _inputBase);
            ApplyPatterns(factory, _inputLayers);
        }

        private void ApplyBase(IPatternsFactory factory, InputBaseData input)
        {
            var patternBase = factory.CreatePatternBase();
            patternBase.Draw(_g, _data, input);
        }

        private void ApplyPatterns(IPatternsFactory factory, List<InputLayerData> inputLayers)
        {
            foreach (var layer in inputLayers)
            {                
                var pattern = factory.CreatePattern(layer.Pattern);
                pattern.Draw(_g, _data, layer);
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(this._bmp, 0, 0);
        }
    }
}
