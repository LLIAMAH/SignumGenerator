using SignumLib.Tincture;

namespace SignumLib.Figures
{
    // Abstract factory
    public interface IPatternsFactory
    {
        public IPattern CreatePattern(SignumBasePattern patternValue);
    }
}
