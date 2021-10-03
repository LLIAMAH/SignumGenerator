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

        public void SetParams(string title, List<SignumTincture> tincturesList)
        {
            this.Title.Text = title;
            foreach (var tincture in tincturesList)
                this.ColorBase.Items.Add(tincture);

            var def1 = tincturesList.SingleOrDefault(o => o.Tincture == ETincture.Ermine);
            var def2 = tincturesList.SingleOrDefault(o => o.Tincture == ETincture.Vair);
            tincturesList.Remove(def1);
            tincturesList.Remove(def2);

            foreach (var tincture in tincturesList)
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
            var val = (sender as ComboBox)?.SelectedItem as SignumTincture;
            if (val == null)
                return;

            this.ColorBG.Enabled = this.ColorSub.Enabled = val.Tincture is ETincture.Ermine or ETincture.Vair;
        }
    }
}
