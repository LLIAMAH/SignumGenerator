using System;
using System.Drawing;
using System.Windows.Forms;
using SignumGenerator.Signum;
using Color = System.Drawing.Color;

namespace SignumGenerator
{
    public partial class FMain : Form
    {
        private Bitmap _bmp;

        public FMain()
        {
            InitializeComponent();
        }

        private void bnInitNew_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();

            this._bmp = new Bitmap(600, 600);

            using var g = Graphics.FromImage(this._bmp);
            using var brushBg = new SolidBrush(Color.White);
            using var brushBg1 = new SolidBrush(Color.Black);
            using var penShield =  SignumPen.CreatePen(Electrum.Sable);

            g.FillRectangle(brushBg, 0, 0, 600, 600);
            var p = SignumFigure.CreateMainShield(100, 100, 10, 12, 20);
            //g.DrawPolygon(penShield, p);
            g.FillPolygon(brushBg1, p);

            //DrawImage(g);

            pbResult.Image = this._bmp;
        }

        //private void DrawImage(Graphics graphics)
        //{
        //    Rectangle cropRect = new Rectangle(...);
        //    Bitmap src = Image.FromFile(fileName) as Bitmap;
        //    Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

        //    using (Graphics g = Graphics.FromImage(target))
        //    {
        //        g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
        //            cropRect,
        //            GraphicsUnit.Pixel);
        //    }
        //}

        private void bnBrushTest_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(600, 600);
            using var g = Graphics.FromImage(this._bmp);
            using var brushBg = new SolidBrush(Color.White);
            g.FillRectangle(brushBg, 0, 0, 600, 600);

            if (Image.FromFile(
                    "C:\\Users\\User\\source\\repos\\SignumGenerator\\SignumGenerator\\SignumGenerator\\Brushes\\BrushTest.png")
                is Bitmap bmpHigh)
            {
                //var list = new List<Color>();
                var clrWhite = new Color();
                for (var y = 0; y < bmpHigh.Height; y++)
                {
                    for (var x = 0; x < bmpHigh.Width; x++)
                    {
                        var clr = bmpHigh.GetPixel(x, y);
                        //list.Add(clr);
                        if (bmpHigh.GetPixel(x, y).Name == "ff000000")
                            bmpHigh.SetPixel(x, y, Color.Red);
                    }
                }

                //var t = list.Distinct();

                g.DrawImage(bmpHigh, new Point(40, 60));
            }


            pbResult.Image = this._bmp;
        }

        ~FMain()
        {
            this._bmp.Dispose();
        }
    }
}
