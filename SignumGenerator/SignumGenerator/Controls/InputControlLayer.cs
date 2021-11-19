using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SignumLib.Helpers;
using SignumLib.Tincture;

namespace SignumGenerator.Controls
{
    public partial class InputControlLayer : UserControl
    {
        public InputControlLayer()
        {
            InitializeComponent();
        }

        public void SetParams(string title, List<string> figuresList, List<SignumTincture> tincturesListFull, List<SignumTincture> tincturesListShort)
        {
            this.Title.Text = title;
            foreach (var figure in figuresList)
                this.Figure.Items.Add(figure);

            foreach (var tincture in tincturesListFull)
                this.ColorMain.Items.Add(tincture);

            foreach (var tincture in tincturesListShort)
            {
                this.ColorSub.Items.Add(tincture);
                this.ColorBG.Items.Add(tincture);
            }

            this.Figure.SelectedIndex = 0;
            this.ColorMain.SelectedIndex = 0;
            this.ColorMain.DisplayMember = "TinctureName";
            this.ColorMain.ValueMember = "Tincture";
            this.ColorSub.SelectedIndex = 0;
            this.ColorSub.DisplayMember = "TinctureName";
            this.ColorSub.ValueMember = "Tincture";
            this.ColorBG.SelectedIndex = 0;
            this.ColorBG.DisplayMember = "TinctureName";
            this.ColorBG.ValueMember = "Tincture";
        }

        private void Figure_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            var val = Enum.Parse<SignumBasePattern>(cb?.SelectedItem?.ToString()!);
            switch (val)
            {
                case SignumBasePattern.SimpleBar:
                case SignumBasePattern.SimpleBillet:
                case SignumBasePattern.SimplePile:
                    SetParamsAvailable(1, "Percent");
                    break;
                case SignumBasePattern.StripesHorizontal:
                case SignumBasePattern.StripesVertical:
                case SignumBasePattern.StripesPal:
                case SignumBasePattern.StripesBar:
                    SetParamsAvailable(1, "Count");
                    break;
                case SignumBasePattern.HonoraryHead: 
                case SignumBasePattern.HonoraryBelt:
                case SignumBasePattern.HonoraryEnd:
                case SignumBasePattern.HonoraryPalNormal:
                case SignumBasePattern.HonoraryPalTight:
                // ReSharper disable once IdentifierTypo
                case SignumBasePattern.HonoraryFlancLeft:
                // ReSharper disable once IdentifierTypo
                case SignumBasePattern.HonoraryFlancRight:
                case SignumBasePattern.HonorarySlingLeft:
                case SignumBasePattern.HonorarySlingRight:
                    SetParamsAvailable(1, "Width");
                    break;
                case SignumBasePattern.CheckersNormal:
                case SignumBasePattern.CheckersInverse:
                case SignumBasePattern.CheckersDiagonal:
                    SetParamsAvailable(1, "Size");
                    break;
                case SignumBasePattern.ChevronMiddleNormal:
                case SignumBasePattern.ChevronMiddleInvert:
                case SignumBasePattern.ChevronFullNormal:
                case SignumBasePattern.ChevronFullInvert:
                    SetParamsAvailable(1, "Width");
                    break;
                case SignumBasePattern.ChevronPointOffsetSizeNormal:
                case SignumBasePattern.ChevronPointOffsetSizeInvert:
                    SetParamsAvailable(3, "Width", "Position", "Offset");
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
            if ((sender as ComboBox)?.SelectedItem is not SignumTincture val)
                return;

            this.ColorBG.Enabled = this.ColorSub.Enabled = val.IsFur;
        }

        private void SetParamsAvailable(int availableParamsCount, string title1 = "", string title2 = "", string title3 = "")
        {
            this.Param1.Enabled = false;
            this.Param2.Enabled = false;
            this.Param3.Enabled = false;
            this.Param1Title.Text = string.Empty;
            this.Param2Title.Text = string.Empty;
            this.Param3Title.Text = string.Empty;

            switch (availableParamsCount)
            {
                case 1:
                    this.Param1.Enabled = true;
                    this.Param1Title.Text = title1;
                    break;
                case 2:
                    this.Param1.Enabled = true; this.Param2.Enabled = true;
                    this.Param1Title.Text = title1; this.Param2Title.Text = title2;
                    break;
                case 3:
                    this.Param1.Enabled = true; this.Param2.Enabled = true; this.Param3.Enabled = true;
                    this.Param1Title.Text = title1; this.Param2Title.Text = title2; this.Param3Title.Text = title3;
                    break;
                default:
                    break;
            }
        }

        public InputLayerData GetInput()
        {
            var pattern = Enum.Parse<SignumBasePattern>(Figure.SelectedItem?.ToString()!);
            var colorMain = ColorMain.SelectedItem as SignumTincture;
            var colorSub = ColorSub.SelectedItem as SignumTincture;
            var colorBg = ColorBG.SelectedItem as SignumTincture;

            int? param1 = Param1.Enabled && !string.IsNullOrEmpty(Param1.Text)
                ? Convert.ToInt32(Param1.Text)
                : null;
            int? param2 = Param2.Enabled && !string.IsNullOrEmpty(Param2.Text)
                ? Convert.ToInt32(Param2.Text)
                : null;
            int? param3 = Param3.Enabled && !string.IsNullOrEmpty(Param3.Text)
                ? Convert.ToInt32(Param3.Text)
                : null;

            return new InputLayerData(pattern,
                colorMain, colorSub, colorBg,
                param1, param2, param3);
        }
    }
}