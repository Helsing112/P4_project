using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class Table_management_settings_form : Form
    {
        private const int Size_alteration_amount = 10;

        public Table_management_settings_form()
        {
            InitializeComponent();
        }
        private void Button_exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Button_plusWidth_Click(object sender, EventArgs e)
        {
            this.Button_TablePreview.Width += Size_alteration_amount;
            this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X - Size_alteration_amount/2, Button_TablePreview.Location.Y);
        }
        private void Button_MinusWidth_Click(object sender, EventArgs e)
        {
            if (Button_TablePreview.Width > Size_alteration_amount)
            {
                this.Button_TablePreview.Width -= Size_alteration_amount;
                this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X + Size_alteration_amount / 2, Button_TablePreview.Location.Y);
            } 
        }
        private void Button_PlusHeight_Click(object sender, EventArgs e)
        {
            this.Button_TablePreview.Height += Size_alteration_amount;
            this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X, Button_TablePreview.Location.Y - Size_alteration_amount / 2);
        }
        private void Button_MinusHeight_Click(object sender, EventArgs e)
        {
            if(this.Button_TablePreview.Height >= Size_alteration_amount)
            {
                this.Button_TablePreview.Height -= Size_alteration_amount;
                this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X, Button_TablePreview.Location.Y + Size_alteration_amount / 2);
            }
        }

    }
}
