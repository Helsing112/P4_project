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
    public partial class ProductDeleteButtonTempReceipt : UserControl
    {
        public ProductDeleteButtonTempReceipt(int size_x, int size_y)
        {
            InitializeComponent(size_x, size_y);
        }

        private void label_delete_Click(object sender, EventArgs e)
        {
            OnLabelClicked();
        }

        public event EventHandler LabelClicked;

        protected virtual void OnLabelClicked()
        {
            if (LabelClicked != null)
            {
                LabelClicked(this, new EventArgs());
            }
        }
        private void InitializeComponent(int size_x, int size_y)
        {
            this.label_delete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_delete
            // 
            this.label_delete.Dock = DockStyle.Fill;
            this.label_delete.Location = new System.Drawing.Point(0, 0);
            this.label_delete.Name = "label_delete";
            this.label_delete.TabIndex = 0;
            this.label_delete.Text = "Del";
            this.label_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_delete.Font = Cosmetics.Standard_font_Tempreceipt;
            this.label_delete.Click += new System.EventHandler(this.label_delete_Click);
            
            // 
            // ProductDeleteButtonTempReceipt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Width = size_x;
            this.Height = size_y;
            this.Controls.Add(this.label_delete);
            this.BackColor = Color.FromArgb(255, 101, 89);
            this.Name = "ProductDeleteButtonTempReceipt";
            this.ResumeLayout(false);
        }
    }
}
