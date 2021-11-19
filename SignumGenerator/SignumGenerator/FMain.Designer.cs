
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
            this.bnSaveToFile = new System.Windows.Forms.Button();
            this.bnDraw = new System.Windows.Forms.Button();
            this.layerBase = new SignumGenerator.Controls.InputControlBase();
            this.layer5 = new SignumGenerator.Controls.InputControlLayer();
            this.layer4 = new SignumGenerator.Controls.InputControlLayer();
            this.layer3 = new SignumGenerator.Controls.InputControlLayer();
            this.layer2 = new SignumGenerator.Controls.InputControlLayer();
            this.layer1 = new SignumGenerator.Controls.InputControlLayer();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
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
            this.gbControls.Controls.Add(this.button1);
            this.gbControls.Controls.Add(this.bnSaveToFile);
            this.gbControls.Controls.Add(this.bnDraw);
            this.gbControls.Controls.Add(this.layerBase);
            this.gbControls.Controls.Add(this.layer5);
            this.gbControls.Controls.Add(this.layer4);
            this.gbControls.Controls.Add(this.layer3);
            this.gbControls.Controls.Add(this.layer2);
            this.gbControls.Controls.Add(this.layer1);
            this.gbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControls.Location = new System.Drawing.Point(1667, 0);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(906, 1260);
            this.gbControls.TabIndex = 1;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // bnSaveToFile
            // 
            this.bnSaveToFile.Location = new System.Drawing.Point(20, 549);
            this.bnSaveToFile.Name = "bnSaveToFile";
            this.bnSaveToFile.Size = new System.Drawing.Size(194, 78);
            this.bnSaveToFile.TabIndex = 25;
            this.bnSaveToFile.Text = "Save...";
            this.bnSaveToFile.UseVisualStyleBackColor = true;
            this.bnSaveToFile.Click += new System.EventHandler(this.bnSaveToFile_Click);
            // 
            // bnDraw
            // 
            this.bnDraw.Location = new System.Drawing.Point(686, 549);
            this.bnDraw.Name = "bnDraw";
            this.bnDraw.Size = new System.Drawing.Size(194, 78);
            this.bnDraw.TabIndex = 24;
            this.bnDraw.Text = "Draw";
            this.bnDraw.UseVisualStyleBackColor = true;
            this.bnDraw.Click += new System.EventHandler(this.bnDraw_Click);
            // 
            // layerBase
            // 
            this.layerBase.Location = new System.Drawing.Point(19, 51);
            this.layerBase.MaximumSize = new System.Drawing.Size(595, 42);
            this.layerBase.MinimumSize = new System.Drawing.Size(595, 42);
            this.layerBase.Name = "layerBase";
            this.layerBase.Size = new System.Drawing.Size(595, 42);
            this.layerBase.TabIndex = 23;
            // 
            // layer5
            // 
            this.layer5.Location = new System.Drawing.Point(19, 459);
            this.layer5.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer5.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer5.Name = "layer5";
            this.layer5.Size = new System.Drawing.Size(860, 84);
            this.layer5.TabIndex = 22;
            // 
            // layer4
            // 
            this.layer4.Location = new System.Drawing.Point(20, 369);
            this.layer4.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer4.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer4.Name = "layer4";
            this.layer4.Size = new System.Drawing.Size(860, 84);
            this.layer4.TabIndex = 21;
            // 
            // layer3
            // 
            this.layer3.Location = new System.Drawing.Point(19, 279);
            this.layer3.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer3.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer3.Name = "layer3";
            this.layer3.Size = new System.Drawing.Size(860, 84);
            this.layer3.TabIndex = 20;
            // 
            // layer2
            // 
            this.layer2.Location = new System.Drawing.Point(19, 189);
            this.layer2.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer2.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer2.Name = "layer2";
            this.layer2.Size = new System.Drawing.Size(860, 84);
            this.layer2.TabIndex = 19;
            // 
            // layer1
            // 
            this.layer1.Location = new System.Drawing.Point(19, 99);
            this.layer1.MaximumSize = new System.Drawing.Size(860, 84);
            this.layer1.MinimumSize = new System.Drawing.Size(860, 84);
            this.layer1.Name = "layer1";
            this.layer1.Size = new System.Drawing.Size(860, 84);
            this.layer1.TabIndex = 18;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "*.png";
            this.dlgSaveFile.FileName = "Signum";
            this.dlgSaveFile.Filter = "Images|*.png";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 789);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2573, 1260);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSignum;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.PictureBox pbResult;
        private Controls.InputControlLayer layer5;
        private Controls.InputControlLayer layer4;
        private Controls.InputControlLayer layer3;
        private Controls.InputControlLayer layer2;
        private Controls.InputControlLayer layer1;
        private Controls.InputControlBase layerBase;
        private System.Windows.Forms.Button bnDraw;
        private System.Windows.Forms.Button bnSaveToFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.Button button1;
    }
}

