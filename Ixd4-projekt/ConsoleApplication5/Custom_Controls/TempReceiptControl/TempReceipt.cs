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
            ListOfProducts.Add_product(e.product);
        }

        private void InitializeComponent(int size_x, int size_y)
        {
            this.SuspendLayout();
            ListOfProducts = new ListOfProductInTempReceipt(size_x, size_y, 40);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TempReceipt";
            this.Size = new System.Drawing.Size(size_x, size_y);
            this.BackColor = Color.Wheat;
            this.ResumeLayout(false);

            Controls.Add(ListOfProducts);
            
        }
        ListOfProductInTempReceipt ListOfProducts;

        private void Start(int size_x, int size_y)
        {

        }
    }
}
