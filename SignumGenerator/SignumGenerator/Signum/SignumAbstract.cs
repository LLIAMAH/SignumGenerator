using System.Drawing;

namespace SignumGenerator.Signum
{
    public abstract class SignumAbstract
    {
        protected static int Width = 800;
        protected static int Height = 1000;
        protected Bitmap _bmp;

        public abstract void Draw(Graphics g);
    }
}
