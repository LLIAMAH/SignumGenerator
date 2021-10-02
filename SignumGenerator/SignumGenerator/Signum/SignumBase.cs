using System.Drawing;
using System.Drawing.Drawing2D;
using SignumGenerator.Helpers;
using Color = System.Drawing.Color;

// ReSharper disable All

namespace SignumGenerator.Signum
{
    public partial class SignumBase : SignumAbstract
    {
        private readonly Graphics _g;
        private readonly SignumData _data;

        public SignumBase()
        {
            _bmp = new Bitmap(Width, Height);
            _data = new SignumData(Width, Height);
            _g = Graphics.FromImage(_bmp);
        }

        public void ApplyBase(Color color)
        {
            var brushSecondary = SignumBrush.CreateBrush(color);
            _g.FillRectangle(brushSecondary, 0, 0, Width, Height);
        }

        public void ApplyPattern(InputData input)
        {
            switch (input.Pattern)
            {
                case SignumBasePattern.StripesHorizontal:
                {
                    var lineWidth = _data.Height / (input.Param * 2);
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), lineWidth))
                    {
                        DrawStripesHorizontal(_g, pen, _data, lineWidth, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.StripesVertical:
                {
                    var lineWidth = _data.Width / (input.Param * 2);
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), lineWidth))
                    {
                        DrawStripesVertical(_g, pen, _data, lineWidth, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.SlingRight:
                {
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), input.Param == 0 ? 1 : input.Param))
                    {
                        DrawSlingRight(_g, pen, _data);
                    }

                    break;
                }
                case SignumBasePattern.SlingLeft:
                {
                    using (var pen = SignumPen.CreatePen(SignumColor.GetColor(input.Tincture), input.Param == 0 ? 1 : input.Param))
                    {
                        DrawSlingLeft(_g, pen, _data);
                    }

                    break;
                }
                case SignumBasePattern.Quarters_1_4:
                {
                    if (input.IsTinctureColor || input.IsTinctureMetal)
                    {
                        using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                        {
                            DrawQuarters14(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var image = SignumColor.GetColorFur(input.Tincture))
                        {
                            DrawQuarters14(_g, image, _data);
                        }
                    }

                    break;
                }
                case SignumBasePattern.Quarters_2_3:
                {
                    if (input.IsTinctureColor || input.IsTinctureMetal)
                    {
                        using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                        {
                            DrawQuarters23(_g, brush, _data);
                        }
                    }
                    else
                    {
                        using (var image = SignumColor.GetColorFur(input.Tincture))
                        {
                            DrawQuarters23(_g, image, _data);
                        }
                    }

                    break;
                }
                case SignumBasePattern.QuartersDiagonalTopBottom:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawQuartersDiagonalTopBottom(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.QuartersDiagonalLeftRight:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawQuartersDiagonalLeftRight(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.CheckersNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawCheckersNormal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.CheckersInverse:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawCheckersInverse(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.CheckersDiagonal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawCheckersDiagonal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.Quarter:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawQuarter(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.ChevronMiddleNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronMiddleNormal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronMiddleInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronMiddleInvert(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronFullNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronFullNormal(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronFullInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronFullInvert(_g, brush, _data, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                {
                    var point = 100;
                    var offset = 200;
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronPointOffsetSizeNormal(_g, brush, _data, point, offset, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                {
                    var point = 400;
                    var offset = 200;
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawChevronPointOffsetSizeInvert(_g, brush, _data, point, offset, input.Param);
                    }

                    break;
                }
                case SignumBasePattern.SplitHorizontalNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitHorizontalNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitHorizontalInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitHorizontalInvert(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitVerticalLeft:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitVerticalLeft(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SplitVerticalRight:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSplitVerticalRight(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceLeftNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceLeftNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceLeftInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceLeftInvert(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceRightNormal:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceRightNormal(_g, brush, _data);
                    }

                    break;
                }
                case SignumBasePattern.SliceRightInvert:
                {
                    using (var brush = SignumBrush.CreateBrush(SignumColor.GetColor(input.Tincture)))
                    {
                        DrawSliceRightInvert(_g, brush, _data);
                    }

                    break;
                }
                default: {break;}
            }
        }

        public override void Draw(Graphics g)
        {
            //this.ApplyShield(g);
            g.DrawImage(this._bmp, 0, 0);
        }

        private void ApplyShield(Graphics g)
        {
            var paramOffset = 200;
            var path = new GraphicsPath();
            path.AddLine(new Point(_data.Left, _data.Bottom - paramOffset), new Point(_data.Left, _data.Top));
            path.AddLine(new Point(_data.Left, _data.Top), new Point(_data.Right, _data.Top));
            path.AddLine(new Point(_data.Right, _data.Top), new Point(_data.Right, _data.Bottom - paramOffset));
            path.AddLine(new Point(_data.Right, _data.Bottom - paramOffset), new Point(_data.CenterX, _data.Bottom));
            path.AddLine(new Point(_data.CenterX, _data.Bottom), new Point(_data.Left, _data.Bottom - paramOffset));
            //path.AddArc(new Rectangle(_data.Right, _data.Bottom - paramOffset, _data.Width / 2, paramOffset),  270, 180);
            //path.AddArc(new Rectangle(_data.Left, _data.Bottom - paramOffset, _data.Width / 2, paramOffset), 270, 180);

            var region = new Region(path);

            g.DrawImage(this._bmp, new Point(0, 0));
            g.SetClip(region, CombineMode.Replace);
        }
    }
}
