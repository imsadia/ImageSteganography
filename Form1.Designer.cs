namespace VP_Project
{
    partial class mainForm
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
            this.groupBoxBrowseFiles = new System.Windows.Forms.GroupBox();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.btnImgBrowse = new System.Windows.Forms.Button();
            this.tbFileBrowse = new System.Windows.Forms.TextBox();
            this.tbImgBrowse = new System.Windows.Forms.TextBox();
            this.groupBoxImgPreview = new System.Windows.Forms.GroupBox();
            this.groupBoxImgInfo = new System.Windows.Forms.GroupBox();
            this.lblImgPixels = new System.Windows.Forms.Label();
            this.lblImgSize = new System.Windows.Forms.Label();
            this.lblImgWidth = new System.Windows.Forms.Label();
            this.lblImgHeight = new System.Windows.Forms.Label();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.pbDisplayImage = new System.Windows.Forms.PictureBox();
            this.gbTextFile = new System.Windows.Forms.GroupBox();
            this.rtbTextFile = new System.Windows.Forms.RichTextBox();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbPixels = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.groupBoxBrowseFiles.SuspendLayout();
            this.groupBoxImgPreview.SuspendLayout();
            this.groupBoxImgInfo.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayImage)).BeginInit();
            this.gbTextFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBrowseFiles
            // 
            this.groupBoxBrowseFiles.Controls.Add(this.btnFileBrowse);
            this.groupBoxBrowseFiles.Controls.Add(this.btnImgBrowse);
            this.groupBoxBrowseFiles.Controls.Add(this.tbFileBrowse);
            this.groupBoxBrowseFiles.Controls.Add(this.tbImgBrowse);
            this.groupBoxBrowseFiles.ForeColor = System.Drawing.Color.White;
            this.groupBoxBrowseFiles.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBrowseFiles.Name = "groupBoxBrowseFiles";
            this.groupBoxBrowseFiles.Size = new System.Drawing.Size(656, 85);
            this.groupBoxBrowseFiles.TabIndex = 0;
            this.groupBoxBrowseFiles.TabStop = false;
            this.groupBoxBrowseFiles.Text = "Browse Files";
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileBrowse.Location = new System.Drawing.Point(513, 49);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(137, 23);
            this.btnFileBrowse.TabIndex = 3;
            this.btnFileBrowse.Text = "Choose File";
            this.btnFileBrowse.UseVisualStyleBackColor = false;
            this.btnFileBrowse.Click += new System.EventHandler(this.BtnFileBrowse_Click);
            // 
            // btnImgBrowse
            // 
            this.btnImgBrowse.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnImgBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImgBrowse.Location = new System.Drawing.Point(513, 17);
            this.btnImgBrowse.Name = "btnImgBrowse";
            this.btnImgBrowse.Size = new System.Drawing.Size(137, 23);
            this.btnImgBrowse.TabIndex = 2;
            this.btnImgBrowse.Text = "Choose Image";
            this.btnImgBrowse.UseVisualStyleBackColor = false;
            this.btnImgBrowse.Click += new System.EventHandler(this.BtnImgBrowse_Click);
            // 
            // tbFileBrowse
            // 
            this.tbFileBrowse.Location = new System.Drawing.Point(7, 51);
            this.tbFileBrowse.Name = "tbFileBrowse";
            this.tbFileBrowse.Size = new System.Drawing.Size(500, 20);
            this.tbFileBrowse.TabIndex = 1;
            // 
            // tbImgBrowse
            // 
            this.tbImgBrowse.Location = new System.Drawing.Point(7, 17);
            this.tbImgBrowse.Name = "tbImgBrowse";
            this.tbImgBrowse.Size = new System.Drawing.Size(500, 20);
            this.tbImgBrowse.TabIndex = 0;
            // 
            // groupBoxImgPreview
            // 
            this.groupBoxImgPreview.Controls.Add(this.pbDisplayImage);
            this.groupBoxImgPreview.ForeColor = System.Drawing.Color.White;
            this.groupBoxImgPreview.Location = new System.Drawing.Point(12, 103);
            this.groupBoxImgPreview.Name = "groupBoxImgPreview";
            this.groupBoxImgPreview.Size = new System.Drawing.Size(383, 335);
            this.groupBoxImgPreview.TabIndex = 1;
            this.groupBoxImgPreview.TabStop = false;
            this.groupBoxImgPreview.Text = "Image Preview";
            // 
            // groupBoxImgInfo
            // 
            this.groupBoxImgInfo.Controls.Add(this.lbSize);
            this.groupBoxImgInfo.Controls.Add(this.lbPixels);
            this.groupBoxImgInfo.Controls.Add(this.lbWidth);
            this.groupBoxImgInfo.Controls.Add(this.lbHeight);
            this.groupBoxImgInfo.Controls.Add(this.lblImgPixels);
            this.groupBoxImgInfo.Controls.Add(this.lblImgSize);
            this.groupBoxImgInfo.Controls.Add(this.lblImgWidth);
            this.groupBoxImgInfo.Controls.Add(this.lblImgHeight);
            this.groupBoxImgInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImgInfo.ForeColor = System.Drawing.Color.White;
            this.groupBoxImgInfo.Location = new System.Drawing.Point(674, 12);
            this.groupBoxImgInfo.Name = "groupBoxImgInfo";
            this.groupBoxImgInfo.Size = new System.Drawing.Size(212, 191);
            this.groupBoxImgInfo.TabIndex = 2;
            this.groupBoxImgInfo.TabStop = false;
            this.groupBoxImgInfo.Text = "Image Information";
            // 
            // lblImgPixels
            // 
            this.lblImgPixels.AutoSize = true;
            this.lblImgPixels.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblImgPixels.Location = new System.Drawing.Point(22, 100);
            this.lblImgPixels.Name = "lblImgPixels";
            this.lblImgPixels.Size = new System.Drawing.Size(84, 15);
            this.lblImgPixels.TabIndex = 3;
            this.lblImgPixels.Text = "Image Pixels: ";
            // 
            // lblImgSize
            // 
            this.lblImgSize.AutoSize = true;
            this.lblImgSize.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblImgSize.Location = new System.Drawing.Point(33, 132);
            this.lblImgSize.Name = "lblImgSize";
            this.lblImgSize.Size = new System.Drawing.Size(74, 15);
            this.lblImgSize.TabIndex = 2;
            this.lblImgSize.Text = "Image Size: ";
            // 
            // lblImgWidth
            // 
            this.lblImgWidth.AutoSize = true;
            this.lblImgWidth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblImgWidth.Location = new System.Drawing.Point(23, 68);
            this.lblImgWidth.Name = "lblImgWidth";
            this.lblImgWidth.Size = new System.Drawing.Size(84, 15);
            this.lblImgWidth.TabIndex = 1;
            this.lblImgWidth.Text = "Image Width: ";
            // 
            // lblImgHeight
            // 
            this.lblImgHeight.AutoSize = true;
            this.lblImgHeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgHeight.Location = new System.Drawing.Point(19, 35);
            this.lblImgHeight.Name = "lblImgHeight";
            this.lblImgHeight.Size = new System.Drawing.Size(87, 15);
            this.lblImgHeight.TabIndex = 0;
            this.lblImgHeight.Text = "Image Height: ";
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnClose);
            this.groupBoxButtons.Controls.Add(this.btnDecrypt);
            this.groupBoxButtons.Controls.Add(this.btnEncrypt);
            this.groupBoxButtons.ForeColor = System.Drawing.Color.White;
            this.groupBoxButtons.Location = new System.Drawing.Point(674, 209);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(212, 229);
            this.groupBoxButtons.TabIndex = 3;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Buttons";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(40, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 39);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(40, 94);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(130, 39);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(40, 36);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 39);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            // 
            // pbDisplayImage
            // 
            this.pbDisplayImage.Location = new System.Drawing.Point(6, 19);
            this.pbDisplayImage.Name = "pbDisplayImage";
            this.pbDisplayImage.Size = new System.Drawing.Size(371, 310);
            this.pbDisplayImage.TabIndex = 0;
            this.pbDisplayImage.TabStop = false;
            // 
            // gbTextFile
            // 
            this.gbTextFile.Controls.Add(this.rtbTextFile);
            this.gbTextFile.ForeColor = System.Drawing.Color.White;
            this.gbTextFile.Location = new System.Drawing.Point(401, 103);
            this.gbTextFile.Name = "gbTextFile";
            this.gbTextFile.Size = new System.Drawing.Size(267, 335);
            this.gbTextFile.TabIndex = 4;
            this.gbTextFile.TabStop = false;
            this.gbTextFile.Text = "Text File";
            // 
            // rtbTextFile
            // 
            this.rtbTextFile.Location = new System.Drawing.Point(6, 19);
            this.rtbTextFile.Name = "rtbTextFile";
            this.rtbTextFile.Size = new System.Drawing.Size(254, 310);
            this.rtbTextFile.TabIndex = 0;
            this.rtbTextFile.Text = "";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeight.Location = new System.Drawing.Point(103, 35);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(0, 15);
            this.lbHeight.TabIndex = 4;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWidth.Location = new System.Drawing.Point(104, 68);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(0, 15);
            this.lbWidth.TabIndex = 5;
            // 
            // lbPixels
            // 
            this.lbPixels.AutoSize = true;
            this.lbPixels.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPixels.Location = new System.Drawing.Point(104, 100);
            this.lbPixels.Name = "lbPixels";
            this.lbPixels.Size = new System.Drawing.Size(0, 15);
            this.lbPixels.TabIndex = 6;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(104, 132);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 15);
            this.lbSize.TabIndex = 7;
            this.lbSize.Click += new System.EventHandler(this.LbSize_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.gbTextFile);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.groupBoxImgInfo);
            this.Controls.Add(this.groupBoxImgPreview);
            this.Controls.Add(this.groupBoxBrowseFiles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Steganography";
            this.groupBoxBrowseFiles.ResumeLayout(false);
            this.groupBoxBrowseFiles.PerformLayout();
            this.groupBoxImgPreview.ResumeLayout(false);
            this.groupBoxImgInfo.ResumeLayout(false);
            this.groupBoxImgInfo.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayImage)).EndInit();
            this.gbTextFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBrowseFiles;
        private System.Windows.Forms.Button btnFileBrowse;
        private System.Windows.Forms.Button btnImgBrowse;
        private System.Windows.Forms.TextBox tbFileBrowse;
        private System.Windows.Forms.TextBox tbImgBrowse;
        private System.Windows.Forms.GroupBox groupBoxImgPreview;
        private System.Windows.Forms.GroupBox groupBoxImgInfo;
        private System.Windows.Forms.Label lblImgPixels;
        private System.Windows.Forms.Label lblImgSize;
        private System.Windows.Forms.Label lblImgWidth;
        private System.Windows.Forms.Label lblImgHeight;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.PictureBox pbDisplayImage;
        private System.Windows.Forms.GroupBox gbTextFile;
        private System.Windows.Forms.RichTextBox rtbTextFile;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbPixels;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.Label lbHeight;
    }
}

