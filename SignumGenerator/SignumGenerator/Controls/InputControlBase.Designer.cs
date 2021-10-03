
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
            this.SuspendLayout();
            // 
            // ColorBase
            // 
            this.ColorBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorBase.FormattingEnabled = true;
            this.ColorBase.Location = new System.Drawing.Point(223, 3);
            this.ColorBase.Name = "ColorBase";
            this.ColorBase.Size = new System.Drawing.Size(146, 33);
            this.ColorBase.TabIndex = 20;
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
            // InputControlBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ColorBase);
            this.Controls.Add(this.Title);
            this.MaximumSize = new System.Drawing.Size(382, 42);
            this.MinimumSize = new System.Drawing.Size(382, 42);
            this.Name = "InputControlBase";
            this.Size = new System.Drawing.Size(382, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorBase;
        private System.Windows.Forms.Label Title;
    }
}
