﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using SignumGenerator.Signum;

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
            this._bmp = new Bitmap(CanvasWidth, CanvasHeight);
            var g = Graphics.FromImage(this._bmp);

            var signumBase = new SignumBase(CanvasWidth, CanvasHeight);
            var inputBase = layerBase.GetInput();
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
