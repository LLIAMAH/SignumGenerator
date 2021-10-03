
namespace SignumGenerator
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSignum = new System.Windows.Forms.GroupBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.tbLayer3Param = new System.Windows.Forms.TextBox();
            this.tbLayer2Param = new System.Windows.Forms.TextBox();
            this.tbLayer1Param = new System.Windows.Forms.TextBox();
            this.cbLayer3Figure = new System.Windows.Forms.ComboBox();
            this.cbLayer3Color = new System.Windows.Forms.ComboBox();
            this.lLayer3 = new System.Windows.Forms.Label();
            this.cbLayer2Figure = new System.Windows.Forms.ComboBox();
            this.cbLayer2Color = new System.Windows.Forms.ComboBox();
            this.lLayer2 = new System.Windows.Forms.Label();
            this.cbLayer1Figure = new System.Windows.Forms.ComboBox();
            this.cbLayer1Color = new System.Windows.Forms.ComboBox();
            this.lLayer1 = new System.Windows.Forms.Label();
            this.lBaseColor = new System.Windows.Forms.Label();
            this.cbColorBase = new System.Windows.Forms.ComboBox();
            this.bnCreateMain = new System.Windows.Forms.Button();
            this.layer1 = new SignumGenerator.Controls.InputControl();
            this.layer2 = new SignumGenerator.Controls.InputControl();
            this.layer3 = new SignumGenerator.Controls.InputControl();
            this.layer4 = new SignumGenerator.Controls.InputControl();
            this.layer5 = new SignumGenerator.Controls.InputControl();
            this.gbSignum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSignum
            // 
            this.gbSignum.Controls.Add(this.pbResult);
            this.gbSignum.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSignum.Location = new System.Drawing.Point(0, 0);
            this.gbSignum.Name = "gbSignum";
            this.gbSignum.Size = new System.Drawing.Size(1667, 1260);
            this.gbSignum.TabIndex = 0;
            this.gbSignum.TabStop = false;
            this.gbSignum.Text = "Signum";
            // 
            // pbResult
            // 
            this.pbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResult.Location = new System.Drawing.Point(3, 27);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(1661, 1230);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.layer5);
            this.gbControls.Controls.Add(this.layer4);
            this.gbControls.Controls.Add(this.layer3);
            this.gbControls.Controls.Add(this.layer2);
            this.gbControls.Controls.Add(this.layer1);
            this.gbControls.Controls.Add(this.tbLayer3Param);
            this.gbControls.Controls.Add(this.tbLayer2Param);
            this.gbControls.Controls.Add(this.tbLayer1Param);
            this.gbControls.Controls.Add(this.cbLayer3Figure);
            this.gbControls.Controls.Add(this.cbLayer3Color);
            this.gbControls.Controls.Add(this.lLayer3);
            this.gbControls.Controls.Add(this.cbLayer2Figure);
            this.gbControls.Controls.Add(this.cbLayer2Color);
            this.gbControls.Controls.Add(this.lLayer2);
            this.gbControls.Controls.Add(this.cbLayer1Figure);
            this.gbControls.Controls.Add(this.cbLayer1Color);
            this.gbControls.Controls.Add(this.lLayer1);
            this.gbControls.Controls.Add(this.lBaseColor);
            this.gbControls.Controls.Add(this.cbColorBase);
            this.gbControls.Controls.Add(this.bnCreateMain);
            this.gbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControls.Location = new System.Drawing.Point(1667, 0);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(1047, 1260);
            this.gbControls.TabIndex = 1;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // tbLayer3Param
            // 
            this.tbLayer3Param.Location = new System.Drawing.Point(548, 152);
            this.tbLayer3Param.Name = "tbLayer3Param";
            this.tbLayer3Param.Size = new System.Drawing.Size(150, 31);
            this.tbLayer3Param.TabIndex = 17;
            this.tbLayer3Param.Text = "0";
            this.tbLayer3Param.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLayer2Param
            // 
            this.tbLayer2Param.Location = new System.Drawing.Point(548, 113);
            this.tbLayer2Param.Name = "tbLayer2Param";
            this.tbLayer2Param.Size = new System.Drawing.Size(150, 31);
            this.tbLayer2Param.TabIndex = 16;
            this.tbLayer2Param.Text = "0";
            this.tbLayer2Param.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLayer1Param
            // 
            this.tbLayer1Param.Location = new System.Drawing.Point(548, 74);
            this.tbLayer1Param.Name = "tbLayer1Param";
            this.tbLayer1Param.Size = new System.Drawing.Size(150, 31);
            this.tbLayer1Param.TabIndex = 15;
            this.tbLayer1Param.Text = "0";
            this.tbLayer1Param.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbLayer3Figure
            // 
            this.cbLayer3Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer3Figure.FormattingEnabled = true;
            this.cbLayer3Figure.Location = new System.Drawing.Point(316, 152);
            this.cbLayer3Figure.Name = "cbLayer3Figure";
            this.cbLayer3Figure.Size = new System.Drawing.Size(226, 33);
            this.cbLayer3Figure.TabIndex = 14;
            // 
            // cbLayer3Color
            // 
            this.cbLayer3Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer3Color.FormattingEnabled = true;
            this.cbLayer3Color.Location = new System.Drawing.Point(164, 152);
            this.cbLayer3Color.Name = "cbLayer3Color";
            this.cbLayer3Color.Size = new System.Drawing.Size(146, 33);
            this.cbLayer3Color.TabIndex = 13;
            // 
            // lLayer3
            // 
            this.lLayer3.AutoSize = true;
            this.lLayer3.Location = new System.Drawing.Point(22, 155);
            this.lLayer3.Name = "lLayer3";
            this.lLayer3.Size = new System.Drawing.Size(68, 25);
            this.lLayer3.TabIndex = 12;
            this.lLayer3.Text = "Layer 3";
            // 
            // cbLayer2Figure
            // 
            this.cbLayer2Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer2Figure.FormattingEnabled = true;
            this.cbLayer2Figure.Location = new System.Drawing.Point(316, 113);
            this.cbLayer2Figure.Name = "cbLayer2Figure";
            this.cbLayer2Figure.Size = new System.Drawing.Size(226, 33);
            this.cbLayer2Figure.TabIndex = 11;
            // 
            // cbLayer2Color
            // 
            this.cbLayer2Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer2Color.FormattingEnabled = true;
            this.cbLayer2Color.Location = new System.Drawing.Point(164, 113);
            this.cbLayer2Color.Name = "cbLayer2Color";
            this.cbLayer2Color.Size = new System.Drawing.Size(146, 33);
            this.cbLayer2Color.TabIndex = 10;
            // 
            // lLayer2
            // 
            this.lLayer2.AutoSize = true;
            this.lLayer2.Location = new System.Drawing.Point(22, 116);
            this.lLayer2.Name = "lLayer2";
            this.lLayer2.Size = new System.Drawing.Size(68, 25);
            this.lLayer2.TabIndex = 9;
            this.lLayer2.Text = "Layer 2";
            // 
            // cbLayer1Figure
            // 
            this.cbLayer1Figure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer1Figure.FormattingEnabled = true;
            this.cbLayer1Figure.Location = new System.Drawing.Point(316, 74);
            this.cbLayer1Figure.Name = "cbLayer1Figure";
            this.cbLayer1Figure.Size = new System.Drawing.Size(226, 33);
            this.cbLayer1Figure.TabIndex = 8;
            // 
            // cbLayer1Color
            // 
            this.cbLayer1Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLayer1Color.FormattingEnabled = true;
            this.cbLayer1Color.Location = new System.Drawing.Point(164, 74);
            this.cbLayer1Color.Name = "cbLayer1Color";
            this.cbLayer1Color.Size = new System.Drawing.Size(146, 33);
            this.cbLayer1Color.TabIndex = 7;
            // 
            // lLayer1
            // 
            this.lLayer1.AutoSize = true;
            this.lLayer1.Location = new System.Drawing.Point(22, 77);
            this.lLayer1.Name = "lLayer1";
            this.lLayer1.Size = new System.Drawing.Size(68, 25);
            this.lLayer1.TabIndex = 6;
            this.lLayer1.Text = "Layer 1";
            // 
            // lBaseColor
            // 
            this.lBaseColor.AutoSize = true;
            this.lBaseColor.Location = new System.Drawing.Point(22, 38);
            this.lBaseColor.Name = "lBaseColor";
            this.lBaseColor.Size = new System.Drawing.Size(112, 25);
            this.lBaseColor.TabIndex = 5;
            this.lBaseColor.Text = "Base tincture";
            // 
            // cbColorBase
            // 
            this.cbColorBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorBase.FormattingEnabled = true;
            this.cbColorBase.Location = new System.Drawing.Point(164, 35);
            this.cbColorBase.Name = "cbColorBase";
            this.cbColorBase.Size = new System.Drawing.Size(146, 33);
            this.cbColorBase.TabIndex = 4;
            // 
            // bnCreateMain
            // 
            this.bnCreateMain.Location = new System.Drawing.Point(21, 204);
            this.bnCreateMain.Name = "bnCreateMain";
            this.bnCreateMain.Size = new System.Drawing.Size(194, 78);
            this.bnCreateMain.TabIndex = 3;
            this.bnCreateMain.Text = "Draw";
            this.bnCreateMain.UseVisualStyleBackColor = true;
            this.bnCreateMain.Click += new System.EventHandler(this.bnCreateMain_Click);
            // 
            // layer1
            // 
            this.layer1.Location = new System.Drawing.Point(21, 403);
            this.layer1.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer1.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer1.Name = "layer1";
            this.layer1.Size = new System.Drawing.Size(860, 84);
            this.layer1.TabIndex = 18;
            // 
            // layer2
            // 
            this.layer2.Location = new System.Drawing.Point(21, 493);
            this.layer2.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer2.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer2.Name = "layer2";
            this.layer2.Size = new System.Drawing.Size(860, 84);
            this.layer2.TabIndex = 19;
            // 
            // layer3
            // 
            this.layer3.Location = new System.Drawing.Point(21, 583);
            this.layer3.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer3.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer3.Name = "layer3";
            this.layer3.Size = new System.Drawing.Size(860, 84);
            this.layer3.TabIndex = 20;
            // 
            // layer4
            // 
            this.layer4.Location = new System.Drawing.Point(22, 673);
            this.layer4.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer4.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer4.Name = "layer4";
            this.layer4.Size = new System.Drawing.Size(860, 84);
            this.layer4.TabIndex = 21;
            // 
            // layer5
            // 
            this.layer5.Location = new System.Drawing.Point(21, 763);
            this.layer5.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer5.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer5.Name = "layer5";
            this.layer5.Size = new System.Drawing.Size(860, 84);
            this.layer5.TabIndex = 22;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2714, 1260);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.gbSignum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignumGenerator";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.gbSignum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignum;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button bnCreateMain;
        private System.Windows.Forms.Label lBaseColor;
        private System.Windows.Forms.ComboBox cbColorBase;
        private System.Windows.Forms.ComboBox cbLayer1Figure;
        private System.Windows.Forms.ComboBox cbLayer1Color;
        private System.Windows.Forms.Label lLayer1;
        private System.Windows.Forms.ComboBox cbLayer3Figure;
        private System.Windows.Forms.ComboBox cbLayer3Color;
        private System.Windows.Forms.Label lLayer3;
        private System.Windows.Forms.ComboBox cbLayer2Figure;
        private System.Windows.Forms.ComboBox cbLayer2Color;
        private System.Windows.Forms.Label lLayer2;
        private System.Windows.Forms.TextBox tbLayer3Param;
        private System.Windows.Forms.TextBox tbLayer2Param;
        private System.Windows.Forms.TextBox tbLayer1Param;
        private Controls.InputControl layer5;
        private Controls.InputControl layer4;
        private Controls.InputControl layer3;
        private Controls.InputControl layer2;
        private Controls.InputControl layer1;
    }
}

