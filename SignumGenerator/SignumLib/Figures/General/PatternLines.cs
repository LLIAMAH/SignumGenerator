using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternLines : PatternAbstract, IPatternLayer
    {
        private PatternLinesType _linesType;
        private PatternView _view;

        public PatternLines(PatternLinesType linesType, PatternView view)
        {
            this._linesType = linesType;
            this._view = view;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (_linesType)
            {
                case PatternLinesType.Stripes:
                    {
                        switch (_view)
                        {
                            case PatternView.Horizontal:
                                {
                                    DrawHorizontal(g, data, input);
                                    break;
                                }

                            case PatternView.Vertical:
                                {
                                    DrawVertical(g, data, input);
                                    break;
                                }
                        }
                        break;
                    }
                case PatternLinesType.Pals:
                    {
                        switch (_view)
                        {
                            case PatternView.Horizontal:
                                {
                                    DrawBars(g, data, input);
                                    break;
                                }

                            case PatternView.Vertical:
                                {
                                    DrawPals(g, data, input);
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private void DrawHorizontal(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = data.Height / (input.Param1.Value * 2);
            using (var pen = input.TinctureMain.CreatePen(lineWidth))
            {
                DrawStripesHorizontal(g, pen, data, lineWidth, input.Param1.Value);
            }
        }

        private void DrawVertical(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = data.Width / (input.Param1.Value * 2);
            using (var pen = input.TinctureMain.CreatePen(lineWidth))
            {
                DrawStripesVertical(g, pen, data, lineWidth, input.Param1.Value);
            }
        }

        private static void DrawStripesHorizontal(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if (count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary tincture
            //// 1- means 1 primary stripe and 1 background tincture
            var i = 0;
            while (i < data.Height)
            {
                var lineCenter = i * lineWidth + lineWidth / 2;
                if (i % 2 == 0)
                    g.DrawLine(pen, new Point(data.Left, lineCenter), new Point(data.Right, lineCenter));
                i++;
            }
        }

        private static void DrawStripesVertical(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if (count == 0)
                return;

            //// Size iz count of 1 colored stripe of primary tincture
            //// 1- means 1 primary stripe and 1 background tincture
            var i = 0;

            while (i < data.Width)
            {
                var lineCenter = i * lineWidth + lineWidth / 2;
                if (i % 2 == 0)
                    g.DrawLine(pen, new Point(lineCenter, data.Top), new Point(lineCenter, data.Bottom));
                i++;
            }
        }

        private void DrawPals(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = data.Width / (input.Param1.Value * 2 + 1);
            using (var pen = input.TinctureMain.CreatePen(lineWidth))
            {
                DrawStripesPal(g, pen, data, lineWidth, input.Param1.Value);
            }
        }

        private void DrawBars(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = data.Height / (input.Param1.Value * 2 + 1);
            using (var pen = input.TinctureMain.CreatePen(lineWidth))
            {
                DrawStripesBar(g, pen, data, lineWidth, input.Param1.Value);
            }
        }

        private static void DrawStripesPal(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if (count == 0)
                return;

            var pileZone = data.Width / count;
            var pileZoneCenter = pileZone / 2;
            var i = 0;
            while (i < count)
            {
                g.DrawLine(pen, new Point(pileZoneCenter, data.Top), new Point(pileZoneCenter, data.Bottom));
                pileZoneCenter += pileZone;
                i++;
            }
        }

        private static void DrawStripesBar(Graphics g, Pen pen, SignumData data, int lineWidth, int count)
        {
            if (count == 0)
                return;

            var pileZone = data.Height / count;
            var pileZoneCenter = pileZone / 2;
            var i = 0;
            while (i < count)
            {
                g.DrawLine(pen, new Point(data.Left, pileZoneCenter), new Point(data.Right, pileZoneCenter));
                pileZoneCenter += pileZone;
                i++;
            }
        }
    }
}
