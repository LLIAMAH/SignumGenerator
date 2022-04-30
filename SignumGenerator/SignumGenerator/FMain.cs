using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SignumLib.Base;
using SignumLib.Drawing;
using SignumLib.Tincture;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace SignumGenerator
{
    public partial class FMain : Form
    {
        private const int CanvasWidth = 800;
        private const int CanvasHeight = 1000;

        private Bitmap _bmp;

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            var enumTinctures = Enum.GetNames<ETincture>().ToList();
            var tincturesListFull = new List<SignumTincture>();
            var tincturesListShort = new List<SignumTincture>();
            foreach (var tinctureStr in enumTinctures)
            {
                var tincture = (ETincture)Enum.Parse(typeof(ETincture), tinctureStr);
                var signumTincture = new SignumTincture(tincture);
                tincturesListFull.Add(signumTincture);

                if (!signumTincture.IsFur && !signumTincture.IsComplex)
                    tincturesListShort.Add(signumTincture);
            }

            var enumFigures = Enum.GetNames<SignumBasePattern>().ToList();

            layerBase.SetParams("Base", tincturesListFull, tincturesListShort);
            layer1.SetParams("Layer 1", enumFigures, tincturesListFull, tincturesListShort);
            layer2.SetParams("Layer 2", enumFigures, tincturesListFull, tincturesListShort);
            layer3.SetParams("Layer 3", enumFigures, tincturesListFull, tincturesListShort);
            layer4.SetParams("Layer 4", enumFigures, tincturesListFull, tincturesListShort);
            layer5.SetParams("Layer 5", enumFigures, tincturesListFull, tincturesListShort);
        }

        ~FMain()
        {
            this._bmp.Dispose();
        }

        private void bnDraw_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(CanvasWidth, CanvasHeight);
            var g = Graphics.FromImage(this._bmp);

            var signumBase = new SignumBase(CanvasWidth, CanvasHeight);
            signumBase.SetBase(layerBase.GetInput());
            signumBase.Add(layer1.GetInput());
            signumBase.Add(layer2.GetInput());
            signumBase.Add(layer3.GetInput());
            signumBase.Add(layer4.GetInput());
            signumBase.Add(layer5.GetInput());

            signumBase.Apply();

            g.SetClip(CreateShieldRegion(new SignumData(CanvasWidth, CanvasHeight)), CombineMode.Replace);
            signumBase.Draw(g);
            pbResult.Image = this._bmp;
        }

        // ToDo: to rework region more visible as shield.
        private static Region CreateShieldRegion(SignumData data)
        {
            var points = new Point[]
            {
                new(data.Left, data.Top),
                new(data.Right, data.Top),
                new(data.Right, data.Bottom - data.Vertical10),
                new(data.CenterX, data.Bottom),
                new(data.Left, data.Bottom - data.Vertical10),
            };

            var types = new byte[]
            {
                (byte)PathPointType.Line,
                (byte)PathPointType.Line,
                (byte)PathPointType.Line,
                (byte)PathPointType.Line,
                (byte)PathPointType.Line
            };

            var gp = new GraphicsPath(points, types);
            var region = new Region(gp);
            return region;
        }

        private void bnSaveToFile_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
                pbResult.Image.Save(dlgSaveFile.FileName, ImageFormat.Png);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bmp = new Bitmap(256, 256);
            var data = new SignumData(bmp);
            var g = Graphics.FromImage(bmp);

            var height = SignumData.GetPercents(data.Height, 80);
            var width = height / 2;

            //g.FillEllipse(new SolidBrush(Color.Black), rect);

            var img = bmp as Image;
            var defaultPath = "C:\\Temp";
            img.Save(Path.Combine(defaultPath, "Bg_Besante.png"), ImageFormat.Png);
        }

        private void bnSquaresArray_Click(object sender, EventArgs e)
        {
            var division = Convert.ToInt32(string.IsNullOrEmpty(tbDivision.Text) ? "0" : tbDivision.Text);
            var size = Convert.ToInt32(string.IsNullOrEmpty(tbSize.Text) ? "0" : tbSize.Text );
            if (division <= 0 || size <= 0)
            {
                MessageBox.Show("Division and size values must be more than '0'.");
                return;
            }

            pbResult.Image?.Dispose();
            var bmp = new Bitmap(CanvasWidth, CanvasHeight);
            var data = new SignumData(bmp);
            var g = Graphics.FromImage(bmp);
            using (var brush = new SolidBrush(Color.Black))
            {
                g.FillRectangle(brush, 0, 0, CanvasWidth, CanvasHeight);
            }

            var pointStepX = CanvasWidth / (division + 1);
            var pointStepY = CanvasHeight / (division + 1);
            for (var j = pointStepY; j + (size / 2) < CanvasHeight; j += pointStepY)
            {
                for (var i = pointStepX; i + (size / 2) < CanvasWidth; i += pointStepX)
                {
                    DrawSquare(g, size, i, j, Color.Yellow);
                }
            }

            pbResult.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var division = Convert.ToInt32(string.IsNullOrEmpty(tbDivision.Text) ? "0" : tbDivision.Text);
            var size = Convert.ToInt32(string.IsNullOrEmpty(tbSize.Text) ? "0" : tbSize.Text);
            if (division <= 0 || size <= 0)
            {
                MessageBox.Show("Division and size values must be more than '0'.");
                return;
            }

            pbResult.Image?.Dispose();
            var bmp = new Bitmap(CanvasWidth, CanvasHeight);
            var data = new SignumData(bmp);
            var g = Graphics.FromImage(bmp);

            using (var pen = new Pen(Color.Black, 5))
            {
                g.DrawRectangle(pen, new Rectangle(0,0, CanvasWidth, CanvasHeight));
            }

            var pointStepX = CanvasWidth / division;
            var pointStepY = CanvasHeight / division;

            var dimension = pointStepX <= pointStepY ? pointStepX : pointStepY;
            var dimensionHalf = dimension / 2;
            var centerX = pointStepX / 2;
            var centerY = pointStepY / 2;

            for (var j = 0; j <= CanvasHeight; j += pointStepY)
            {
                for (var i = 0; i <= CanvasWidth; i += pointStepX)
                {
                    var x = i + centerX - dimensionHalf;
                    var y = j + centerY - dimensionHalf;
                    var rectSize = new Size(dimension, dimension);

                    var rect = new Rectangle(new Point(x,y), rectSize);
                    DrawBoard(g, rect, Color.Orange);
                }
            }

            pbResult.Image = bmp;
        }

        private static void DrawBoard(Graphics g, int i, int j, int sizeX, int sizeY, Color color)
        {
            using (var pen = new Pen(color, 3))
            {
                var rect = new Rectangle(i, j, sizeX, sizeY);
                g.DrawRectangle(pen, rect);
            }
        }

        private static void DrawBoard(Graphics g, Rectangle rect, Color color)
        {
            using (var pen = new Pen(color, 3))
            {
                g.DrawRectangle(pen, rect);
            }
        }

        private static void DrawSquare(Graphics g, int size, int i, int j, Color color)
        {
            var halfSize = size / 2;
            using (var brush = new SolidBrush(color))
            {
                var rect = new Rectangle(
                    new Point(i - halfSize, j - halfSize),
                    new Size(size, size));
                g.FillRectangle(brush, rect);
                using (var pen = new Pen(Color.Red))
                {
                    g.DrawEllipse(pen, i - 2, j - 2, 2, 2);
                }
            }
        }
    }
}
