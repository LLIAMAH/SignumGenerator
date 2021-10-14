using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SignumGenerator.Helpers;
using SignumGenerator.Signum;

namespace SignumGenerator.Controls
{
    public partial class InputControlBase : UserControl
    {
        public InputControlBase()
        {
            InitializeComponent();
        }

        public void SetParams(string title, List<SignumTincture> tincturesListFull, List<SignumTincture> tincturesListShort)
        {
            this.Title.Text = title;
            foreach (var tincture in tincturesListFull)
                this.ColorBase.Items.Add(tincture);

            foreach (var tincture in tincturesListShort)
            {
                this.ColorSub.Items.Add(tincture);
                this.ColorBG.Items.Add(tincture);
            }

            this.ColorBase.SelectedIndex = 0;
            this.ColorSub.SelectedIndex = 0;
            this.ColorBG.SelectedIndex = 0;
            this.ColorBase.DisplayMember = "TinctureName";
            this.ColorBase.ValueMember = "Tincture";
            this.ColorSub.DisplayMember = "TinctureName";
            this.ColorSub.ValueMember = "Tincture";
            this.ColorBG.DisplayMember = "TinctureName";
            this.ColorBG.ValueMember = "Tincture";
        }

        public InputBaseData GetInput()
        {
            var tinctureMain = ColorBase.SelectedItem as SignumTincture;
            var tinctureSub = ColorSub.SelectedItem as SignumTincture;
            var tinctureBg = ColorBG.SelectedItem as SignumTincture;

            return new InputBaseData(tinctureMain, tinctureSub, tinctureBg);
        }

        private void ColorBase_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((sender as ComboBox)?.SelectedItem is not SignumTincture val)
                return;

            this.ColorBG.Enabled = this.ColorSub.Enabled = val.IsFur;
        }
    }
}
