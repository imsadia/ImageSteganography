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
            this.groupBoxBrowseFiles.SuspendLayout();
            this.groupBoxImgInfo.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
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
            this.groupBoxBrowseFiles.Size = new System.Drawing.Size(558, 85);
            this.groupBoxBrowseFiles.TabIndex = 0;
            this.groupBoxBrowseFiles.TabStop = false;
            this.groupBoxBrowseFiles.Text = "Browse Files";
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.BackColor = System.Drawing.Color.Indigo;
            this.btnFileBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileBrowse.Location = new System.Drawing.Point(415, 49);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(137, 23);
            this.btnFileBrowse.TabIndex = 3;
            this.btnFileBrowse.Text = "Choose File";
            this.btnFileBrowse.UseVisualStyleBackColor = false;
            // 
            // btnImgBrowse
            // 
            this.btnImgBrowse.BackColor = System.Drawing.Color.Indigo;
            this.btnImgBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImgBrowse.Location = new System.Drawing.Point(415, 17);
            this.btnImgBrowse.Name = "btnImgBrowse";
            this.btnImgBrowse.Size = new System.Drawing.Size(137, 23);
            this.btnImgBrowse.TabIndex = 2;
            this.btnImgBrowse.Text = "Choose Image";
            this.btnImgBrowse.UseVisualStyleBackColor = false;
            // 
            // tbFileBrowse
            // 
            this.tbFileBrowse.Location = new System.Drawing.Point(7, 51);
            this.tbFileBrowse.Name = "tbFileBrowse";
            this.tbFileBrowse.Size = new System.Drawing.Size(402, 20);
            this.tbFileBrowse.TabIndex = 1;
            // 
            // tbImgBrowse
            // 
            this.tbImgBrowse.Location = new System.Drawing.Point(7, 17);
            this.tbImgBrowse.Name = "tbImgBrowse";
            this.tbImgBrowse.Size = new System.Drawing.Size(402, 20);
            this.tbImgBrowse.TabIndex = 0;
            // 
            // groupBoxImgPreview
            // 
            this.groupBoxImgPreview.ForeColor = System.Drawing.Color.White;
            this.groupBoxImgPreview.Location = new System.Drawing.Point(12, 103);
            this.groupBoxImgPreview.Name = "groupBoxImgPreview";
            this.groupBoxImgPreview.Size = new System.Drawing.Size(558, 335);
            this.groupBoxImgPreview.TabIndex = 1;
            this.groupBoxImgPreview.TabStop = false;
            this.groupBoxImgPreview.Text = "Image Preview";
            // 
            // groupBoxImgInfo
            // 
            this.groupBoxImgInfo.Controls.Add(this.lblImgPixels);
            this.groupBoxImgInfo.Controls.Add(this.lblImgSize);
            this.groupBoxImgInfo.Controls.Add(this.lblImgWidth);
            this.groupBoxImgInfo.Controls.Add(this.lblImgHeight);
            this.groupBoxImgInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImgInfo.ForeColor = System.Drawing.Color.White;
            this.groupBoxImgInfo.Location = new System.Drawing.Point(576, 12);
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
            this.lblImgPixels.Location = new System.Drawing.Point(10, 91);
            this.lblImgPixels.Name = "lblImgPixels";
            this.lblImgPixels.Size = new System.Drawing.Size(81, 15);
            this.lblImgPixels.TabIndex = 3;
            this.lblImgPixels.Text = "Image Pixels:";
            // 
            // lblImgSize
            // 
            this.lblImgSize.AutoSize = true;
            this.lblImgSize.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblImgSize.Location = new System.Drawing.Point(20, 124);
            this.lblImgSize.Name = "lblImgSize";
            this.lblImgSize.Size = new System.Drawing.Size(71, 15);
            this.lblImgSize.TabIndex = 2;
            this.lblImgSize.Text = "Image Size:";
            // 
            // lblImgWidth
            // 
            this.lblImgWidth.AutoSize = true;
            this.lblImgWidth.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblImgWidth.Location = new System.Drawing.Point(11, 59);
            this.lblImgWidth.Name = "lblImgWidth";
            this.lblImgWidth.Size = new System.Drawing.Size(81, 15);
            this.lblImgWidth.TabIndex = 1;
            this.lblImgWidth.Text = "Image Width:";
            // 
            // lblImgHeight
            // 
            this.lblImgHeight.AutoSize = true;
            this.lblImgHeight.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgHeight.Location = new System.Drawing.Point(7, 26);
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
            this.groupBoxButtons.Location = new System.Drawing.Point(576, 209);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(212, 229);
            this.groupBoxButtons.TabIndex = 3;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Buttons";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Indigo;
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
            this.btnDecrypt.BackColor = System.Drawing.Color.Indigo;
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
            this.btnEncrypt.BackColor = System.Drawing.Color.Indigo;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(40, 36);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 39);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.groupBoxImgInfo.ResumeLayout(false);
            this.groupBoxImgInfo.PerformLayout();
            this.groupBoxButtons.ResumeLayout(false);
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
    }
}

