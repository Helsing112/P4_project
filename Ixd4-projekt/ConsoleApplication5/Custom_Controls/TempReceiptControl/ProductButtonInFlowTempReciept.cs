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
        public ProductButtonInFlowTempReciept(int size_x,int  size_y, Product product)
        {
            InitializeComponent(size_x,size_y, product);
        }



        private void label_Click(object sender, EventArgs e)
        {

        }
        private void Button_plus_Click(object sender, EventArgs e)
        {

        }
        private void Button_minus_Click(object sender, EventArgs e)
        {

        }



        #region InitializeComponent
        private void InitializeComponent(int size_x, int size_y, Product product)
        {
            float percent_LA = 0.55F;
            float percent_ButMin = 0.45F;
            float percent_ButMore = 0.60F;
            float percent_LP = 0.70F;

            this.label_describtion = new System.Windows.Forms.Label();
            this.Label_amount = new System.Windows.Forms.Label();
            this.Button_minus = new System.Windows.Forms.Button();
            this.Button_plus = new System.Windows.Forms.Button();
            this.Label_price = new System.Windows.Forms.Label();
            this.Height = size_y;
            this.Width = size_x;

            this.SuspendLayout();
            // 
            // label_describtion
            // 
            this.label_describtion.Font = Cosmetics.Standard_font;
            this.label_describtion.AutoSize = true;
            this.label_describtion.Location = new System.Drawing.Point(0, size_y/2-label_describtion.Font.Height/2);
            this.label_describtion.Width = (int)(size_x * percent_ButMin);
            this.label_describtion.Name = "label_describtion";
            this.label_describtion.Padding = new System.Windows.Forms.Padding(1, 1, 1, 5);
            this.label_describtion.TabIndex = 0;
            this.label_describtion.Text = product.Name;
            this.label_describtion.TextAlign = ContentAlignment.BottomLeft;
            this.label_describtion.Click += new System.EventHandler(this.label_Click);
            // 
            // Label_amount
            // 
            this.Label_amount.Font = Cosmetics.Standard_font;
            this.Label_amount.AutoSize = true;
            this.Label_amount.Location = new System.Drawing.Point((int)(size_x * percent_LA), size_y/2-Label_amount.Font.Height/2);//højden af FOnt skal ligges til for perfekt
            this.Label_amount.Height = size_y-3;
            this.Label_amount.Width = (int)(size_x * (percent_ButMore - percent_LA));
            this.Label_amount.Name = "Label_amount";
            this.Label_amount.Padding = new System.Windows.Forms.Padding(1);
            this.Label_amount.TabIndex = 1;
            this.Label_amount.Text = "x1";
            this.Label_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_amount.Click += new System.EventHandler(this.label_Click);
            // 
            // Button_minus
            // 
            this.Button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_minus.Location = new System.Drawing.Point((int)(size_x*(percent_ButMin)), 3);
            this.Button_minus.Height = size_y-3;
            this.Button_minus.Width = (int)(size_x * (percent_LA - percent_ButMin));
            this.Button_minus.Name = "Button_minus";
            this.Button_minus.TabIndex = 2;
            this.Button_minus.Text = "-";
            this.Button_minus.UseVisualStyleBackColor = true;
            this.Button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            // 
            // Button_plus
            // 
            this.Button_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_plus.Location = new System.Drawing.Point((int)(size_x*percent_ButMore), 3);
            this.Button_plus.Name = "Button_plus";
            this.Button_plus.Height = size_y-3;
            this.Button_plus.Width = (int)(size_x * (percent_LP - percent_ButMore));
            this.Button_plus.TabIndex = 3;
            this.Button_plus.Text = "+";
            this.Button_plus.UseVisualStyleBackColor = true;
            this.Button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // Label_price
            // 
            this.Label_price.Font = Cosmetics.Standard_font;
            this.Label_price.AutoSize = true;
            this.Label_price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_price.Location = new System.Drawing.Point((int)(size_x*percent_LP), size_y/2-Label_price.Font.Height/2);
            this.Label_price.Height = size_y-3;
            this.Label_price.Width = (int)(size_x * (1F - percent_LP));
            this.Label_price.Name = "Label_price";
            this.Label_price.TabIndex = 4;
            this.Label_price.Text = product.Price.ToString();
            this.Label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_price.Click += new System.EventHandler(this.label_Click);
            // 
            // ProductButtonInFlowTempReciept
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(Label_amount);
            Controls.Add(label_describtion);
            Controls.Add(Label_price);
            Controls.Add(Button_minus);
            Controls.Add(Button_plus);
            this.Name = "ProductButtonInFlowTempReciept";
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.Label label_describtion;
        private System.Windows.Forms.Label Label_amount;
        private System.Windows.Forms.Button Button_minus;
        private System.Windows.Forms.Button Button_plus;
        private System.Windows.Forms.Label Label_price;
    }
}
