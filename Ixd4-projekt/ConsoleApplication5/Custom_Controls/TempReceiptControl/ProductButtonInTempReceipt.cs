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
    public partial class ProductButtonInTempReceipt : UserControl
    {
        public int Size_x { get; private set; }
        public int Size_y { get;private set; }
        public Product Product_input { get; private set; }
        public ProductButtonInTempReceipt(int size_x, int size_y, Product product)
        {
            Product_input = product;
            Size_x = size_x;
            Size_y = size_y;
            InitializeComponent(size_x, size_y, product);
        }
        private void InitializeComponent(int size_x, int size_y, Product product)
        {
            int percent_one = 15;
            int percent_two = 85;
            int percent_three = 56;
            double decimal_one = percent_one / 100;

            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_Describtion = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.timer = new Timer();
            this.Delete_button = new ProductDeleteButtonTempReceipt(size_x/6, Size_y);

            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

        
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percent_one));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, percent_two));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, percent_three));
            this.tableLayoutPanel1.Controls.Add(this.label_Amount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Describtion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Price, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_Amount
            // 
            this.label_Amount.Font = Cosmetics.Standard_font;
            this.label_Amount.AutoSize = true;
            this.label_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Amount.Location = new System.Drawing.Point(0, 0);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.TabIndex = 0;
            this.label_Amount.Text = 1.ToString();
            this.label_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Describtion
            // 
            this.label_Describtion.Font = Cosmetics.Standard_font;
            this.label_Describtion.AutoSize = true;
            this.label_Describtion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Describtion.Location = new System.Drawing.Point(size_x*(percent_one/100), 0);
            this.label_Describtion.Name = "label_Describtion";
            this.label_Describtion.TabIndex = 1;
            this.label_Describtion.Text = product.Name;
            this.label_Describtion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Price.Font = Cosmetics.Standard_font;
            this.label_Price.Location = new System.Drawing.Point(size_x * (percent_two / 100), 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.TabIndex = 2;
            this.label_Price.Text = product.Price.ToString() ;
            this.label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            //Timer
            //
            timer.Interval = 3000;
            timer.Tick += new EventHandler(Timer_tick);
            //
            //click events for labels
            //
            this.label_Amount.Click += new EventHandler(this.LabelClick);
            this.label_Price.Click += new EventHandler(this.LabelClick);
            this.label_Describtion.Click += new EventHandler(this.LabelClick);
            //
            //delete button
            //                      
            this.Delete_button.Location = new System.Drawing.Point((size_x/6)*5, 0);
            this.Delete_button.Hide();
            this.Delete_button.LabelClicked += new EventHandler(DeleteButtonClick);
            this.Controls.Add(Delete_button);
            
            // 
            // ProductButtonInTempReceipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductButtonInTempReceipt";
            this.Size = new System.Drawing.Size(size_x, size_y);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Timer timer;
        private ProductDeleteButtonTempReceipt Delete_button;

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            OnProductRemoved(Product_input);
            this.Parent = null;
        }
        private void Timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            Delete_button.Hide();
            this.BackColor = Color.White;
        }
        private void LabelClick(object sender, EventArgs e)
        {
            Delete_button.Show();
            this.BackColor = Color.LightBlue;       
            timer.Start();
        }

        public EventHandler<ProductEventArgs> ProductRemove;

        protected virtual void OnProductRemoved(Product product)
        {
            if (ProductRemove != null)
            {
                ProductRemove(this, new ProductEventArgs() { product = product });
            }
        }

    }
}
