using System.Collections.Generic;
using System.Windows.Forms;
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

            this.ColorBase.SelectedIndex = 0;
            this.ColorBase.DisplayMember = "TinctureName";
            this.ColorBase.ValueMember = "Tincture";
        }
    }
}
