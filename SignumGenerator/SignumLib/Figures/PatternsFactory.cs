using SignumLib.Figures.General;
using SignumLib.Figures.Honorary;
using SignumLib.Figures.Simple;
using SignumLib.Tincture;

namespace SignumLib.Figures
{
    public class PatternsFactory : IPatternsFactory
    {
        public IPatternBase CreatePatternBase()
        {
            return new PatternBase();
        }

        public IPatternLayer CreatePattern(SignumBasePattern patternValue)
        {
            switch (patternValue)
            {
                case SignumBasePattern.StripesHorizontal: return new PatternLines(PatternLinesType.Stripes, PatternView.Horizontal);
                case SignumBasePattern.StripesVertical: return new PatternLines(PatternLinesType.Stripes, PatternView.Vertical);
                case SignumBasePattern.StripesPal: return new PatternLines(PatternLinesType.Pals, PatternView.Vertical);
                case SignumBasePattern.StripesBar: return new PatternLines(PatternLinesType.Pals, PatternView.Horizontal);
                case SignumBasePattern.HonoraryHead: return new PatternHead();
                case SignumBasePattern.HonoraryBelt: return new PatternBelt();
                case SignumBasePattern.HonoraryEnd: return new PatternEnd();
                case SignumBasePattern.HonoraryPalNormal: return new PatternPal(PatternSize.Normal);
                case SignumBasePattern.HonoraryPalTight: return new PatternPal(PatternSize.Specific);
                case SignumBasePattern.HonoraryFlancLeft: return new PatternFlanc(PatternSide.Left);
                case SignumBasePattern.HonoraryFlancRight: return new PatternFlanc(PatternSide.Right);
                case SignumBasePattern.HonorarySlingLeft: return new PatternSling(PatternSide.Left);
                case SignumBasePattern.HonorarySlingRight: return new PatternSling(PatternSide.Right);
                case SignumBasePattern.HonoraryChevron: return new PatternChevron(PatternDirection.Normal, PatternChevronType.Normal);
                case SignumBasePattern.HonoraryChevronInverse: return new PatternChevron(PatternDirection.Inverse, PatternChevronType.Normal);
                case SignumBasePattern.HonoraryCroix: return new PatternCroix(PatternPosition.Common);
                case SignumBasePattern.HonoraryCroixDiagonal: return new PatternCroix(PatternPosition.Diagonal);
                case SignumBasePattern.Quarter: return new PatternQuarters(PatternPosition.Common, Quarter.One);
                case SignumBasePattern.Quarters_1_4: return new PatternQuarters(PatternPosition.Common, Quarter.OneAndFour);
                case SignumBasePattern.Quarters_2_3: return new PatternQuarters(PatternPosition.Common, Quarter.TwoANdThree);
                case SignumBasePattern.QuartersDiagonalTopBottom: return new PatternQuarters(PatternPosition.Diagonal, Quarter.OneAndFour);
                case SignumBasePattern.QuartersDiagonalLeftRight: return new PatternQuarters(PatternPosition.Diagonal, Quarter.TwoANdThree);
                case SignumBasePattern.CheckersNormal: return new PatternCheckers(PatternPosition.Common, PatternDirection.Normal);
                case SignumBasePattern.CheckersInverse: return new PatternCheckers(PatternPosition.Common, PatternDirection.Inverse);
                case SignumBasePattern.CheckersDiagonal: return new PatternCheckers(PatternPosition.Diagonal, PatternDirection.Normal);
                case SignumBasePattern.ChevronMiddleNormal: return new PatternChevron(PatternDirection.Normal, PatternChevronType.Normal);
                case SignumBasePattern.ChevronMiddleInvert: return new PatternChevron(PatternDirection.Inverse, PatternChevronType.Normal);
                case SignumBasePattern.ChevronFullNormal: return new PatternChevron(PatternDirection.Normal, PatternChevronType.Full);
                case SignumBasePattern.ChevronFullInvert: return new PatternChevron(PatternDirection.Inverse, PatternChevronType.Full);
                case SignumBasePattern.ChevronPointOffsetSizeNormal: return new PatternChevron(PatternDirection.Normal, PatternChevronType.Custom);
                case SignumBasePattern.ChevronPointOffsetSizeInvert: return new PatternChevron(PatternDirection.Inverse, PatternChevronType.Custom);
                case SignumBasePattern.SplitHorizontalNormal: return new PatternSplit(PatternView.Horizontal, PatternDirection.Normal);
                case SignumBasePattern.SplitHorizontalInvert: return new PatternSplit(PatternView.Horizontal, PatternDirection.Inverse);
                case SignumBasePattern.SplitVerticalLeft: return new PatternSplit(PatternView.Vertical, PatternDirection.Normal);
                case SignumBasePattern.SplitVerticalRight: return new PatternSplit(PatternView.Vertical, PatternDirection.Inverse);
                case SignumBasePattern.SliceLeftNormal: return new PatternSlice(PatternSide.TopAndLeft);
                case SignumBasePattern.SliceLeftInvert: return new PatternSlice(PatternSide.BottomAndRight);
                case SignumBasePattern.SliceRightNormal: return new PatternSlice(PatternSide.TopAndRight);
                case SignumBasePattern.SliceRightInvert: return new PatternSlice(PatternSide.BottomAndLeft);
                case SignumBasePattern.SimplePyramid: return new PatternPile(PatternPileType.Pyramid);
                case SignumBasePattern.SimplePile: return new PatternPile(PatternPileType.Pile);
                case SignumBasePattern.SimpleGiron: return new PatternPile(PatternPileType.Giron);
                case SignumBasePattern.SimpleBar: return new PatternBar(PatternBarType.Bar);
                case SignumBasePattern.SimpleBillet: return new PatternBar(PatternBarType.Billet);
                case SignumBasePattern.SimpleBesant: return new PatternBesant();
                default: { return new PatternDefault(); }
            }
        }
    }
}
