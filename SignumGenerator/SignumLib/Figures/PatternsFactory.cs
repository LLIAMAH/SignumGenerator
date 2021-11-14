using SignumLib.Figures.General;
using SignumLib.Figures.Honorary;
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
                case SignumBasePattern.StripesHorizontal:
                    {
                        return new PatternLines(PatternLinesType.Stripes, PatternView.Horizontal);
                        //var lineWidth = _data.Height / (input.Param1.Value * 2);
                        //using (var pen = tincture.CreatePen(lineWidth))
                        //{
                        //    DrawStripesHorizontal(_g, pen, _data, lineWidth, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.StripesVertical:
                    {
                        return new PatternLines(PatternLinesType.Stripes, PatternView.Vertical);
                        //var lineWidth = _data.Width / (input.Param1.Value * 2);
                        //using (var pen = tincture.CreatePen(lineWidth))
                        //{
                        //    DrawStripesVertical(_g, pen, _data, lineWidth, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.StripesPal:
                    {
                        return new PatternLines(PatternLinesType.Pals, PatternView.Vertical);
                        //var lineWidth = _data.Width / (input.Param1.Value * 2 + 1);
                        //using (var pen = tincture.CreatePen(lineWidth))
                        //{
                        //    DrawStripesPal(_g, pen, _data, lineWidth, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.StripesBar:
                    {
                        return new PatternLines(PatternLinesType.Pals, PatternView.Horizontal);
                        //var lineWidth = _data.Height / (input.Param1.Value * 2 + 1);
                        //using (var pen = tincture.CreatePen(lineWidth))
                        //{
                        //    DrawStripesBar(_g, pen, _data, lineWidth, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.HonoraryHead:
                    {
                        return new PatternHead();
                        //DrawHonoraryHead(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryBelt:
                    {
                        return new PatternBelt();
                        //DrawHonoraryBelt(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryEnd:
                    {
                        return new PatternEnd();
                        //DrawHonoraryEnd(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryPalNormal:
                    {
                        return new PatternPal(PatternSize.Normal);
                        //DrawHonoraryPalNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryPalTight:
                    {
                        return new PatternPal(PatternSize.Specific);
                        //DrawHonoraryPalTight(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryFlancLeft:
                    {
                        return new PatternFlanc(PatternSide.Left);
                        //DrawHonoraryFlankLeft(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryFlancRight:
                    {
                        return new PatternFlanc(PatternSide.Right);
                        //DrawHonoraryFlankRight(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonorarySlingLeft:
                    {
                        return new PatternSling(PatternSide.Left);
                        //DrawHonorarySlingLeft(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonorarySlingRight:
                    {
                        return new PatternSling(PatternSide.Right);
                        // DrawHonorarySlingRight(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryChevron:
                    {
                        return new PatternChevron(PatternDirection.Normal);
                        //DrawHonoraryChevron(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryChevronInverse:
                    {
                        return new PatternChevron(PatternDirection.Inverse);
                        //DrawHonoraryChevronInverse(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryCroix:
                    {
                        return new PatternCroix(PatternPosition.Common);
                        //DrawHonoraryCroix(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.HonoraryCroixDiagonal:
                    {
                        return new PatternCroix(PatternPosition.Diagonal);
                        //DrawHonoraryCroixDiagonal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.Quarters_1_4:
                    {
                        return new PatternQuarters(PatternPosition.Common, Quarter.OneAndFour);
                        //DrawQuarters14(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.Quarters_2_3:
                    {
                        return new PatternQuarters(PatternPosition.Common, Quarter.TwoANdThree);
                        //DrawQuarters23(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.QuartersDiagonalTopBottom:
                    {
                        return new PatternQuarters(PatternPosition.Common, Quarter.OneAndFour);
                        //DrawQuartersDiagonalTopBottom(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.QuartersDiagonalLeftRight:
                    {
                        return new PatternQuarters(PatternPosition.Common, Quarter.TwoANdThree);
                        //DrawQuartersDiagonalLeftRight(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.CheckersNormal:
                    {
                        return new PatternCheckers(PatternPosition.Common, PatternDirection.Normal);
                        //using (var brush = tincture.CreateBrush())
                        //{
                        //    DrawCheckersNormal(_g, brush, _data, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.CheckersInverse:
                    {
                        return new PatternCheckers(PatternPosition.Common, PatternDirection.Inverse);
                        //using (var brush = tincture.CreateBrush())
                        //{
                        //    DrawCheckersInverse(_g, brush, _data, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.CheckersDiagonal:
                    {
                        return new PatternCheckers(PatternPosition.Diagonal, PatternDirection.Normal);
                        //using (var brush = tincture.CreateBrush())
                        //{
                        //    DrawCheckersDiagonal(_g, brush, _data, input.Param1.Value);
                        //}

                        //break;
                    }
                case SignumBasePattern.Quarter:
                    {
                        return new PatternQuarters(PatternPosition.Common, Quarter.One);
                        //DrawQuarter(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.ChevronMiddleNormal:
                    {
                        return new PatternChevron(PatternDirection.Normal);
                        //DrawChevronMiddleNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.ChevronMiddleInvert:
                    {
                        return new PatternChevron(PatternDirection.Inverse);
                        //DrawChevronMiddleInvert(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.ChevronFullNormal:
                    {
                        return new PatternChevron(PatternDirection.Normal);
                        //DrawChevronFullNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.ChevronFullInvert:
                    {
                        return new PatternChevron(PatternDirection.Inverse);
                        //DrawChevronFullInvert(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                    {
                        return new PatternChevron(PatternDirection.Normal);
                        //DrawChevronPointOffsetSizeNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                    {
                        return new PatternChevron(PatternDirection.Inverse);
                        //DrawChevronPointOffsetSizeInvert(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SplitHorizontalNormal:
                    {
                        return new PatternSplit(PatternView.Horizontal, PatternDirection.Normal);
                        //DrawSplitHorizontalNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SplitHorizontalInvert:
                    {
                        return new PatternSplit(PatternView.Horizontal, PatternDirection.Inverse);
                        //DrawSplitHorizontalInvert(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SplitVerticalLeft:
                    {
                        return new PatternSplit(PatternView.Vertical, PatternDirection.Normal);
                        //DrawSplitVerticalLeft(_g, _data, input);1
                        //br1eak;
                    }
                case SignumBasePattern.SplitVerticalRight:
                    {
                        return new PatternSplit(PatternView.Vertical, PatternDirection.Inverse);
                        //DrawSplitVerticalRight(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SliceLeftNormal:
                    {
                        return new PatternSlice(PatternSide.TopAndLeft);
                        //DrawSliceLeftNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SliceLeftInvert:
                    {
                        return new PatternSlice(PatternSide.BottomAndRight);
                        //DrawSliceLeftInvert(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SliceRightNormal:
                    {
                        return new PatternSlice(PatternSide.TopAndRight);
                        //DrawSliceRightNormal(_g, _data, input);
                        //break;
                    }
                case SignumBasePattern.SliceRightInvert:
                    {
                        return new PatternSlice(PatternSide.BottomAndLeft);
                        //DrawSliceRightInvert(_g, _data, input);
                        //break;
                    }
                default: { return new PatternDefault(); }
            }
        }
    }
}
