using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using SignumLib.Base;
using SignumLib.Drawing;
using SignumLib.Tincture;

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

                if (!signumTincture.IsFur)
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
    }
}
