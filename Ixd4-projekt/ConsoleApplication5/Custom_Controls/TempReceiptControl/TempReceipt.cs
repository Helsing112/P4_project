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
        //public TempReceipt()
        //{
            

        //    //ProductButtonInFlowTempReciept.ProductRemove += new EventHandler<ProductEventArgs>(Product_removed);
        //    //int height_of_total_tab = 50;
            
        //    //flowOfProductsInTempReceipt1 = new FlowOfProductsInTempReceipt(this.Width, this.Height, 40);

        //    //Total_tab = new TotalTabTenpReceipt(this.Width, height_of_total_tab);
            
        //    //Total_tab.Location = new Point(0, this.Height - height_of_total_tab);
        //    //Controls.Add(Total_tab);
        //    //Controls.Add(flowOfProductsInTempReceipt1);
        //}
        public TempReceipt()
        {
            InitializeComponent();

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
            flowOfProductsInTempReceipt1.Add_product(product_to_add, amount);

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
            flowOfProductsInTempReceipt1.resetReceipt();
            total_price = 0.00M;
            Total_tab.label_price.Text = total_price.ToString() + ",-";
        }

        private void InitializeComponent()
        {
            this.flowOfProductsInTempReceipt1 = new ConsoleApplication5.FlowOfProductsInTempReceipt();
            this.Total_tab = new ConsoleApplication5.TotalTabTenpReceipt();
            this.SuspendLayout();
            // 
            // flowOfProductsInTempReceipt1
            // 
            this.flowOfProductsInTempReceipt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowOfProductsInTempReceipt1.Location = new System.Drawing.Point(0, 0);
            this.flowOfProductsInTempReceipt1.Name = "flowOfProductsInTempReceipt1";
            this.flowOfProductsInTempReceipt1.Size = new System.Drawing.Size(721, 595);
            this.flowOfProductsInTempReceipt1.TabIndex = 0;
            // 
            // totalTabTenpReceipt1
            // 
            this.Total_tab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Total_tab.Location = new System.Drawing.Point(0, 601);
            this.Total_tab.Name = "totalTabTenpReceipt1";
            this.Total_tab.Size = new System.Drawing.Size(721, 30);
            this.Total_tab.TabIndex = 1;
            // 
            // TempReceipt
            // 
            this.Controls.Add(this.Total_tab);
            this.Controls.Add(this.flowOfProductsInTempReceipt1);
            this.Name = "TempReceipt";
            this.Size = new System.Drawing.Size(721, 631);
            this.ResumeLayout(false);

        }

        internal void SaveReceiptToTable(Table_Info TableInfoToSave)
        {
            flowOfProductsInTempReceipt1.SaveReceitpToTableInfo(TableInfoToSave);
        }
    }
}
