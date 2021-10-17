using System.Drawing;
using System.Drawing.Drawing2D;
using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;

// ReSharper disable All

namespace SignumLib.Drawing
{
    public partial class SignumBase : SignumAbstract
    {
        private readonly Graphics _g;
        private readonly SignumData _data;
        private static int _furStep = 100;

        public SignumBase(int width, int height)
        {
            Width = width;
            Height = height;
            _bmp = new Bitmap(Width, Height);
            _data = new SignumData(Width, Height);
            _g = Graphics.FromImage(_bmp);
        }

        public void ApplyBase(InputBaseData input)
        {
            var rect = new Rectangle(0, 0, Width, Height);
            if (input.TinctureMain.IsFur)
            {
                using (var brush = input.TinctureBg.CreateBrush())
                {
                    _g.FillRectangle(brush, rect);
                }

                using (var image = input.TinctureMain.CreateFur(input.TinctureSub))
                {
                    DrawFur(_g, image, _furStep, rect, input.TinctureMain);
                }
            }
            else
            {
                using (var brush = input.TinctureMain.CreateBrush())
                {
                    _g.FillRectangle(brush, rect);
                }
            }
        }

        public void ApplyPattern(InputLayerData input)
        {
            var tincture = input.TinctureMain;
            switch (input.Pattern)
            {
                case SignumBasePattern.StripesHorizontal:
                {
                    var lineWidth = _data.Height / (input.Param1.Value * 2);
                    using (var pen = tincture.CreatePen(lineWidth))
                    {
                        DrawStripesHorizontal(_g, pen, _data, lineWidth, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.StripesVertical:
                {
                    var lineWidth = _data.Width / (input.Param1.Value * 2);
                    using (var pen = tincture.CreatePen(lineWidth))
                    {
                        DrawStripesVertical(_g, pen, _data, lineWidth, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.StripesPal:
                {
                    var lineWidth = _data.Width / (input.Param1.Value * 2 + 1);
                    using (var pen = tincture.CreatePen(lineWidth))
                    {
                        DrawStripesPal(_g, pen, _data, lineWidth, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.StripesBar:
                {
                    var lineWidth = _data.Height / (input.Param1.Value * 2 + 1);
                    using (var pen = tincture.CreatePen(lineWidth))
                    {
                        DrawStripesBar(_g, pen, _data, lineWidth, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.HonoraryHead:
                {
                    DrawHonoraryHead(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryBelt:
                {
                    DrawHonoraryBelt(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryEnd:
                {
                    DrawHonoraryEnd(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryPalNormal:
                {
                    DrawHonoraryPalNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryPalTight:
                {
                    DrawHonoraryPalTight(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryFlancLeft:
                {
                    DrawHonoraryFlankLeft(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryFlancRight:
                {
                    DrawHonoraryFlankRight(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonorarySlingLeft:
                {
                    DrawHonorarySlingLeft(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonorarySlingRight:
                {
                    DrawHonorarySlingRight(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryChevron:
                {
                    DrawHonoraryChevron(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryChevronInverse:
                {
                    DrawHonoraryChevronInverse(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryCroix:
                {
                    DrawHonoraryCroix(_g, _data, input);
                    break;
                }
                case SignumBasePattern.HonoraryCroixDiagonal:
                {
                    DrawHonoraryCroixDiagonal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.Quarters_1_4:
                {
                    DrawQuarters14(_g, _data, input);
                    break;
                }
                case SignumBasePattern.Quarters_2_3:
                {
                    DrawQuarters23(_g, _data, input);
                    break;
                }
                case SignumBasePattern.QuartersDiagonalTopBottom:
                {
                    DrawQuartersDiagonalTopBottom(_g, _data, input);
                    break;
                }
                case SignumBasePattern.QuartersDiagonalLeftRight:
                {
                    DrawQuartersDiagonalLeftRight(_g, _data, input);
                    break;
                }
                case SignumBasePattern.CheckersNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawCheckersNormal(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.CheckersInverse:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawCheckersInverse(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.CheckersDiagonal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawCheckersDiagonal(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.Quarter:
                {
                    DrawQuarter(_g, _data, input);
                    break;
                }
                case SignumBasePattern.ChevronMiddleNormal:
                {
                    DrawChevronMiddleNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.ChevronMiddleInvert:
                {
                    DrawChevronMiddleInvert(_g, _data, input);
                    break;
                }
                using (var image = input.TinctureMain.CreateFur(input.TinctureSub))
                {
                    DrawChevronFullNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.ChevronFullInvert:
                {
                    DrawChevronFullInvert(_g, _data, input);
                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                {
                    DrawChevronPointOffsetSizeNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                {
                    DrawChevronPointOffsetSizeInvert(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SplitHorizontalNormal:
                {
                    DrawSplitHorizontalNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SplitHorizontalInvert:
                {
                    DrawSplitHorizontalInvert(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SplitVerticalLeft:
                {
                    DrawSplitVerticalLeft(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SplitVerticalRight:
                {
                    DrawSplitVerticalRight(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SliceLeftNormal:
                {
                    DrawSliceLeftNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SliceLeftInvert:
                {
                    DrawSliceLeftInvert(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SliceRightNormal:
                {
                    DrawSliceRightNormal(_g, _data, input);
                    break;
                }
                case SignumBasePattern.SliceRightInvert:
                {
                    DrawSliceRightInvert(_g, _data, input);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(this._bmp, 0, 0);
        }
    }
}
