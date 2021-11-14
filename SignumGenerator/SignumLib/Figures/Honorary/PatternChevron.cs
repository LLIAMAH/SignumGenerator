﻿using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.Honorary
{
    internal class PatternChevron : PatternAbstract, IPatternLayer
    {
        private readonly PatternChevronType _type;
        private readonly PatternDirection _direction;

        public PatternChevron(PatternDirection direction, PatternChevronType type)
        {
            this._type = type;
            this._direction = direction;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            switch (this._direction)
            {
                case PatternDirection.Normal:
                    {
                        // VH: to recheck which are required, but which are obsolete.
                        switch (this._type)
                        {
                            case PatternChevronType.Normal:
                                {
                                    DrawHonoraryChevron(g, data, input);
                                    break;
                                }
                            case PatternChevronType.Middle:
                                {
                                    DrawChevronMiddleNormal(g, data, input);
                                    break;
                                }
                            case PatternChevronType.Full:
                                {
                                    DrawChevronFullNormal(g, data, input);
                                    break;
                                }
                            case PatternChevronType.Custom:
                                {
                                    DrawChevronPointOffsetSizeNormal(g, data, input);
                                    break;
                                }
                        }
                        break;
                    }
                case PatternDirection.Inverse:
                    {
                        // VH: to recheck which are required, but which are obsolete.
                        switch (this._type)
                        {
                            case PatternChevronType.Normal:
                                {
                                    DrawHonoraryChevronInverse(g, data, input);
                                    break;
                                }
                            case PatternChevronType.Middle:
                                {
                                    DrawChevronMiddleInvert(g, data, input);
                                    break;
                                }
                            case PatternChevronType.Full:
                                {
                                    DrawChevronFullInverse(g, data, input);
                                    break;
                                }
                            case PatternChevronType.Custom:
                                {
                                    DrawChevronPointOffsetSizeInverse(g, data, input);
                                    break;
                                }
                        }
                        break;
                    }
            }
        }

        private static void DrawHonoraryChevron(Graphics g, SignumData data, InputLayerData input)
        {
            DrawChevronPointOffsetSizeNormal(g, data, input);
        }

        private static void DrawHonoraryChevronInverse(Graphics g, SignumData data, InputLayerData input)
        {
            DrawChevronPointOffsetSizeInverse(g, data, input);
        }

        private static void DrawChevronPointOffsetSizeNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var halfSize = input?.Param1 is null or 0 ? GetHeraldicWidthSling() / 2 : input.Param1.Value / 2;
            var point = input?.Param2 is null or 0 ? data.CenterY : input.Param2.Value;
            var offset = input?.Param3 is null or 0 ? data.Width / 2 : input.Param3.Value;

            var points = new Point[]
            {
                new(data.Left, point + offset - halfSize),
                new(data.CenterX, point - halfSize),
                new(data.Right, point + offset - halfSize),
                new(data.Right, point + offset + halfSize),
                new(data.CenterX, point + halfSize),
                new(data.Left, point + offset + halfSize)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronPointOffsetSizeInverse(Graphics g, SignumData data, InputLayerData input)
        {
            var halfSize = input?.Param1 is null or 0 ? GetHeraldicWidthSling() / 2 : input.Param1.Value / 2;
            var point = input?.Param2 is null or 0 ? data.CenterY : input.Param2.Value;
            var offset = input?.Param3 is null or 0 ? data.Width / 2 : input.Param3.Value;

            var points = new Point[]
            {
                new(data.Left, point - offset - halfSize),
                new(data.CenterX, point - halfSize),
                new(data.Right, point - offset - halfSize),
                new(data.Right, point - offset + halfSize),
                new(data.CenterX, point + halfSize),
                new(data.Left, point - offset + halfSize)
            };

            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronFullNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var points = new Point[]
            {
                new(data.Left, data.Bottom - size),
                new(data.CenterX, data.Top),
                new(data.Right, data.Bottom - size),
                new(data.Right, data.Bottom),
                new(data.CenterX, data.Top + size),
                new(data.Left, data.Bottom)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronFullInverse(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.CenterX, data.Bottom - size),
                new(data.Right, data.Top),
                new(data.Right, data.Top + size),
                new(data.CenterX, data.Bottom),
                new(data.Left, data.Top + size)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronMiddleNormal(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var halfSize = size / 2;
            var points = new Point[]
            {
                new(data.Left, data.CenterY - halfSize + data.Width / 2),
                new(data.CenterX, data.CenterY - halfSize),
                new(data.Right, data.CenterY - halfSize + data.Width / 2),
                new(data.Right, data.CenterY + halfSize + data.Width / 2),
                new(data.CenterX, data.CenterY + halfSize),
                new(data.Left, data.CenterY + halfSize + data.Width / 2)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }

        private static void DrawChevronMiddleInvert(Graphics g, SignumData data, InputLayerData input)
        {
            var size = input.Param1 is null or 0 ? GetHeraldicWidthSling() : input.Param1.Value;
            var halfSize = size / 2;
            var points = new Point[]
            {
                new(data.Left, data.CenterY - halfSize - data.Width / 2),
                new(data.CenterX, data.CenterY - halfSize),
                new(data.Right, data.CenterY - halfSize - data.Width / 2),
                new(data.Right, data.CenterY + halfSize - data.Width / 2),
                new(data.CenterX, data.CenterY + halfSize),
                new(data.Left, data.CenterY + halfSize - data.Width / 2)
            };
            var region = CreateRegion(points);
            DrawRegion(g, region, input);
        }
    }
}
