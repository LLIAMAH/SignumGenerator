using System.Drawing;

namespace SignumGenerator.Signum
{
    public abstract class SignumAbstract
    {
        protected static int Width = 600;
        protected static int Height = 800;
        protected Bitmap _bmp;

        public abstract void Draw(Graphics g);
    }
}
