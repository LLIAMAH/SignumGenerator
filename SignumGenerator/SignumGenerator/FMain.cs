﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SignumGenerator.Helpers;
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
            // ReSharper disable once CoVariantArrayConversion
            cbLayer1Color.Items.AddRange(tincturesList.ToArray());
            // ReSharper disable once CoVariantArrayConversion
            cbLayer2Color.Items.AddRange(tincturesList.ToArray());
            // ReSharper disable once CoVariantArrayConversion
            cbLayer3Color.Items.AddRange(tincturesList.ToArray());
            cbLayer1Color.SelectedIndex = 0;
            cbLayer2Color.SelectedIndex = 0;
            cbLayer3Color.SelectedIndex = 0;

            // ReSharper disable once CoVariantArrayConversion
            cbLayer1Figure.Items.AddRange(enumFigures.ToArray());
            // ReSharper disable once CoVariantArrayConversion
            cbLayer2Figure.Items.AddRange(enumFigures.ToArray());
            // ReSharper disable once CoVariantArrayConversion
            cbLayer3Figure.Items.AddRange(enumFigures.ToArray());
            cbLayer1Figure.SelectedIndex = 0;
            cbLayer2Figure.SelectedIndex = 0;
            cbLayer3Figure.SelectedIndex = 0;


            layer1.SetParams("Layer 1", enumFigures, tincturesList);
            layer2.SetParams("Layer 2", enumFigures, tincturesList);
            layer3.SetParams("Layer 3", enumFigures, tincturesList);
            layer4.SetParams("Layer 4", enumFigures, tincturesList);
            layer5.SetParams("Layer 5", enumFigures, tincturesList);


            var def = tincturesList.SingleOrDefault(o => o.Tincture == ETincture.Default);
            tincturesList.Remove(def);
            cbColorBase.Items.AddRange(tincturesList.ToArray());
            cbColorBase.SelectedIndex = 0;
        }

        private void bnCreateMain_Click(object sender, EventArgs e)
        {
            pbResult.Image?.Dispose();
            this._bmp = new Bitmap(800, 1000);
            var g = Graphics.FromImage(this._bmp);

            var baseColor = Enum.Parse<ETincture>(cbColorBase.SelectedItem as string ?? string.Empty);

            var input1 = new InputData(
                Enum.Parse<ETincture>(cbLayer1Color.SelectedItem as string ?? string.Empty),
                Enum.Parse<SignumBasePattern>(cbLayer1Figure.SelectedItem as string ?? string.Empty),
                Convert.ToInt32(tbLayer1Param.Text));

            var input2 = new InputData(
                Enum.Parse<ETincture>(cbLayer2Color.SelectedItem as string ?? string.Empty),
                Enum.Parse<SignumBasePattern>(cbLayer2Figure.SelectedItem as string ?? string.Empty),
                Convert.ToInt32(tbLayer2Param.Text));

            var input3 = new InputData(
                Enum.Parse<ETincture>(cbLayer3Color.SelectedItem as string ?? string.Empty),
                Enum.Parse<SignumBasePattern>(cbLayer3Figure.SelectedItem as string ?? string.Empty),
                Convert.ToInt32(tbLayer3Param.Text));

            var signumBase = new SignumBase();
            signumBase.ApplyBase(baseColor);
            if (!input1.IsEmpty)
                signumBase.ApplyPattern(input1);

            if (!input2.IsEmpty)
                signumBase.ApplyPattern(input2);

            if (!input3.IsEmpty)
                signumBase.ApplyPattern(input3);

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
    }
}
