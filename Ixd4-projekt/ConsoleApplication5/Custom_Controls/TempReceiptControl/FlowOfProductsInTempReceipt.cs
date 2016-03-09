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
    public partial class FlowOfProductsInTempReceipt : UserControl
    {
        public int Size_of_list_x { get; }
        public int Size_of_list_y { get; }
        public int Height_of_element { get; }
        public decimal Total_price { get; private set; }

        private int number_of_items = 0;
        public FlowOfProductsInTempReceipt(int Size_of_list_x, int Size_of_list_y, int Height_of_element)
        {
            this.Size_of_list_x = Size_of_list_x;
            this.Size_of_list_y = Size_of_list_y;
            this.Height_of_element = Height_of_element;
            
            InitializeComponent();
        }
        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(Size_of_list_x, Size_of_list_y);
            this.flowLayoutPanel1.TabIndex = 0;
            
            // 
            // FlowOfProductsInTempReceipt
            // 
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FlowOfProductsInTempReceipt";
            this.Size = new System.Drawing.Size(Size_of_list_x, Size_of_list_y);
            this.ResumeLayout(false);

        }
        public void Add_product(Product product_to_add)
        {
            productinflowdiagram<Product> product_item = new productinflowdiagram<Product>(Size_of_list_x, Height_of_element, product_to_add);
            product_item.Location = new Point(0, Height_of_element * number_of_items);
            //ProductInTempReceipt<Product> product_item = new ProductInTempReceipt<Product>(Size_of_list_x, Height_of_element, product_to_add);
            //product_item.Location = new Point(0, Height_of_element * number_of_items);
            product_item.BackColor = Color.AliceBlue;
            flowLayoutPanel1.Controls.Add(product_item);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    

}
}
