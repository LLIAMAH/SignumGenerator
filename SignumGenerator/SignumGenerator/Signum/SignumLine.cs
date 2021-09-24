using System.Collections.Generic;
using System.Drawing;

namespace SignumGenerator.Signum
{
    public class SignumLine: SignumAbstract
    {
        private readonly Brush _brush;
        private readonly SignumData _data;

        public SignumLine(Brush brush, SignumData signum)
        {
            this._brush = brush;
            this._data = signum;
        }

        public override void Draw(Graphics g)
        {

        }
    }
}
