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
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label1.Size = new System.Drawing.Size(228, 209);
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Size = new System.Drawing.Size(228, 209);
            // 
            // PictureOfProduct
            // 
            this.PictureOfProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureOfProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureOfProduct.InitialImage = null;
            this.PictureOfProduct.Location = new System.Drawing.Point(27, 20);
            this.PictureOfProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureOfProduct.Name = "PictureOfProduct";
            this.PictureOfProduct.Size = new System.Drawing.Size(171, 108);
            this.PictureOfProduct.TabIndex = 2;
            this.PictureOfProduct.TabStop = false;
            this.PictureOfProduct.Click += new System.EventHandler(this.PictureOfProduct_Click);
            this.PictureOfProduct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureOfProduct_MouseDown);
            this.PictureOfProduct.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureOfProduct_MouseUp);
            // 
            // ProductWithImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConsoleApplication5.Properties.Resources.BeerSodaPRODUCT_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.PictureOfProduct);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ProductWithImage";
            this.Size = new System.Drawing.Size(228, 209);
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
