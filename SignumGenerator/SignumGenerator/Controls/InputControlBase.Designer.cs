
namespace SignumGenerator.Controls
{
    partial class InputControlBase
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
            this.ColorBase = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.ColorSub = new System.Windows.Forms.ComboBox();
            this.ColorBG = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ColorBase
            // 
            this.ColorBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBase.FormattingEnabled = true;
            this.ColorBase.Location = new System.Drawing.Point(223, 3);
            this.ColorBase.Name = "ColorBase";
            this.ColorBase.Size = new System.Drawing.Size(116, 33);
            this.ColorBase.TabIndex = 20;
            this.ColorBase.SelectedIndexChanged += new System.EventHandler(this.ColorBase_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(20, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(68, 25);
            this.Title.TabIndex = 19;
            this.Title.Text = "Layer 1";
            // 
            // ColorSub
            // 
            this.ColorSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSub.FormattingEnabled = true;
            this.ColorSub.Location = new System.Drawing.Point(345, 3);
            this.ColorSub.Name = "ColorSub";
            this.ColorSub.Size = new System.Drawing.Size(116, 33);
            this.ColorSub.TabIndex = 21;
            // 
            // ColorBG
            // 
            this.ColorBG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBG.FormattingEnabled = true;
            this.ColorBG.Location = new System.Drawing.Point(467, 3);
            this.ColorBG.Name = "ColorBG";
            this.ColorBG.Size = new System.Drawing.Size(116, 33);
            this.ColorBG.TabIndex = 22;
            // 
            // InputControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorBG);
            this.Controls.Add(this.ColorSub);
            this.Controls.Add(this.ColorBase);
            this.Controls.Add(this.Title);
            this.MaximumSize = new System.Drawing.Size(595, 42);
            this.MinimumSize = new System.Drawing.Size(595, 42);
            this.Name = "InputControlBase";
            this.Size = new System.Drawing.Size(595, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorBase;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox ColorSub;
        private System.Windows.Forms.ComboBox ColorBG;
    }
}
