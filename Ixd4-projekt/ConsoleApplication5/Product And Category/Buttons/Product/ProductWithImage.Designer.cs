namespace ConsoleApplication5
{
    partial class ProductWithImage
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
            this.PictureOfProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pictureBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(159, 147);
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Size = new System.Drawing.Size(159, 147);
            // 
            // PictureOfProduct
            // 
            this.PictureOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureOfProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureOfProduct.InitialImage = null;
            this.PictureOfProduct.Location = new System.Drawing.Point(18, 13);
            this.PictureOfProduct.Name = "PictureOfProduct";
            this.PictureOfProduct.Size = new System.Drawing.Size(121, 82);
            this.PictureOfProduct.TabIndex = 2;
            this.PictureOfProduct.TabStop = false;
            this.PictureOfProduct.Click += new System.EventHandler(this.PictureOfProduct_Click);
            // 
            // ProductWithImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApplication5.Properties.Resources.knap3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PictureOfProduct);
            this.DoubleBuffered = true;
            this.Name = "ProductWithImage";
            this.Size = new System.Drawing.Size(159, 147);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.PictureOfProduct, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureOfProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureOfProduct;
    }
}
