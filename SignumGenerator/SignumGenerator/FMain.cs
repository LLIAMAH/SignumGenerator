using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SignumGenerator.Helpers;
using SignumGenerator.Signum;
using Color = System.Drawing.Color;

namespace SignumGenerator
{
    public partial class FMain : Form
    {
        private Bitmap _bmp;
        private const int _lineWidth = 100;

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
            g.FillRectangle(brushBg1, 300, 300, 60, 60);

            //var signum = new SignumData(100, 100, 10, 12, 20);
            //var shield = new SignumShield(penShield, brushBg1, brushBg, signum);
            //shield.Draw(g);

            //var line = new SignumLine(SignumBrush.CreateBrush(Electrum.Purpure), signum);
            //line.Draw(g);

            //var p = SignumFigure.CreateMainShield(100, 100, 10, 12, 20);
            ////g.DrawPolygon(penShield, p);
            //g.FillPolygon(brushBg1, p);

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

        private void bnNok_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(600, 600);

            using var g = Graphics.FromImage(this._bmp);
            using var brushBg = new SolidBrush(Color.White);
            using var brushBg1 = new SolidBrush(Color.Black);
            using var penShield = SignumPen.CreatePen(Electrum.Sable);

            /*
             * MemoryStream PCDStream = new MemoryStream(Data, 0, Data.Length);
             * var ResourceStream = ConvertPCD9ToDDSv22 (PCDStream,VersionDRM);
             * ResourceStream.Position = 0;
             * var DDSImage = new DDSImage (ResourceStream);
             * var Bitmap = DDSImage.BitmapImage;
             * previewPictureBox.Image = Bitmap;
             */

            using (var fs = new FileStream("C:\\Users\\User\\Source\\Repos\\SignumGenerator\\SignumGenerator\\SignumGenerator\\Images\\ImageFile.dds",
                FileMode.Open, FileAccess.Read))
            {
                var img = new DDSImage(fs);
                var bmp = img.BitmapImage;
                g.DrawImage(bmp, 0, 0, 600, 600);
            }

            pbResult.Image = this._bmp;
        }

        private void bnCreateMain_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(800, 1000);
            var g = Graphics.FromImage(this._bmp);

            var signumBase = new SignumBase();
            signumBase.ApplyBase(SignumColor.GetColor(Electrum.Vert));
            //signumBase.ApplyPattern(SignumBasePattern.SlingLeft, SignumColor.GetColor(Electrum.Azure), _lineWidth);
            //signumBase.ApplyPattern(SignumBasePattern.SlingRight, SignumColor.GetColor(Electrum.Azure), _lineWidth);
            signumBase.ApplyPattern(SignumBasePattern.Quarters_2_4, SignumColor.GetColor(Electrum.Azure));
            //signumBase.ApplyPattern(SignumBasePattern.StripesHorizontal, SignumColor.GetColor(Electrum.Azure), 5);
            //signumBase.ApplyPattern(SignumBasePattern.StripesVertical, SignumColor.GetColor(Electrum.Azure), 5);

            signumBase.Draw(g);

            pbResult.Image = this._bmp;
        }

        private static Image CreateBitmap(Image bmp, Pen pen, Brush main, Brush bg)
        {
            using var g = Graphics.FromImage(bmp);
            //g.FillRectangle(bg, 0, 0, 600, 800);
            //var signum = new SignumData(0, 0, 12, 12, 20);
            //var shield = new SignumShield(pen, main, bg, signum);
            //shield.Draw(g);
            return bmp;
        }

        private void bnCreateShield_Click(object sender, EventArgs e)
        {

        }

        ~FMain()
        {
            this._bmp.Dispose();
        }
    }
}
