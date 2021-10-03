using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SignumGenerator.Signum;

namespace SignumGenerator
{
    public partial class FMain : Form
    {
        private Bitmap _bmp;

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            var enumTinctures = Enum.GetNames<ETincture>().ToList();
            var tincturesList = new List<SignumTincture>();
            foreach (var tinctureStr in enumTinctures)
            {
                var tincture = (ETincture) Enum.Parse(typeof(ETincture), tinctureStr);
                tincturesList.Add(new SignumTincture(tincture));
            }

            var enumFigures = Enum.GetNames<SignumBasePattern>().ToList();

            layerBase.SetParams("Base", tincturesList);
            layer1.SetParams("Layer 1", enumFigures, tincturesList);
            layer2.SetParams("Layer 2", enumFigures, tincturesList);
            layer3.SetParams("Layer 3", enumFigures, tincturesList);
            layer4.SetParams("Layer 4", enumFigures, tincturesList);
            layer5.SetParams("Layer 5", enumFigures, tincturesList);
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

        //private void bnNok_Click(object sender, EventArgs e)
        //{
        //    pbResult.Image?.Dispose();
        //    this._bmp = new Bitmap(600, 600);

        //    using var g = Graphics.FromImage(this._bmp);
        //    using var brushBg = new SolidBrush(Tincture.White);
        //    using var brushBg1 = new SolidBrush(Tincture.Black);
        //    using var penShield = SignumPen.CreatePen(ETincture.Sable);

        //    /*
        //     * MemoryStream PCDStream = new MemoryStream(Data, 0, Data.Length);
        //     * var ResourceStream = ConvertPCD9ToDDSv22 (PCDStream,VersionDRM);
        //     * ResourceStream.Position = 0;
        //     * var DDSImage = new DDSImage (ResourceStream);
        //     * var Bitmap = DDSImage.BitmapImage;
        //     * previewPictureBox.Image = Bitmap;
        //     */

        //    using (var fs = new FileStream("C:\\Users\\User\\Source\\Repos\\SignumGenerator\\SignumGenerator\\SignumGenerator\\Images\\ImageFile.dds",
        //        FileMode.Open, FileAccess.Read))
        //    {
        //        var img = new DDSImage(fs);
        //        var bmp = img.BitmapImage;
        //        g.DrawImage(bmp, 0, 0, 600, 600);
        //    }

        //    pbResult.Image = this._bmp;
        //}

        ~FMain()
        {
            this._bmp.Dispose();
        }

        private void bnDraw_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(800, 1000);
            var g = Graphics.FromImage(this._bmp);

            var inputBase = layerBase.GetInput();

            var signumBase = new SignumBase();
            signumBase.ApplyBase(inputBase);

            var input1 = layer1.GetInput();
            if(!input1.IsEmpty)
                signumBase.ApplyPattern(input1);

            var input2 = layer2.GetInput();
            if (!input2.IsEmpty)
                signumBase.ApplyPattern(input2);

            var input3 = layer3.GetInput();
            if (!input3.IsEmpty)
                signumBase.ApplyPattern(input3);

            var input4 = layer4.GetInput();
            if (!input4.IsEmpty)
                signumBase.ApplyPattern(input4);

            var input5 = layer5.GetInput();
            if (!input5.IsEmpty)
                signumBase.ApplyPattern(input5);

            signumBase.Draw(g);
            pbResult.Image = this._bmp;
        }
    }
}
