using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    public class PatternSlice : PatternAbstract, IPatternLayer
    {
        private PatternSide _side;

        public PatternSlice(PatternSide side)
        {
            this._side = side;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (_side)
            {
                case PatternSide.TopAndLeft:
                    {
                        DrawSliceLeftNormal(g, data, input);
                        break;
                    }
                case PatternSide.BottomAndRight:
                    {
                        DrawSliceLeftInvert(g, data, input);
                        break;
                    }
                case PatternSide.TopAndRight:
                    {
                        DrawSliceRightNormal(g, data, input);
                        break;
                    }
                case PatternSide.BottomAndLeft:
                    {
                        DrawSliceRightInvert(g, data, input);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private static void DrawSliceLeftNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.Left, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSliceLeftInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Bottom),
                new(data.Right, data.Top),
                new(data.Right, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSliceRightNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.Right, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawSliceRightInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Bottom),
                new(data.Left, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }
    }
}
