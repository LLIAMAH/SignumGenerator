using System.Drawing;
using System.IO;
using SignumGenerator.Helpers;
using Color = System.Drawing.Color;

namespace SignumGenerator.Signum
{
    public enum ETincture
    {
        Default,
        Gules, // Scarlet
        Azure, // Blue
        Vert, // Green
        Purpure, // Purple
        Sable, // Black
        Or, // 255, 215, 0
        Argent, // 192, 192, 192 left as White? 
        Ermine,
        Vair,
        Sanguine,
        Murrey,
        Tenne
    }

    public class SignumColor
    {
        private readonly ETincture _tincture;

        public ETincture Tincture => _tincture;
        public Color Color => GetColor(_tincture);
        public bool IsTinctureFur => _tincture is ETincture.Ermine or ETincture.Vair;
        public bool IsTinctureMetal => _tincture is ETincture.Or or ETincture.Argent;
        public bool IsTinctureColor => !(IsTinctureFur || IsTinctureMetal);

        public SignumColor(ETincture eTincture)
        {
            this._tincture = eTincture;
        }

        public Brush CreateBrush()
        {
            return new SolidBrush(this.Color);
        }

        public Image CreateFur()
        {
            return GetColorFur(this._tincture);
        }

        public Pen CreatePen(int size = 1)
        {
            return new Pen(this.Color, size);
        }

        public static Pen CreatePen(Color color, int width = 1)
        {
            return new Pen(color, width);
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
                ETincture.Argent => Color.FromArgb(255, 192, 192, 192),
                ETincture.Sanguine => Color.FromArgb(255, 188, 63, 74),
                ETincture.Murrey => Color.FromArgb(255, 139, 0, 75),
                ETincture.Tenne => Color.FromArgb(255, 205, 87, 00),
                _ => Color.FromArgb(255, 0, 0, 0)
            };
        }

        private static Image GetColorFur(ETincture eTincture)
        {
            return eTincture switch
            {
                ETincture.Ermine => GetErmine(),
                ETincture.Vair => GetVair(),
                _ => GetErmine()
            };
        }

        private static Image GetErmine()
        {
            /*
             * MemoryStream PCDStream = new MemoryStream(Data, 0, Data.Length);
             * var ResourceStream = ConvertPCD9ToDDSv22 (PCDStream,VersionDRM);
             * ResourceStream.Position = 0;
             * var DDSImage = new DDSImage (ResourceStream);
             * var Bitmap = DDSImage.BitmapImage;
             * previewPictureBox.Image = Bitmap;
             */

            using var fs = new FileStream("Images\\Fur_Ermine.dds", FileMode.Open, FileAccess.Read);
            var img = new DDSImage(fs);
            var bmp = img.BitmapImage;

            return bmp;

            //return ImageSourceFromBitmap(bmp);
        }

        private static Image GetVair()
        {
            using var fs = new FileStream("Images\\Fur_Vair.dds", FileMode.Open, FileAccess.Read);
            var img = new DDSImage(fs);
            var bmp = img.BitmapImage;

            return bmp;

            //return ImageSourceFromBitmap(bmp);
        }

        //#region Conversionblock

        ////If you get 'dllimport unknown'-, then add 'using System.Runtime.InteropServices;'
        //[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool DeleteObject([In] IntPtr hObject);

        //public static ImageSource ImageSourceFromBitmap(Bitmap bmp)
        //{
        //    var handle = bmp.GetHbitmap();
        //    try
        //    {
        //        return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        //    }
        //    finally { DeleteObject(handle); }
        //}

        //#endregion
    }
}
