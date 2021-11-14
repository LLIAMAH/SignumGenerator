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
                case PatternSide.Left:
                    {
                        break;
                    }
                case PatternSide.Right:
                    {
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
