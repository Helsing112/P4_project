using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class ProductInTempReceipt<T> : UserControl where T : Product
    {
        public ProductInTempReceipt(int SizeOfElement_x, int SizeOfElement_y, T product)
        {
            InitializeComponent(SizeOfElement_x, SizeOfElement_y ,product);
        }
        private void InitializeComponent(int SizeOfElement_x, int SizeOfElement_y, T product)
        {
            this.Namel_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.Namel_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Namel_label.AutoSize = true;
            this.Namel_label.Location = new System.Drawing.Point(0,0);
            this.Namel_label.Name = "label1";
            this.Namel_label.Size = new System.Drawing.Size(46, 17);
            this.Namel_label.TabIndex = 0;
            this.Namel_label.Text = product.Name;
            // 
            // label2
            // 
            this.Price_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(0, 20);
            this.Price_label.Name = "label2";
            this.Price_label.Size = new System.Drawing.Size(46, 17);
            this.Price_label.TabIndex = 1;
            this.Price_label.Text = product.Price.ToString();
            // 
            // ProductInTempReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Namel_label);
            this.Height = SizeOfElement_y;
            this.Width = SizeOfElement_x-10;
            this.BackColor = Color.Coral;
            this.Name = "ProductInTempReceipt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
