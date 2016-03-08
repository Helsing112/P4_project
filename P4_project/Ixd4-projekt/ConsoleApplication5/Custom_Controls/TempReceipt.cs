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
    public partial class TempReceipt : UserControl
    {
        public TempReceipt(int size_x, int size_y)
        {
            InitializeComponent(size_x, size_y);
            Start(size_x, size_y);
        }

        public void Clicked(object sender, ProductEventArgs e)
        {
            listBox1.Items.Add(e.product.Name);
            
        }

        private void InitializeComponent(int size_x, int size_y)
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(size_x, size_y);
            this.listBox1.TabIndex = 0;
            this.Controls.Add(this.listBox1);
            listBox1.Items.Add("Hejsa");

            // 
            // TempReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TempReceipt";
            this.Size = new System.Drawing.Size(size_x, size_y);
            this.ResumeLayout(false);

        }

        private void Start(int size_x, int size_y)
        {

        }
    }
}
