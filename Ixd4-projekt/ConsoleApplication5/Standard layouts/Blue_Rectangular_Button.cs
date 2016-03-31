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
    public partial class Blue_Rectangular_Button : UserControl
    {
        public Blue_Rectangular_Button()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDown(object sender, EventArgs e)
        {

            this.Width -= 6;
            this.Height -= 6;
            this.label1.Font = new System.Drawing.Font("Segoe UI", ((this.label1.Font.SizeInPoints / 100) * 98), System.Drawing.FontStyle.Bold);
            this.Location = new Point((this.Location.X + 3), (this.Location.Y + 3));
            this.Refresh();


        }

        public EventHandler Button_Click;
        private void pictureBox1_MouseUp(object sender, EventArgs e)
        {
            this.Width += 6;
            this.Height += 6;
            this.label1.Font = new System.Drawing.Font("Segoe UI", ((this.label1.Font.SizeInPoints / 98) * 100), System.Drawing.FontStyle.Bold);
            this.Location = new Point((this.Location.X - 3), (this.Location.Y - 3));
            this.Refresh();
            OnButton_click(sender, e);

        }

        protected virtual void OnButton_click(object sender, EventArgs e)
        {
            if (Button_Click != null)
            {
                Button_Click(sender, e);
            }
        }
    }
}
