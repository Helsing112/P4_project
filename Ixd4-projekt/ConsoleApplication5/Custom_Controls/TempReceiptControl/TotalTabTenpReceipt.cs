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
    public partial class TotalTabTenpReceipt : UserControl 
    {
        public TotalTabTenpReceipt(int size_x, int size_y)
        {
            InitializeComponent(size_x, size_y);
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int size_x, int size_y)
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_price, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Total, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.TabIndex = 0;


            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Total.Location = new System.Drawing.Point(3, 0);
            this.label_Total.Name = "label_Total";
            this.label_Total.AutoSize = true;
            this.label_Total.TabIndex = 0;
            this.label_Total.Text = "Total";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_price.Location = new System.Drawing.Point(78, 0);
            this.label_price.Name = "label_price";
            this.label_price.AutoSize = true;
            this.label_price.TabIndex = 1;
            this.label_price.Text = "0.00,-";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // 
            // TotalTabTenpReceipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Width = size_x;
            this.Height = size_y;
            this.Name = "TotalTabTenpReceipt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_Total;
    }
}
