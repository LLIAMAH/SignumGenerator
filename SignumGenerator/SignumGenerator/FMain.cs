using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void FMain_Load(object sender, EventArgs e)
        {
            var enumColors = Enum.GetNames<EColor>().ToList();
            var list = new List<string>();
            list.AddRange(enumColors);

            var enumFigures = Enum.GetNames<SignumBasePattern>().ToList();
            cbLayer1Color.Items.AddRange(list.ToArray());
            cbLayer2Color.Items.AddRange(list.ToArray());
            cbLayer3Color.Items.AddRange(list.ToArray());
            cbLayer1Color.SelectedIndex = 0;
            cbLayer2Color.SelectedIndex = 0;
            cbLayer3Color.SelectedIndex = 0;

            cbLayer1Figure.Items.AddRange(enumFigures.ToArray());
            cbLayer2Figure.Items.AddRange(enumFigures.ToArray());
            cbLayer3Figure.Items.AddRange(enumFigures.ToArray());

            list.Remove("Default");
            cbColorBase.Items.AddRange(list.ToArray());
            cbColorBase.SelectedIndex = 0;
        }

        private void bnCreateMain_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(800, 1000);
            var g = Graphics.FromImage(this._bmp);

            var layer1Color = Enum.Parse<EColor>(cbLayer1Color.SelectedItem as string ?? string.Empty);
            var layer1Figure = Enum.Parse<SignumBasePattern>(cbLayer1Figure.SelectedItem as string ?? string.Empty);

            var layer2Color = Enum.Parse<EColor>(cbLayer2Color.SelectedItem as string ?? string.Empty);
            var layer2Figure = Enum.Parse<SignumBasePattern>(cbLayer2Figure.SelectedItem as string ?? string.Empty);

            var layer3Color = Enum.Parse<EColor>(cbLayer3Color.SelectedItem as string ?? string.Empty);
            var layer3Figure = Enum.Parse<SignumBasePattern>(cbLayer3Figure.SelectedItem as string ?? string.Empty);

            var signumBase = new SignumBase();
            signumBase.ApplyBase(SignumColor.GetColor(layer1Color));
            signumBase.ApplyPattern(SignumBasePattern.QuartersDiagonalTopBottom, SignumColor.GetColor(EColor.Argent), 200);
            signumBase.Draw(g);
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

        //private void bnNok_Click(object sender, EventArgs e)
        //{
        //    pbResult.Image?.Dispose();
        //    this._bmp = new Bitmap(600, 600);

        //    using var g = Graphics.FromImage(this._bmp);
        //    using var brushBg = new SolidBrush(Color.White);
        //    using var brushBg1 = new SolidBrush(Color.Black);
        //    using var penShield = SignumPen.CreatePen(EColor.Sable);

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
    }
}
