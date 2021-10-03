
namespace SignumGenerator.Controls
{
    partial class InputControl
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
            this.tbLayer1Param = new System.Windows.Forms.TextBox();
            this.cbLayer1Figure = new System.Windows.Forms.ComboBox();
            this.cbLayer1Color = new System.Windows.Forms.ComboBox();
            this.lLayer1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbLayer1Param
            // 
            this.tbLayer1Param.Location = new System.Drawing.Point(607, 3);
            this.tbLayer1Param.Name = "tbLayer1Param";
            this.tbLayer1Param.Size = new System.Drawing.Size(76, 31);
            this.tbLayer1Param.TabIndex = 19;
            this.tbLayer1Param.Text = "0";
            this.tbLayer1Param.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbLayer1Figure
            // 
            this.cbLayer1Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer1Figure.FormattingEnabled = true;
            this.cbLayer1Figure.Location = new System.Drawing.Point(223, 3);
            this.cbLayer1Figure.Name = "cbLayer1Figure";
            this.cbLayer1Figure.Size = new System.Drawing.Size(226, 33);
            this.cbLayer1Figure.TabIndex = 18;
            // 
            // cbLayer1Color
            // 
            this.cbLayer1Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer1Color.FormattingEnabled = true;
            this.cbLayer1Color.Location = new System.Drawing.Point(455, 3);
            this.cbLayer1Color.Name = "cbLayer1Color";
            this.cbLayer1Color.Size = new System.Drawing.Size(146, 33);
            this.cbLayer1Color.TabIndex = 17;
            // 
            // lLayer1
            // 
            this.lLayer1.AutoSize = true;
            this.lLayer1.Location = new System.Drawing.Point(20, 6);
            this.lLayer1.Name = "lLayer1";
            this.lLayer1.Size = new System.Drawing.Size(68, 25);
            this.lLayer1.TabIndex = 16;
            this.lLayer1.Text = "Layer 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(771, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 31);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(455, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 33);
            this.comboBox1.TabIndex = 22;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbLayer1Param);
            this.Controls.Add(this.cbLayer1Figure);
            this.Controls.Add(this.cbLayer1Color);
            this.Controls.Add(this.lLayer1);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(894, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLayer1Param;
        private System.Windows.Forms.ComboBox cbLayer1Figure;
        private System.Windows.Forms.ComboBox cbLayer1Color;
        private System.Windows.Forms.Label lLayer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
