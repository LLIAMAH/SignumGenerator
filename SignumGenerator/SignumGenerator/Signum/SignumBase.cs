﻿using System.Drawing;
using System.Drawing.Drawing2D;
using SignumGenerator.Helpers;

// ReSharper disable All

namespace SignumGenerator.Signum
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
                    var lineWidth = _data.Height/ (input.Param1.Value * 2 + 1);
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

                case SignumBasePattern.SlingRight:
                {
                    using (var pen = tincture.CreatePen(input.Param1.Value == 0 ? 1 : input.Param1.Value))
                    {
                        DrawSlingRight(_g, pen, _data);
                    }

                    break;
                }
                case SignumBasePattern.SlingLeft:
                {
                    using (var pen = tincture.CreatePen(input.Param1.Value == 0 ? 1 : input.Param1.Value))
                    {
                        DrawSlingLeft(_g, pen, _data);
                    }

                    break;
                }
                case SignumBasePattern.Quarters_1_4:
                {
                    if (tincture.IsEnamel || tincture.IsMetal)
                    {
                        using (var brush = tincture.CreateBrush())
                        {
                            DrawQuarters14Tincture(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var brush = input.TinctureBg.CreateBrush())
                        {
                            DrawQuarters14Tincture(_g, brush, _data);
                        }

                        using (var image = tincture.CreateFur(input.TinctureSub))
                        {
                            DrawQuarters14Fur(_g, image, _data, tincture);
                        }
                    }

                    break;
                }
                case SignumBasePattern.Quarters_2_3:
                {
                    if (tincture.IsEnamel || tincture.IsMetal)
                    {
                        using (var brush = tincture.CreateBrush())
                        {
                            DrawQuarters23Tincture(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var brush = input.TinctureBg.CreateBrush())
                        {
                            DrawQuarters23Tincture(_g, brush, _data);
                        }

                        using (var image = tincture.CreateFur(input.TinctureSub))
                        {
                            DrawQuarters23Fur(_g, image, _data, input.TinctureMain);
                        }
                    }

                    break;
                }
                case SignumBasePattern.QuartersDiagonalTopBottom:
                {
                    if (tincture.IsEnamel || tincture.IsMetal)
                    {
                        using (var brush = tincture.CreateBrush())
                        {
                            DrawQuartersDiagonalTopBottom(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var image = tincture.CreateFur(input.TinctureSub))
                        {
                            var rect = new Rectangle(0, 0, Width, Height);
                            DrawFur(_g, image, _furStep, rect, input.TinctureMain);
                        }

                        using (var brush = tincture.CreateBrush())
                        {
                            DrawQuartersDiagonalLeftRight(_g, brush, _data);
                        }
                    }

                    break;
                }
                case SignumBasePattern.QuartersDiagonalLeftRight:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawQuartersDiagonalLeftRight(_g, brush, _data);
                    }

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
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawQuarter(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.ChevronMiddleNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawChevronMiddleNormal(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.ChevronMiddleInvert:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawChevronMiddleInvert(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.ChevronFullNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawChevronFullNormal(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.ChevronFullInvert:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawChevronFullInvert(_g, brush, _data, input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawChevronPointOffsetSizeNormal(_g, brush, _data, input.Param2.Value, input.Param3.Value,
                            input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawChevronPointOffsetSizeInvert(_g, brush, _data, input.Param2.Value, input.Param3.Value,
                            input.Param1.Value);
                    }

                    break;
                }
                case SignumBasePattern.SplitHorizontalNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSplitHorizontalNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitHorizontalInvert:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSplitHorizontalInvert(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitVerticalLeft:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSplitVerticalLeft(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitVerticalRight:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSplitVerticalRight(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceLeftNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSliceLeftNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceLeftInvert:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSliceLeftInvert(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceRightNormal:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSliceRightNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceRightInvert:
                {
                    using (var brush = tincture.CreateBrush())
                    {
                        DrawSliceRightInvert(_g, brush, _data);
                    }

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
