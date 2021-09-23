
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
            this.bnNok = new System.Windows.Forms.Button();
            this.bnBrushTest = new System.Windows.Forms.Button();
            this.bnInitNew = new System.Windows.Forms.Button();
            this.bnCreateMain = new System.Windows.Forms.Button();
            this.bnCreateShield = new System.Windows.Forms.Button();
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
            this.gbSignum.Size = new System.Drawing.Size(2190, 1260);
            this.gbSignum.TabIndex = 0;
            this.gbSignum.TabStop = false;
            this.gbSignum.Text = "Signum";
            // 
            // pbResult
            // 
            this.pbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResult.Location = new System.Drawing.Point(3, 27);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(2184, 1230);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResult.TabIndex = 0;
            this.pbResult.TabStop = false;
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.bnCreateShield);
            this.gbControls.Controls.Add(this.bnCreateMain);
            this.gbControls.Controls.Add(this.bnNok);
            this.gbControls.Controls.Add(this.bnBrushTest);
            this.gbControls.Controls.Add(this.bnInitNew);
            this.gbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControls.Location = new System.Drawing.Point(2190, 0);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(524, 1260);
            this.gbControls.TabIndex = 1;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // bnNok
            // 
            this.bnNok.Location = new System.Drawing.Point(43, 132);
            this.bnNok.Name = "bnNok";
            this.bnNok.Size = new System.Drawing.Size(112, 34);
            this.bnNok.TabIndex = 2;
            this.bnNok.Text = "button1";
            this.bnNok.UseVisualStyleBackColor = true;
            this.bnNok.Click += new System.EventHandler(this.bnNok_Click);
            // 
            // bnBrushTest
            // 
            this.bnBrushTest.Location = new System.Drawing.Point(43, 92);
            this.bnBrushTest.Name = "bnBrushTest";
            this.bnBrushTest.Size = new System.Drawing.Size(112, 34);
            this.bnBrushTest.TabIndex = 1;
            this.bnBrushTest.Text = "Brush test";
            this.bnBrushTest.UseVisualStyleBackColor = true;
            this.bnBrushTest.Click += new System.EventHandler(this.bnBrushTest_Click);
            // 
            // bnInitNew
            // 
            this.bnInitNew.Location = new System.Drawing.Point(43, 52);
            this.bnInitNew.Name = "bnInitNew";
            this.bnInitNew.Size = new System.Drawing.Size(112, 34);
            this.bnInitNew.TabIndex = 0;
            this.bnInitNew.Text = "New";
            this.bnInitNew.UseVisualStyleBackColor = true;
            this.bnInitNew.Click += new System.EventHandler(this.bnInitNew_Click);
            // 
            // bnCreateMain
            // 
            this.bnCreateMain.Location = new System.Drawing.Point(279, 74);
            this.bnCreateMain.Name = "bnCreateMain";
            this.bnCreateMain.Size = new System.Drawing.Size(112, 34);
            this.bnCreateMain.TabIndex = 3;
            this.bnCreateMain.Text = "Main";
            this.bnCreateMain.UseVisualStyleBackColor = true;
            this.bnCreateMain.Click += new System.EventHandler(this.bnCreateMain_Click);
            // 
            // bnCreateShield
            // 
            this.bnCreateShield.Location = new System.Drawing.Point(279, 114);
            this.bnCreateShield.Name = "bnCreateShield";
            this.bnCreateShield.Size = new System.Drawing.Size(112, 34);
            this.bnCreateShield.TabIndex = 4;
            this.bnCreateShield.Text = "Shield";
            this.bnCreateShield.UseVisualStyleBackColor = true;
            this.bnCreateShield.Click += new System.EventHandler(this.bnCreateShield_Click);
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
            this.gbSignum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.gbControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignum;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button bnInitNew;
        private System.Windows.Forms.Button bnBrushTest;
        private System.Windows.Forms.Button bnNok;
        private System.Windows.Forms.Button bnCreateShield;
        private System.Windows.Forms.Button bnCreateMain;
    }
}

