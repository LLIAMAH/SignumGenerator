using SignumLib.Tincture;

namespace SignumLib.Figures
{
    // Abstract factory
    public interface IPatternsFactory
    {
        IPatternBase CreatePatternBase();
        IPatternLayer CreatePattern(SignumBasePattern patternValue);
    }
}
