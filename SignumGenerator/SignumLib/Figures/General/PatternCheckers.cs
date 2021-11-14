using SignumLib.Base;
using SignumLib.Helpers;
using SignumLib.Tincture;
using System.Drawing;

namespace SignumLib.Figures.General
{
    internal class PatternCheckers : PatternAbstract, IPatternLayer
    {
        private PatternPosition _position;
        private PatternDirection _direction;

        public PatternCheckers(PatternPosition position, PatternDirection direction)
        {
            this._position = position;
            this._direction = direction;
        }

        public void Draw(Graphics g, SignumData data, InputLayerData input)
        {
            using (var brush = input.TinctureMain.CreateBrush())
            {
                switch (_position)
                {
                    case PatternPosition.Common:
                        {
                            switch (this._direction)
                            {
                                case PatternDirection.Normal:
                                    {
                                        DrawCheckersNormal(g, brush, data, input.Param1.Value);
                                        break;
                                    }
                                case PatternDirection.Inverse:
                                    {
                                        DrawCheckersInverse(g, brush, data, input.Param1.Value);
                                        break;
                                    }
                            }
                            break;
                        }
                    case PatternPosition.Diagonal:
                        {
                            DrawCheckersDiagonal(g, brush, data, input.Param1.Value);
                            break;
                        }
                }
            }
        }

        private static void DrawCheckersNormal(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    if ((j / size) % 2 == 0)
                    {
                        if ((i / size) % 2 == 0)
                            FillRect(g, brush, i, j, size, size);
                    }
                    else
                    {
                        if ((i / size) % 2 == 1)
                            FillRect(g, brush, i, j, size, size);
                    }
                }
            }
        }

        private static void DrawCheckersInverse(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;

            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    if ((j / size) % 2 == 0)
                    {
                        if ((i / size) % 2 == 1)
                            FillRect(g, brush, i, j, size, size);
                    }
                    else
                    {
                        if ((i / size) % 2 == 0)
                            FillRect(g, brush, i, j, size, size);
                    }
                }
            }
        }

        private static void DrawCheckersDiagonal(Graphics g, Brush brush, SignumData data, int size)
        {
            if (size == 0)
                size = 100;


            for (var j = 0; j < data.Height; j += size)
            {
                for (var i = 0; i < data.Width; i += size)
                {
                    var points = new Point[]
                    {
                        new(i + size / 2, j),
                        new(i + size, j + size / 2),
                        new(i + size / 2, j + size),
                        new(i, j + size / 2)
                    };

                    g.FillPolygon(brush, points);
                }
            }
        }
    }
}
