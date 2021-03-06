using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternSplit : PatternAbstract, IPatternLayer
    {
        private PatternView _view;
        private PatternDirection _direction;

        public PatternSplit(PatternView view, PatternDirection direction)
        {
            this._view = view;
            this._direction = direction;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._view)
            {
                case PatternView.Horizontal:
                    {
                        switch (this._direction)
                        {
                            case PatternDirection.Normal:
                                {
                                    DrawSplitHorizontalNormal(g, data, input);
                                    break;
                                }
                            case PatternDirection.Inverse:
                                {
                                    DrawSplitHorizontalInvert(g, data, input);
                                    break;
                                }
                        }
                        break;
                    }
                case PatternView.Vertical:
                    {
                        switch (this._direction)
                        {
                            case PatternDirection.Normal:
                                {
                                    DrawSplitVerticalLeft(g, data, input);
                                    break;
                                }
                            case PatternDirection.Inverse:
                                {
                                    DrawSplitVerticalRight(g, data, input);
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private static void DrawSplitVerticalRight(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Width / 2, data.Top, data.Width / 2, data.Height);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawSplitVerticalLeft(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Top, data.Width / 2, data.Height);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawSplitHorizontalNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Top, data.Width, data.Height / 2);
            DrawRegion(g, rect.ToRegion(), input);
        }

        private static void DrawSplitHorizontalInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Height / 2, data.Width, data.Height / 2);
            DrawRegion(g, rect.ToRegion(), input);
        }
    }
}
