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
        public List<ReceiptProduct> ActiveTableProductList { get;private set; }
        private decimal total_price { get; set; }
        public TempReceipt(int size_x, int size_y)
        {
            InitializeComponent(size_x, size_y);
        }
        public void Table_receiptReciever(List<ReceiptProduct> ProductList)
        {
            Reset_receipt(); //resets the receipt before drawing new data
            
            foreach (ReceiptProduct item in ProductList)
            {
                Add_products(item.Product, item.Amount);
            }
            ActiveTableProductList = ProductList;           
        }

        public void Add_products(Product product_to_add)
        {
            Add_products(product_to_add, 1);
        }

        public void Add_products(Product product_to_add, int amount)
        {
            ListOfProducts.Add_product(product_to_add, amount);

            total_price += product_to_add.Price*amount;
            Total_tab.label_price.Text = total_price.ToString() + ",-";

        }
        private void Product_removed(object sender, ProductEventArgs e)
        {
            int Representing_amount = (int)sender;
            total_price += e.product.Price * Representing_amount;
            Total_tab.label_price.Text = total_price.ToString() + ",-";
        }
        public void Reset_receipt()
        {
            ListOfProducts.resetReceipt();
            total_price = 0.00M;
            Total_tab.label_price.Text = total_price.ToString() + ",-";
        }

        private void InitializeComponent(int size_x, int size_y)
        {
            ProductButtonInFlowTempReciept.ProductRemove += new EventHandler<ProductEventArgs>(Product_removed);
            int height_of_total_tab = 50;
            this.SuspendLayout();
            ListOfProducts = new FlowOfProductsInTempReceipt(size_x, size_y, 40);
            Total_tab = new TotalTabTenpReceipt(size_x, height_of_total_tab);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "TempReceipt";
            this.Height = size_x;
            this.Width = size_y;
            this.ResumeLayout(false);
            Total_tab.Location = new Point(0, size_y-height_of_total_tab);
            this.ParentChanged += TempReceipt_ParentChanged;
            Controls.Add(Total_tab);
            Controls.Add(ListOfProducts);
        }
        private void TempReceipt_ParentChanged(object sender, EventArgs e)
        {
            ListOfProducts.SaveReceiptToList(ActiveTableProductList);
        }

        FlowOfProductsInTempReceipt ListOfProducts;
        TotalTabTenpReceipt Total_tab;   

        internal void SaveReceiptToTableInfo(Table_Info TableInfoToSave)
        {
            ListOfProducts.SaveReceitpToTableInfo(TableInfoToSave);
        }
    }
}
