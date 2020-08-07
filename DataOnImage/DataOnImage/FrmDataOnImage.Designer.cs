namespace DataOnImage
{
    partial class FrmDataOnImage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnWriteTextDataOnImage = new System.Windows.Forms.Button();
            this.btnReadTextDataFromImage = new System.Windows.Forms.Button();
            this.btnSowOpenDialog = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.txtAddThisSuffix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReadFileDataFromImage = new System.Windows.Forms.Button();
            this.btnWriteFileDataOnImage = new System.Windows.Forms.Button();
            this.btnCalculateNeededMegaPixelForText = new System.Windows.Forms.Button();
            this.lblNeededMegaPixel = new System.Windows.Forms.Label();
            this.btnReadDataFromImageAutoDetect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxData = new System.Windows.Forms.RichTextBox();
            this.lblImageMegaPixel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(390, 4);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenImage.TabIndex = 0;
            this.btnOpenImage.Text = "OpenImage";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(79, 6);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(270, 21);
            this.txtImagePath.TabIndex = 1;
            this.txtImagePath.Text = "C:\\Users\\Public\\Pictures\\Sample Pictures\\Chrysanthemum.jpg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Path";
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.Location = new System.Drawing.Point(12, 214);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(462, 16);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnWriteTextDataOnImage
            // 
            this.btnWriteTextDataOnImage.Location = new System.Drawing.Point(15, 42);
            this.btnWriteTextDataOnImage.Name = "btnWriteTextDataOnImage";
            this.btnWriteTextDataOnImage.Size = new System.Drawing.Size(190, 23);
            this.btnWriteTextDataOnImage.TabIndex = 4;
            this.btnWriteTextDataOnImage.Text = "Write Text Data On Image";
            this.btnWriteTextDataOnImage.UseVisualStyleBackColor = true;
            this.btnWriteTextDataOnImage.Click += new System.EventHandler(this.btnWriteDataOnImage_Click);
            // 
            // btnReadTextDataFromImage
            // 
            this.btnReadTextDataFromImage.Location = new System.Drawing.Point(74, 30);
            this.btnReadTextDataFromImage.Name = "btnReadTextDataFromImage";
            this.btnReadTextDataFromImage.Size = new System.Drawing.Size(190, 23);
            this.btnReadTextDataFromImage.TabIndex = 4;
            this.btnReadTextDataFromImage.Text = "Read Text Data From Image";
            this.btnReadTextDataFromImage.UseVisualStyleBackColor = true;
            this.btnReadTextDataFromImage.Click += new System.EventHandler(this.btnReadTextDataFromImage_Click);
            // 
            // btnSowOpenDialog
            // 
            this.btnSowOpenDialog.Location = new System.Drawing.Point(355, 4);
            this.btnSowOpenDialog.Name = "btnSowOpenDialog";
            this.btnSowOpenDialog.Size = new System.Drawing.Size(29, 23);
            this.btnSowOpenDialog.TabIndex = 6;
            this.btnSowOpenDialog.Text = "...";
            this.btnSowOpenDialog.UseVisualStyleBackColor = true;
            this.btnSowOpenDialog.Click += new System.EventHandler(this.btnSowOpenDialog_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(193, 185);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 7;
            this.btnSaveImage.Text = "SaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // txtAddThisSuffix
            // 
            this.txtAddThisSuffix.Location = new System.Drawing.Point(101, 187);
            this.txtAddThisSuffix.Name = "txtAddThisSuffix";
            this.txtAddThisSuffix.Size = new System.Drawing.Size(69, 21);
            this.txtAddThisSuffix.TabIndex = 8;
            this.txtAddThisSuffix.Text = "_WithData";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Add This Suffix";
            // 
            // btnReadFileDataFromImage
            // 
            this.btnReadFileDataFromImage.Location = new System.Drawing.Point(74, 59);
            this.btnReadFileDataFromImage.Name = "btnReadFileDataFromImage";
            this.btnReadFileDataFromImage.Size = new System.Drawing.Size(217, 23);
            this.btnReadFileDataFromImage.TabIndex = 10;
            this.btnReadFileDataFromImage.Text = "Read File Data From Image";
            this.btnReadFileDataFromImage.UseVisualStyleBackColor = true;
            this.btnReadFileDataFromImage.Click += new System.EventHandler(this.btnReadFileDataFromImage_Click);
            // 
            // btnWriteFileDataOnImage
            // 
            this.btnWriteFileDataOnImage.Location = new System.Drawing.Point(224, 42);
            this.btnWriteFileDataOnImage.Name = "btnWriteFileDataOnImage";
            this.btnWriteFileDataOnImage.Size = new System.Drawing.Size(217, 23);
            this.btnWriteFileDataOnImage.TabIndex = 11;
            this.btnWriteFileDataOnImage.Text = "Write File Data On Image";
            this.btnWriteFileDataOnImage.UseVisualStyleBackColor = true;
            this.btnWriteFileDataOnImage.Click += new System.EventHandler(this.btnWriteFileDataOnImage_Click);
            // 
            // btnCalculateNeededMegaPixelForText
            // 
            this.btnCalculateNeededMegaPixelForText.Location = new System.Drawing.Point(376, 98);
            this.btnCalculateNeededMegaPixelForText.Name = "btnCalculateNeededMegaPixelForText";
            this.btnCalculateNeededMegaPixelForText.Size = new System.Drawing.Size(89, 52);
            this.btnCalculateNeededMegaPixelForText.TabIndex = 12;
            this.btnCalculateNeededMegaPixelForText.Text = "Calculate Needed Mega Pixel For Text";
            this.btnCalculateNeededMegaPixelForText.UseVisualStyleBackColor = true;
            this.btnCalculateNeededMegaPixelForText.Click += new System.EventHandler(this.btnCalculateNeededMegaPixel_Click);
            // 
            // lblNeededMegaPixel
            // 
            this.lblNeededMegaPixel.AutoSize = true;
            this.lblNeededMegaPixel.Location = new System.Drawing.Point(373, 153);
            this.lblNeededMegaPixel.Name = "lblNeededMegaPixel";
            this.lblNeededMegaPixel.Size = new System.Drawing.Size(15, 13);
            this.lblNeededMegaPixel.TabIndex = 13;
            this.lblNeededMegaPixel.Text = "--";
            // 
            // btnReadDataFromImageAutoDetect
            // 
            this.btnReadDataFromImageAutoDetect.Location = new System.Drawing.Point(15, 71);
            this.btnReadDataFromImageAutoDetect.Name = "btnReadDataFromImageAutoDetect";
            this.btnReadDataFromImageAutoDetect.Size = new System.Drawing.Size(423, 23);
            this.btnReadDataFromImageAutoDetect.TabIndex = 14;
            this.btnReadDataFromImageAutoDetect.Text = "Read Data From Image (Automatically Detect Text And File Mode)";
            this.btnReadDataFromImageAutoDetect.UseVisualStyleBackColor = true;
            this.btnReadDataFromImageAutoDetect.Click += new System.EventHandler(this.btnReadDataFromImageAutoDetect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReadTextDataFromImage);
            this.panel1.Controls.Add(this.btnReadFileDataFromImage);
            this.panel1.Location = new System.Drawing.Point(471, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 29);
            this.panel1.TabIndex = 15;
            // 
            // rtxData
            // 
            this.rtxData.Location = new System.Drawing.Point(15, 100);
            this.rtxData.Name = "rtxData";
            this.rtxData.Size = new System.Drawing.Size(352, 79);
            this.rtxData.TabIndex = 16;
            this.rtxData.Text = "hello there";
            // 
            // lblImageMegaPixel
            // 
            this.lblImageMegaPixel.AutoSize = true;
            this.lblImageMegaPixel.Location = new System.Drawing.Point(374, 166);
            this.lblImageMegaPixel.Name = "lblImageMegaPixel";
            this.lblImageMegaPixel.Size = new System.Drawing.Size(15, 13);
            this.lblImageMegaPixel.TabIndex = 13;
            this.lblImageMegaPixel.Text = "--";
            // 
            // FrmDataOnImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 242);
            this.Controls.Add(this.rtxData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReadDataFromImageAutoDetect);
            this.Controls.Add(this.lblImageMegaPixel);
            this.Controls.Add(this.lblNeededMegaPixel);
            this.Controls.Add(this.btnCalculateNeededMegaPixelForText);
            this.Controls.Add(this.btnWriteFileDataOnImage);
            this.Controls.Add(this.txtAddThisSuffix);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnSowOpenDialog);
            this.Controls.Add(this.btnWriteTextDataOnImage);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnOpenImage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmDataOnImage";
            this.Text = "Data On Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnWriteTextDataOnImage;
        private System.Windows.Forms.Button btnReadTextDataFromImage;
        private System.Windows.Forms.Button btnSowOpenDialog;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TextBox txtAddThisSuffix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReadFileDataFromImage;
        private System.Windows.Forms.Button btnWriteFileDataOnImage;
        private System.Windows.Forms.Button btnCalculateNeededMegaPixelForText;
        private System.Windows.Forms.Label lblNeededMegaPixel;
        private System.Windows.Forms.Button btnReadDataFromImageAutoDetect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxData;
        private System.Windows.Forms.Label lblImageMegaPixel;
    }
}

