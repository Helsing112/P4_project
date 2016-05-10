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
    public partial class ProductButtonInPayReceipt : UserControl
    {
        private int _amount_to_represent;
        public ReceiptProduct Product_input { get; }
        public int Amount_to_represent { get { return _amount_to_represent; }
                                        set { if (value < 1) { this.Parent = null; } else { _amount_to_represent = value; RedrawLabelText(); } }}
        public int Size_x { get; }
        public int Size_y { get; }
        public decimal TotalPrice { get; set; }

        public delegate void TotalTableTabEventhandler(object source, PayEventArgs args);

        public ProductButtonInPayReceipt(int size_x, int size_y, ReceiptProduct product)
        {
            Product_input = product;
            Size_x = size_x;
            Size_y = size_y;
            TotalPrice = (Product_input.Product.Price * product.Amount);

            InitializeComponent();
            Amount_to_represent = product.Amount;
        }

        public event EventHandler ProductClick;


        private void label_Click(object sender, EventArgs e)
        {
            if(ProductClick != null)
            {
                ProductClick(this, e);
            }
        }

        private void RedrawLabelText()
        {
            TotalPrice = (Product_input.Product.Price * Amount_to_represent);
            this.Label_amount.Text = "x" + Amount_to_represent.ToString();   /*her*/
            this.Label_price.Text = TotalPrice.ToString() + ",-";
        }

        private void InitializeComponent()
        {
            float percent_LA = 0.55F;
            float percent_ButMin = 0.45F;
            float percent_ButMore = 0.60F;
            float percent_LP = 0.70F;

            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;


            this.label_describtion = new System.Windows.Forms.Label();
            this.Label_amount = new System.Windows.Forms.Label();
            this.Label_price = new System.Windows.Forms.Label();
            this.Height = Size_y;
            this.Width = Size_x;
            #region label_describtion
            // 
            this.label_describtion.Font = Cosmetics.Standard_font_Tempreceipt;
            this.label_describtion.AutoSize = false;
            this.label_describtion.Location = new System.Drawing.Point(0, 0);
            this.label_describtion.Height = Size_y;
            this.label_describtion.Width = (int)(Size_x * percent_ButMin) -25;
            this.label_describtion.Name = "label_describtion";
            this.label_describtion.Padding = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.label_describtion.TabIndex = 0;
            this.label_describtion.Text = Product_input.Product.Name;
            this.label_describtion.TextAlign = ContentAlignment.MiddleLeft;
            this.label_describtion.Click += new System.EventHandler(this.label_Click);
            #endregion
            #region Label_amount
            // 
            this.Label_amount.Font = Cosmetics.Standard_font_Tempreceipt;
            this.Label_amount.AutoSize = false;
            this.Label_amount.Location = new System.Drawing.Point((int)(Size_x * percent_LA), 0);//højden af FOnt skal ligges til for perfekt
            this.Label_amount.Height = Size_y - 3;
            this.Label_amount.Width = (int)(Size_x * (percent_ButMore - percent_LA)+25); /*gør det muligt at skrive x ved siden af istedet for oven og under*/
            this.Label_amount.Name = "Label_amount";
            this.Label_amount.Padding = new System.Windows.Forms.Padding(1);
            this.Label_amount.TabIndex = 1;
            this.Label_amount.Text = "x" + Amount_to_represent;
            this.Label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_amount.Click += new System.EventHandler(this.label_Click);
            #endregion
            #region Label_price
            // 
            this.Label_price.Font = Cosmetics.Standard_font_Tempreceipt;
            this.Label_price.AutoSize = false;
            this.Label_price.Location = new System.Drawing.Point((int)(Size_x * percent_LP), 0);
            this.Label_price.Height = Size_y - 3;
            this.Label_price.Width = (int)(Size_x * (1F - percent_LP));            
            this.Label_price.Name = "Label_price";
            this.Label_price.TabIndex = 4;
            this.Label_price.Text = (Product_input.Product.Price * Product_input.Amount).ToString() + ",-";
            this.Label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_price.Click += new System.EventHandler(this.label_Click);
            #endregion

            Controls.Add(Label_amount);
            Controls.Add(label_describtion);
            Controls.Add(Label_price);
        }



        private System.Windows.Forms.Label label_describtion;
        private System.Windows.Forms.Label Label_amount;
        private System.Windows.Forms.Label Label_price;

    }

    }



