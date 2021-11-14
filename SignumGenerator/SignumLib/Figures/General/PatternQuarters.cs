using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternQuarters : PatternAbstract, IPattern
    {
        private PatternPosition _position;
        private Quarter _quarters;

        public PatternQuarters(PatternPosition position, Quarter quarters)
        {
            this._position = position;
            this._quarters = quarters;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._quarters)
            {
                case Quarter.One:
                    {
                        DrawQuarter(g, data, input);
                        return;
                    }
            }

            switch (this._position)
            {
                case PatternPosition.Common:
                    {
                        switch (this._quarters)
                        {
                            case Quarter.OneAndFour:
                                {
                                    DrawQuarters14(g, data, input);
                                    return;
                                }
                            case Quarter.TwoANdThree:
                                {
                                    DrawQuarters23(g, data, input);
                                    return;
                                }
                        }
                        break;
                    }
                case PatternPosition.Diagonal:
                    {
                        switch (this._quarters)
                        {
                            case Quarter.OneAndFour:
                                {
                                    DrawQuartersDiagonalTopBottom(g, data, input);
                                    return;
                                }
                            case Quarter.TwoANdThree:
                                {
                                    DrawQuartersDiagonalLeftRight(g, data, input);
                                    return;
                                }
                        }
                        break;
                    }
            }
        }

        private static void DrawQuarter(Graphics g, SignumData data, InputLayerData input)
        {
            var rect = new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2);
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawQuartersDiagonalLeftRight(Graphics g, SignumData data, InputLayerData input)
        {
            var region = CreateRegion(new Point[]
            {
                new(data.Left, data.Top),
                new(data.CenterX, data.CenterY),
                new(data.Left, data.Bottom)
            });
            region.Union(CreateRegion(new Point[]
            {
                new(data.Right, data.Top),
                new(data.CenterX, data.CenterY),
                new(data.Right, data.Bottom)
            }));

            DrawRegion(g, region, input);
        }

        private static void DrawQuartersDiagonalTopBottom(Graphics g, SignumData data, InputLayerData input)
        {
            var region = CreateRegion(new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.CenterX, data.CenterY)
            });
            region.Union(CreateRegion(new Point[]
            {
                new(data.Left, data.Bottom),
                new(data.CenterX, data.CenterY),
                new(data.Right, data.Bottom)
            }));

            DrawRegion(g, region, input);
        }

        private static void DrawQuarters14(Graphics g, SignumData data, InputLayerData input)
        {
            var rect1 = new Rectangle(data.Left, data.Top, data.Width / 2, data.Height / 2);
            var rect2 = new Rectangle(data.CenterX, data.CenterY, data.Width / 2, data.Height / 2);
            var region = rect1.ToRegion(rect2.ToRegion());
            DrawRegion(g, region, input);
        }

        private static void DrawQuarters23(Graphics g, SignumData data, InputLayerData input)
        {
            var rect1 = new Rectangle(data.CenterX, data.Top, data.Width / 2, data.Height / 2);
            var rect2 = new Rectangle(data.Left, data.CenterY, data.Width / 2, data.Height / 2);
            var region = rect1.ToRegion(rect2.ToRegion());
            DrawRegion(g, region, input);
        }
    }
}
