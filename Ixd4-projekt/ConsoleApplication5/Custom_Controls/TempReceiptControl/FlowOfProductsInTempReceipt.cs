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
        public FlowOfProductsInTempReceipt()
        {
            InitializeComponent();
            Height_of_element = 50;

        }
        public FlowOfProductsInTempReceipt(int Size_of_list_x, int Size_of_list_y, int Height_of_element)
        {
            this.Size_of_list_x = Size_of_list_x;
            this.Size_of_list_y = Size_of_list_y;
            this.Height_of_element = Height_of_element;
            
            InitializeComponent();
        }

        public void resetReceipt()
        {
            flowLayoutPanel1.Controls.Clear();
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        public void Add_product(Product product_to_add)
        {
            Add_product(product_to_add, 1);
        }
        public void Add_product(Product product_to_add, int amount)
        {
            bool found_similar = false;
            foreach (ProductButtonInFlowTempReciept item in flowLayoutPanel1.Controls.OfType<ProductButtonInFlowTempReciept>())
            {
                if (item.Name == product_to_add.Name && item.Product_input.Price == product_to_add.Price)
                {
                    ProductButtonInFlowTempReciept product = (ProductButtonInFlowTempReciept)item;
                    product.Amount_to_represent += amount;
                    product.Redraw_labels_text();
                    found_similar = true;
                }
            }
            if (!found_similar)
            {
                ProductButtonInFlowTempReciept product_item = new ProductButtonInFlowTempReciept(this.Width, Height_of_element, product_to_add, amount);
                flowLayoutPanel1.Controls.Add(product_item);
            }
        }

        internal void SaveReceitpToTableInfo(Table_Info TableInfoToOverride)
        {
            TableInfoToOverride.TableReceipt.Clear(); //Clears all items in the list so that it will contain the correct information
            foreach (ProductButtonInFlowTempReciept item in this.flowLayoutPanel1.Controls)
            {
                ReceiptProduct temp_product = new ReceiptProduct(item.Product_input, item.Amount_to_represent);
                TableInfoToOverride.AddReceiptProducts(temp_product);
            }
            TableInfoToOverride.CheckIfEmpty();
        }
    }
}
