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
    public partial class TotalTabTempReceipt : UserControl
    {
        public decimal TTL_price;
        public TotalTabTempReceipt(int Size_x, int Size_y)
        {

            InitializeComponent( Size_x,  Size_y);
        }
        private void InitializeComponent(int Size_x, int Size_y)
        {
            int size_of_side_1_x = (Size_x / 5) * 3;
            int size_of_side_2_x = Size_x - size_of_side_1_x-4;

            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Total_text_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Total_text_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Price_label);
            this.splitContainer1.Size = new System.Drawing.Size(Size_x, Size_y);
            this.splitContainer1.SplitterDistance = size_of_side_1_x;
            this.splitContainer1.TabIndex = 0;
            // 
            // Total_text_label
            // 
            this.Total_text_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total_text_label.Location = new System.Drawing.Point(0, 0);
            this.Total_text_label.Name = "Total_text_label";
            this.Total_text_label.Size = new System.Drawing.Size(size_of_side_1_x, Size_y);
            this.Total_text_label.TabIndex = 0;
            this.Total_text_label.Text = "TOTAL:";
            this.Total_text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price_label
            // 
            this.Price_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price_label.Location = new System.Drawing.Point(0, 0);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(size_of_side_2_x, Size_y);
            this.Price_label.TabIndex = 0;
            this.Price_label.Text = TTL_price.ToString() + ",-";
            this.Price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalTabTempReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "TotalTabTempReceipt";
            this.Size = new System.Drawing.Size(Size_x, Size_y);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
