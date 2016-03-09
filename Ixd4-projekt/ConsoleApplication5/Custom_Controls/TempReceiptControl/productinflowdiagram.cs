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
    public partial class productinflowdiagram<T> : UserControl where T: Product
    {
        public productinflowdiagram(int size_x, int size_y,T input_product)
        {
            InitializeComponent(size_x,size_y,input_product);
        }

        private void InitializeComponent(int size_x, int size_y, T input_product)
        {
            int tenth_of_size_x = size_x / 10;

            int size_of_panel_1 = tenth_of_size_x * 1;
            int size_of_panel_2 = tenth_of_size_x * 6;
            int size_of_panel_3 = tenth_of_size_x * 3;

            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Margin = new Padding(0);
            this.splitContainer2.Margin = new Padding(0);
            this.splitContainer1.BorderStyle = BorderStyle.None;
            this.splitContainer2.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(0);
            this.splitContainer1.Panel1.Padding = new Padding(0);
            this.splitContainer1.Panel2.Padding = new Padding(0);
            this.splitContainer2.Panel1.Padding = new Padding(0);
            this.splitContainer2.Panel2.Padding = new Padding(0);
            this.splitContainer1.Panel1.Margin = new Padding(0);
            this.splitContainer1.Panel2.Margin = new Padding(0);
            this.splitContainer2.Panel1.Margin = new Padding(0);
            this.splitContainer2.Panel2.Margin = new Padding(0);
            splitContainer1.SplitterWidth = 1;




            this.label_amount = new System.Windows.Forms.Label();
            this.label_describtion = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label_price);
            this.splitContainer1.Size = new Size(size_x, size_y);
            this.splitContainer1.SplitterDistance = size_of_panel_1+size_of_panel_2;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label_amount);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label_describtion);
            this.splitContainer2.Size = new System.Drawing.Size(size_of_panel_1+size_of_panel_2, size_y);
            this.splitContainer2.SplitterDistance = size_of_panel_1;
            this.splitContainer2.TabIndex = 0;
            // 
            // label_amount
            // 
            this.label_amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_amount.Location = new System.Drawing.Point(0, 0);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(splitContainer1.SplitterDistance, size_y);
            this.label_amount.TabIndex = 0;
            this.label_amount.Text = "1";
            this.label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_describtion
            // 
            this.label_describtion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_describtion.Location = new System.Drawing.Point(0, 0);
            this.label_describtion.Name = "label_describtion";
            this.label_describtion.Size = new System.Drawing.Size(size_of_panel_2, size_y);
            this.label_describtion.TabIndex = 0;
            this.label_describtion.Text = input_product.Name;
            this.label_describtion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_price
            // 
            this.label_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_price.Location = new System.Drawing.Point(0, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(size_of_panel_3, size_y);
            this.label_price.TabIndex = 0;
            this.label_price.Text = input_product.Price.ToString();
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            label_amount.BackColor = Color.Red;
            label_describtion.BackColor = Color.Yellow;
            label_price.BackColor = Color.Green;
            // productinflowdiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "productinflowdiagram";
            this.Size = new System.Drawing.Size(size_x, size_y);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
