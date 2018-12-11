namespace Image_Compression
{
    partial class FrmCompression
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
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picDestination = new System.Windows.Forms.PictureBox();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSourceImgSize = new System.Windows.Forms.Label();
            this.lblDestinationImgSize = new System.Windows.Forms.Label();
            this.pnlLoadingContainer = new System.Windows.Forms.Panel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).BeginInit();
            this.pnlLoadingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSource.Location = new System.Drawing.Point(12, 12);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(169, 189);
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            // 
            // picDestination
            // 
            this.picDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDestination.Location = new System.Drawing.Point(362, 13);
            this.picDestination.Name = "picDestination";
            this.picDestination.Size = new System.Drawing.Size(167, 188);
            this.picDestination.TabIndex = 1;
            this.picDestination.TabStop = false;
            // 
            // btnCompress
            // 
            this.btnCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCompress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCompress.Location = new System.Drawing.Point(228, 108);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(83, 23);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "Compress >>";
            this.btnCompress.UseVisualStyleBackColor = false;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Location = new System.Drawing.Point(50, 241);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(400, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSourceImgSize
            // 
            this.lblSourceImgSize.AutoSize = true;
            this.lblSourceImgSize.Location = new System.Drawing.Point(12, 212);
            this.lblSourceImgSize.Name = "lblSourceImgSize";
            this.lblSourceImgSize.Size = new System.Drawing.Size(59, 13);
            this.lblSourceImgSize.TabIndex = 5;
            this.lblSourceImgSize.Text = "Image Size";
            // 
            // lblDestinationImgSize
            // 
            this.lblDestinationImgSize.AutoSize = true;
            this.lblDestinationImgSize.Location = new System.Drawing.Point(359, 212);
            this.lblDestinationImgSize.Name = "lblDestinationImgSize";
            this.lblDestinationImgSize.Size = new System.Drawing.Size(59, 13);
            this.lblDestinationImgSize.TabIndex = 6;
            this.lblDestinationImgSize.Text = "Image Size";
            // 
            // pnlLoadingContainer
            // 
            this.pnlLoadingContainer.Controls.Add(this.picLoading);
            this.pnlLoadingContainer.Location = new System.Drawing.Point(174, 66);
            this.pnlLoadingContainer.Name = "pnlLoadingContainer";
            this.pnlLoadingContainer.Size = new System.Drawing.Size(155, 119);
            this.pnlLoadingContainer.TabIndex = 7;
            // 
            // picLoading
            // 
            this.picLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLoading.Image = global::Image_Compression.Properties.Resources.loading;
            this.picLoading.Location = new System.Drawing.Point(26, 18);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(96, 85);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 0;
            this.picLoading.TabStop = false;
            // 
            // FrmCompression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 277);
            this.Controls.Add(this.pnlLoadingContainer);
            this.Controls.Add(this.lblDestinationImgSize);
            this.Controls.Add(this.lblSourceImgSize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.picDestination);
            this.Controls.Add(this.picSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmCompression";
            this.Text = "TinyPng Image Compression";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).EndInit();
            this.pnlLoadingContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.PictureBox picDestination;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSourceImgSize;
        private System.Windows.Forms.Label lblDestinationImgSize;
        private System.Windows.Forms.Panel pnlLoadingContainer;
        private System.Windows.Forms.PictureBox picLoading;
    }
}

