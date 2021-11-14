﻿using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternFlanc : PatternAbstract, IPattern
    {
        private readonly PatternSide _side;

        public PatternFlanc(PatternSide side)
        {
            this._side = side;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            throw new System.NotImplementedException();
        }

        private static void DrawHonoraryFlankLeft(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthNormal(data)
                : input.Param1.Value;

            var rect = new Rectangle(new Point(data.Left, data.Top), new Size(lineWidth, data.Height));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }

        private static void DrawHonoraryFlankRight(Graphics g, SignumData data, InputLayerData input)
        {
            var lineWidth = input.Param1 is null or 0
                ? GetHeraldicWidthNormal(data)
                : input.Param1.Value;

            var rect = new Rectangle(new Point(data.Right - lineWidth, data.Top), new Size(lineWidth, data.Height));
            var region = CreateRegion(rect.ToPoints());
            DrawRegion(g, region, input);
        }
    }
}
