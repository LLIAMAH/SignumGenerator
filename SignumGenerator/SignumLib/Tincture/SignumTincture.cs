using System.Drawing;
using System.IO;
using Color = System.Drawing.Color;

// ReSharper disable ConvertToUsingDeclaration
namespace SignumLib.Tincture
{
    public enum ETincture
    {
        Default, // Black
        Gules, // Scarlet
        Azure, // Blue
        Vert, // Green
        Purpure, // Purple
        Sable, // Black
        Or, // 255, 215, 0
        Argent, // 192, 192, 192 left as White? 
        Ermine, // Fur tincture 
        Vair, // Fur tincture
        VairVs, // Fur tincture
        VairVsShifted, // Fur tincture
        Sanguine, // Blood
        Murrey, // Dark red
        Tenne // Orange
    }

    public class SignumTincture
    {
        private readonly ETincture _tincture;

        // ReSharper disable once InconsistentNaming
        private static readonly string _imagesPath =
            Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)!, "Images");

        public string TinctureName => this._tincture.ToString();
        public ETincture Tincture => _tincture;
        public Color Color => GetColor(_tincture);

        public bool IsFur => _tincture is ETincture.Ermine or ETincture.Vair or ETincture.VairVs or ETincture.VairVsShifted;
        public bool IsMetal => _tincture is ETincture.Or or ETincture.Argent;
        public bool IsCounter => _tincture is ETincture.VairVs or ETincture.VairVsShifted;

        public SignumTincture(ETincture eTincture)
        {
            this._tincture = eTincture;
        }

        public Brush CreateBrush()
        {
            return new SolidBrush(this.Color);
        }

        public Image CreateFur(SignumTincture tinctureSub)
        {
            return GetColorFur(this._tincture, tinctureSub);
        }

        public Pen CreatePen(int size = 1)
        {
            return new Pen(this.Color, size);
        }

        private static Color GetColor(ETincture eTincture)
        {
            return eTincture switch
            {
                ETincture.Azure => Color.FromArgb(255, 0, 125, 255),
                ETincture.Gules => Color.FromArgb(255, 255, 36, 0),
                ETincture.Purpure => Color.FromArgb(255, 160, 32, 240),
                ETincture.Sable => Color.FromArgb(255, 0, 0, 0),
                ETincture.Vert => Color.FromArgb(255, 0, 75, 0),
                ETincture.Or => Color.FromArgb(255, 255, 215, 0),
                ETincture.Argent => Color.FromArgb(255, 255, 255, 255),
                ETincture.Sanguine => Color.FromArgb(255, 188, 63, 74),
                ETincture.Murrey => Color.FromArgb(255, 139, 0, 75),
                ETincture.Tenne => Color.FromArgb(255, 205, 87, 00),
                _ => Color.FromArgb(255, 0, 0, 0)
            };
        }

        private static Image GetColorFur(ETincture fur, SignumTincture signumTincture)
        {
            var bmp = fur switch
            {
                ETincture.Ermine => GetErmine(),
                ETincture.Vair => GetVair(),
                ETincture.VairVs => GetVair(),
                ETincture.VairVsShifted => GetVair(),
                _ => GetErmine()
            };

            return ImageChangeColor(bmp, signumTincture.Tincture);
        }

        private static Image ImageChangeColor(Bitmap bmp, ETincture color)
        {
            const int colorMark = 0;
            var tincture = new SignumTincture(color);
            for (var j = 0; j < bmp.Height; j++)
            {
                for (var i = 0; i < bmp.Width; i++)
                {
                    var bmpPix = bmp.GetPixel(i, j);
                    if (bmpPix.A > colorMark)
                        bmp.SetPixel(i, j, tincture.Color);
                }
            }

            return bmp;
        }

        private static Bitmap GetErmine()
        {
            /*
             * MemoryStream PCDStream = new MemoryStream(Data, 0, Data.Length);
             * var ResourceStream = ConvertPCD9ToDDSv22 (PCDStream,VersionDRM);
             * ResourceStream.Position = 0;
             * var DDSImage = new DDSImage (ResourceStream);
             * var Bitmap = DDSImage.BitmapImage;
             * previewPictureBox.Image = Bitmap;
             */

            using (var fs = new FileStream(
                Path.Combine(_imagesPath, "Furs", "Fur_Ermine.png"), FileMode.Open, FileAccess.Read))
            {
                return new Bitmap(fs);
            }
        }

        private static Bitmap GetVair()
        {
            using (var fs = new FileStream(
                Path.Combine(_imagesPath, "Furs", "Fur_Vair.png"), FileMode.Open, FileAccess.Read))
            {
                return new Bitmap(fs);
            }
        }

        public override string ToString()
        {
            return $"{TinctureName} ({Color})";
        }
    }
}
