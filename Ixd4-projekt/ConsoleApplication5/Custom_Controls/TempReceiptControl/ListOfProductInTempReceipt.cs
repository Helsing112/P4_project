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
    public partial class ListOfProductInTempReceipt : UserControl
    {
        public int Size_of_list_x { get; }
        public int Size_of_list_y { get; }
        public int Height_of_element { get;}
        public ListOfProductInTempReceipt(int Size_of_list_x, int Size_of_list_y, int Height_of_element)
        {
            this.Size_of_list_x = Size_of_list_x;
            this.Size_of_list_y = Size_of_list_y;
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.YellowGreen;
        }
        public void Add_product (Product product_to_add)
        {
            ProductInTempReceipt<Product> product_item = new ProductInTempReceipt<Product>(Size_of_list_x, Height_of_element, product_to_add);
            product_item.BackColor = Color.Blue;
            Controls.Add(product_item);
            this.Refresh();
        }
    }
}
