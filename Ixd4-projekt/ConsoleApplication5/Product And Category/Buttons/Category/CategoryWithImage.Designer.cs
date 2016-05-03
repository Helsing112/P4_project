namespace ConsoleApplication5
{
    partial class CategoryWithImage
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
            this.CategoryPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(152, 134);
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Size = new System.Drawing.Size(152, 134);
            // 
            // CategoryPicture
            // 
            this.CategoryPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CategoryPicture.Cursor = System.Windows.Forms.Cursors.No;
            this.CategoryPicture.Location = new System.Drawing.Point(18, 16);
            this.CategoryPicture.Name = "CategoryPicture";
            this.CategoryPicture.Size = new System.Drawing.Size(108, 75);
            this.CategoryPicture.TabIndex = 2;
            this.CategoryPicture.TabStop = false;
            // 
            // CategoryWithImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApplication5.Properties.Resources.OuterCategories;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.CategoryPicture);
            this.DoubleBuffered = true;
            this.Name = "CategoryWithImage";
            this.Size = new System.Drawing.Size(152, 134);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.CategoryPicture, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CategoryPicture;
    }
}
