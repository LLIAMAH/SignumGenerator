using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SignumGenerator.Signum;

namespace SignumGenerator.Controls
{
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        public void SetParams(string title, List<string> figuresList, List<SignumTincture> tincturesList)
        {
            this.Title.Text = title;
            foreach (var figure in figuresList)
                this.Figure.Items.Add(figure);

            foreach (var tincture in tincturesList)
            {
                this.ColorMain.Items.Add(tincture);
                this.ColorSub.Items.Add(tincture);
            }

            this.Figure.SelectedIndex = 0;
            this.ColorMain.SelectedIndex = 0;
            this.ColorMain.DisplayMember = "TinctureName";
            this.ColorMain.ValueMember = "Tincture";
            this.ColorSub.SelectedIndex = 0;
            this.ColorSub.DisplayMember = "TinctureName";
            this.ColorSub.ValueMember = "Tincture";
        }

        private void Figure_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            var val = Enum.Parse<SignumBasePattern>(cb?.SelectedItem?.ToString()!);

            switch (val)
            {
                case SignumBasePattern.StripesHorizontal:
                case SignumBasePattern.StripesVertical:
                case SignumBasePattern.SlingLeft:
                case SignumBasePattern.SlingRight:
                case SignumBasePattern.CheckersNormal:
                case SignumBasePattern.CheckersInverse:
                case SignumBasePattern.CheckersDiagonal:
                case SignumBasePattern.ChevronMiddleNormal:
                case SignumBasePattern.ChevronMiddleInvert:
                case SignumBasePattern.ChevronFullNormal:
                case SignumBasePattern.ChevronFullInvert:
                    SetParamsAvailable(1);
                    break;
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                    SetParamsAvailable(3);
                    break;
                case SignumBasePattern.Default:
                case SignumBasePattern.Quarter:
                case SignumBasePattern.Quarters_1_4:
                case SignumBasePattern.Quarters_2_3:
                case SignumBasePattern.QuartersDiagonalTopBottom:
                case SignumBasePattern.QuartersDiagonalLeftRight:
                case SignumBasePattern.SplitHorizontalNormal:
                case SignumBasePattern.SplitHorizontalInvert:
                case SignumBasePattern.SplitVerticalLeft:
                case SignumBasePattern.SplitVerticalRight:
                case SignumBasePattern.SliceLeftNormal:
                case SignumBasePattern.SliceLeftInvert:
                case SignumBasePattern.SliceRightNormal:
                case SignumBasePattern.SliceRightInvert:
                    SetParamsAvailable(0);
                    break;
                default:
                    SetParamsAvailable(0); 
                    break;
            }
        }

        private void ColorMain_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var val = (sender as ComboBox)?.SelectedItem as SignumTincture;
            if (val == null)
                return;

            this.ColorSub.Enabled = val.Tincture is ETincture.Ermine or ETincture.Vair;
        }

        private void SetParamsAvailable(int availableParamsCount)
        {
            this.Param1.Enabled = false;
            this.Param2.Enabled = false;
            this.Param3.Enabled = false;

            switch (availableParamsCount)
            {
                case 1:
                    this.Param1.Enabled = true; break;
                case 2:
                    this.Param1.Enabled = true; this.Param2.Enabled = true; break;
                case 3:
                    this.Param1.Enabled = true; this.Param2.Enabled = true; this.Param3.Enabled = true; break;
                default:
                    break;
            }
        }
    }
}