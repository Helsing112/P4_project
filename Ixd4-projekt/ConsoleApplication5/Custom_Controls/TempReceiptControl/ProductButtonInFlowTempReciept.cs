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
    public partial class ProductButtonInFlowTempReciept : UserControl
    {
        public Product Product_input { get;  }
        public int Amount_to_represent { get; set; }
        public int Size_x { get;  }
        public int Size_y { get;}
        public ProductButtonInFlowTempReciept(int size_x,int  size_y, Product product, int amount_to_represent)
        {
            Size_x = size_x-5;
            Size_y = size_y;
            Amount_to_represent = amount_to_represent;
            Product_input = product;
            this.BackColor = Color.FromArgb(255, 245, 245, 245);
            InitializeComponent();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            OnProductAmountAltered(-Amount_to_represent ,Product_input);
            this.Parent = null;
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            Delete_button.Hide();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Delete_button.Show();
            timer.Start();
        }
        private void Button_plus_Click(object sender, EventArgs e)
        {
            Amount_to_represent++;
            OnProductAmountAltered(1, Product_input);
            Redraw_labels_text();
        }
        private void Button_minus_Click(object sender, EventArgs e)
        {
            Amount_to_represent--;
            OnProductAmountAltered(-1, Product_input);
            Redraw_labels_text();
        }

        public event EventHandler<ProductEventArgs> ProductRemove;//static publisher for deletion or addition
        protected virtual void OnProductAmountAltered(int Representing_amount, Product product)
        {
            if (ProductRemove != null)
            {
                ProductRemove(Representing_amount, new ProductEventArgs() { product = product });
            }
        }
        #region InitializeComponent
        private void InitializeComponent()
        {
            float percent_LA = 0.50F;
            float percent_ButMin = 0.40F;
            float percent_ButMore = 0.60F;
            float percent_LP = 0.70F;

            this.label_describtion = new System.Windows.Forms.Label();
            this.Label_amount = new System.Windows.Forms.Label();
            this.Button_minus = new Button_Minus();
            this.Button_plus = new Button_Plus();
            this.Label_price = new System.Windows.Forms.Label();
            this.Height = Size_y;
            this.Width = Size_x;

            this.SuspendLayout();
            // 
            #region label_describtion
            // 
            this.label_describtion.Font = Cosmetics.Standard_font_Tempreceipt;
            this.label_describtion.AutoSize = false;
            this.label_describtion.Location = new System.Drawing.Point(0, 0);
            this.label_describtion.Height = Size_y;
            this.label_describtion.Width = (int)(Size_x * percent_ButMin);
            this.label_describtion.Name = "label_describtion";
            this.label_describtion.Padding = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.label_describtion.TabIndex = 0;
            this.label_describtion.Text = Product_input.Name;
            this.label_describtion.TextAlign = ContentAlignment.MiddleLeft;
            this.label_describtion.Click += new System.EventHandler(this.label_Click);
            #endregion
            #region Label_amount
            // 
            this.Label_amount.Font = Cosmetics.Standard_font_Tempreceipt;
            this.Label_amount.AutoSize = false;
            this.Label_amount.Location = new System.Drawing.Point((int)(Size_x * percent_LA), 0);//højden af FOnt skal ligges til for perfekt
            this.Label_amount.Height = Size_y-3;
            this.Label_amount.Width = (int)(Size_x * (percent_ButMore - percent_LA));
            this.Label_amount.Name = "Label_amount";
            this.Label_amount.Padding = new System.Windows.Forms.Padding(1);
            this.Label_amount.TabIndex = 1;
            this.Label_amount.Text = "x" + Amount_to_represent;
            this.Label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_amount.Click += new System.EventHandler(this.label_Click);
            #endregion
            #region Button_minus
            // 
            this.Button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_minus.Location = new System.Drawing.Point((int)(Size_x*(percent_ButMin)), 3);
            this.Button_minus.Height = Size_y-3;
            this.Button_minus.Width = (int)(Size_x * (percent_LA - percent_ButMin));
            this.Button_minus.Padding = new Padding(10);
            this.Button_minus.Name = "Button_minus";
            this.Button_minus.TabIndex = 2;
            this.Button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            this.Button_minus.pictureBox1.Click += Button_minus_Click;
            #endregion
            #region Button_plus
            // 
            this.Button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_plus.Location = new System.Drawing.Point((int)(Size_x*percent_ButMore), 3);
            this.Button_plus.Name = "Button_plus";
            this.Button_plus.Height = Size_y-3;
            this.Button_plus.Width = (int)(Size_x * (percent_LP - percent_ButMore));
            this.Button_plus.TabIndex = 3;
            this.Button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            this.Button_plus.pictureBox1.Click += Button_plus_Click;
            this.Button_plus.Padding = new Padding(10);
            #endregion
            #region Label_price
            // 
            this.Label_price.Font = Cosmetics.Standard_font_Tempreceipt;
            this.Label_price.AutoSize = false;
            this.Label_price.Location = new System.Drawing.Point((int)(Size_x*percent_LP),0);
            this.Label_price.Height = Size_y-3;
            this.Label_price.Width = (int)(Size_x * (1F - percent_LP));
            this.Label_price.Name = "Label_price";
            this.Label_price.TabIndex = 4;
            this.Label_price.Text = (Product_input.Price * Amount_to_represent).ToString()+ ",-";
            this.Label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_price.Click += new System.EventHandler(this.label_Click);
            #endregion
            # region deleteButton + timer for delete timer
            //
            this.Delete_button = new ProductDeleteButtonTempReceipt(Label_price.Width/3, Size_y);
            this.Delete_button.Hide();
            this.Delete_button.Location = new Point(Label_price.Location.X+(Label_price.Width/3)*2,0);
            this.Delete_button.LabelClicked += new EventHandler(DeleteButtonClick);

            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += new EventHandler(Timer_tick);
            #endregion
            // ProductButtonInFlowTempReciept
            // 
            if(Amount_to_represent <= 1)
            {
                Button_minus.Enabled = false;
            }
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(Delete_button);
            Controls.Add(Label_amount);
            Controls.Add(label_describtion);
            Controls.Add(Label_price);
            Controls.Add(Button_minus);
            Controls.Add(Button_plus);
            this.Name = Product_input.Name;
            this.ResumeLayout(false);

        }


        #endregion

        private ProductDeleteButtonTempReceipt Delete_button;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_describtion;
        private System.Windows.Forms.Label Label_amount;
        private Button_Minus Button_minus;
        private Button_Plus Button_plus;
        private System.Windows.Forms.Label Label_price;

        public void Redraw_labels_text()
        {
            if(Amount_to_represent <= 1)
            {
                Button_minus.Enabled = false;
            }
            else
            {
                Button_minus.Enabled = true;
            }
            this.Label_amount.Text = "x" + Amount_to_represent;
            this.Label_price.Text = (Product_input.Price * Amount_to_represent).ToString() + ",-";
        }
    }
}
