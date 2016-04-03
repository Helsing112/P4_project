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
            this.flowLayoutPanel1.TabIndex = 0;            
            // 
            // FlowOfProductsInTempReceipt
            //             
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FlowOfProductsInTempReceipt";
            this.Size = new System.Drawing.Size(Size_of_list_x, Size_of_list_y);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        public void Add_product(Product product_to_add)
        {
            Add_product(product_to_add, 1);
        }
        public void Add_product(Product product_to_add, int amount)
        {
            bool found_similar = false;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.Name == product_to_add.Name)
                {
                    ProductButtonInFlowTempReciept product = (ProductButtonInFlowTempReciept)item;
                    product.Amount_to_represent += amount;
                    product.Redraw_labels_text();
                    found_similar = true;
                }
            }
            if (!found_similar)
            {
                ProductButtonInFlowTempReciept product_item = new ProductButtonInFlowTempReciept(Size_of_list_x, Height_of_element, product_to_add, amount);
                flowLayoutPanel1.Controls.Add(product_item);
            }
        }

        internal void SaveReceitpToTableInfo(Table_Info TableInfoToOverride)
        {
            TableInfoToOverride.TableReceipt.Clear(); //Clears all items in the list so that it will contain the correct information
            foreach (ProductButtonInFlowTempReciept item in this.flowLayoutPanel1.Controls)
            {
                ProductWithAmount temp_product = new ProductWithAmount(item.Amount_to_represent);
                temp_product.Name = item.Product_input.Name;
                temp_product.Price = item.Product_input.Price;
                TableInfoToOverride.TableReceipt.Add(temp_product);
            }
        }
    }
}
