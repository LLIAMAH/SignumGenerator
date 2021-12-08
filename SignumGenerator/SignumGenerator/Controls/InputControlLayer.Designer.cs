
namespace SignumGenerator.Controls
{
    partial class InputControlLayer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Param1 = new System.Windows.Forms.TextBox();
            this.Figure = new System.Windows.Forms.ComboBox();
            this.ColorMain = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.Param2 = new System.Windows.Forms.TextBox();
            this.Param3 = new System.Windows.Forms.TextBox();
            this.ColorSub = new System.Windows.Forms.ComboBox();
            this.Param1Title = new System.Windows.Forms.Label();
            this.Param2Title = new System.Windows.Forms.Label();
            this.Param3Title = new System.Windows.Forms.Label();
            this.ColorBG = new System.Windows.Forms.ComboBox();
            this.Param4Title = new System.Windows.Forms.Label();
            this.StepBG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Param1
            // 
            this.Param1.Location = new System.Drawing.Point(595, 41);
            this.Param1.Name = "Param1";
            this.Param1.Size = new System.Drawing.Size(76, 31);
            this.Param1.TabIndex = 19;
            this.Param1.Text = "0";
            this.Param1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Figure
            // 
            this.Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Figure.FormattingEnabled = true;
            this.Figure.Location = new System.Drawing.Point(223, 3);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(360, 33);
            this.Figure.TabIndex = 18;
            this.Figure.SelectedIndexChanged += new System.EventHandler(this.Figure_SelectedIndexChanged);
            // 
            // ColorMain
            // 
            this.ColorMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorMain.FormattingEnabled = true;
            this.ColorMain.Location = new System.Drawing.Point(223, 42);
            this.ColorMain.Name = "ColorMain";
            this.ColorMain.Size = new System.Drawing.Size(116, 33);
            this.ColorMain.TabIndex = 17;
            this.ColorMain.SelectedIndexChanged += new System.EventHandler(this.ColorMain_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(20, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(68, 25);
            this.Title.TabIndex = 16;
            this.Title.Text = "Layer 1";
            // 
            // Param2
            // 
            this.Param2.Location = new System.Drawing.Point(677, 41);
            this.Param2.Name = "Param2";
            this.Param2.Size = new System.Drawing.Size(76, 31);
            this.Param2.TabIndex = 20;
            this.Param2.Text = "0";
            this.Param2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Param3
            // 
            this.Param3.Location = new System.Drawing.Point(759, 41);
            this.Param3.Name = "Param3";
            this.Param3.Size = new System.Drawing.Size(76, 31);
            this.Param3.TabIndex = 21;
            this.Param3.Text = "0";
            this.Param3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ColorSub
            // 
            this.ColorSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSub.FormattingEnabled = true;
            this.ColorSub.Location = new System.Drawing.Point(345, 42);
            this.ColorSub.Name = "ColorSub";
            this.ColorSub.Size = new System.Drawing.Size(116, 33);
            this.ColorSub.TabIndex = 22;
            // 
            // Param1Title
            // 
            this.Param1Title.AutoSize = true;
            this.Param1Title.Location = new System.Drawing.Point(596, 13);
            this.Param1Title.Name = "Param1Title";
            this.Param1Title.Size = new System.Drawing.Size(59, 25);
            this.Param1Title.TabIndex = 23;
            this.Param1Title.Text = "label1";
            // 
            // Param2Title
            // 
            this.Param2Title.AutoSize = true;
            this.Param2Title.Location = new System.Drawing.Point(677, 13);
            this.Param2Title.Name = "Param2Title";
            this.Param2Title.Size = new System.Drawing.Size(59, 25);
            this.Param2Title.TabIndex = 24;
            this.Param2Title.Text = "label2";
            // 
            // Param3Title
            // 
            this.Param3Title.AutoSize = true;
            this.Param3Title.Location = new System.Drawing.Point(759, 13);
            this.Param3Title.Name = "Param3Title";
            this.Param3Title.Size = new System.Drawing.Size(59, 25);
            this.Param3Title.TabIndex = 25;
            this.Param3Title.Text = "label3";
            // 
            // ColorBG
            // 
            this.ColorBG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBG.FormattingEnabled = true;
            this.ColorBG.Location = new System.Drawing.Point(467, 42);
            this.ColorBG.Name = "ColorBG";
            this.ColorBG.Size = new System.Drawing.Size(116, 33);
            this.ColorBG.TabIndex = 26;
            // 
            // Param4Title
            // 
            this.Param4Title.AutoSize = true;
            this.Param4Title.Location = new System.Drawing.Point(841, 13);
            this.Param4Title.Name = "Param4Title";
            this.Param4Title.Size = new System.Drawing.Size(68, 25);
            this.Param4Title.TabIndex = 28;
            this.Param4Title.Text = "BG size";
            // 
            // StepBG
            // 
            this.StepBG.Location = new System.Drawing.Point(841, 41);
            this.StepBG.Name = "StepBG";
            this.StepBG.Size = new System.Drawing.Size(76, 31);
            this.StepBG.TabIndex = 27;
            this.StepBG.Text = "0";
            this.StepBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputControlLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Param4Title);
            this.Controls.Add(this.StepBG);
            this.Controls.Add(this.ColorBG);
            this.Controls.Add(this.Param3Title);
            this.Controls.Add(this.Param2Title);
            this.Controls.Add(this.Param1Title);
            this.Controls.Add(this.ColorSub);
            this.Controls.Add(this.Param3);
            this.Controls.Add(this.Param2);
            this.Controls.Add(this.Param1);
            this.Controls.Add(this.Figure);
            this.Controls.Add(this.ColorMain);
            this.Controls.Add(this.Title);
            this.MaximumSize = new System.Drawing.Size(1000, 84);
            this.MinimumSize = new System.Drawing.Size(860, 84);
            this.Name = "InputControlLayer";
            this.Size = new System.Drawing.Size(927, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Param1;
        private System.Windows.Forms.ComboBox Figure;
        private System.Windows.Forms.ComboBox ColorMain;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Param2;
        private System.Windows.Forms.TextBox Param3;
        private System.Windows.Forms.ComboBox ColorSub;
        private System.Windows.Forms.Label Param1Title;
        private System.Windows.Forms.Label Param2Title;
        private System.Windows.Forms.Label Param3Title;
        private System.Windows.Forms.ComboBox ColorBG;
        private System.Windows.Forms.Label Param4Title;
        private System.Windows.Forms.TextBox StepBG;
    }
}
