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
    /// <summary>
    /// The basic properties for a button. Changes here will be reflected on all buttons in the program. <br></br>
    /// The backdrop of the button is set by selecting the picturebox property and changing image.
    /// Remember to add backdrop to the resources.
    /// </summary>
    public partial class Std_Button : UserControl
    {

        public string Textlabel { get; set; }
        public System.Drawing.Image Image_set { get; set; }

        public Std_Button()
        {
           InitializeComponent();
        }

        // loads the text on the button and the font used. Change here to edit the font of all buttons.
        private void Std_Layout_Load(object sender, System.EventArgs e)
        {

            this.label1.Text = Textlabel;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);

            if (Image_set != null)
            {
                this.pictureBox1.Image = Image_set;
            }

        }

        // Mouse down and up function that adds animation to pressed buttons. Also consists of the click function.
        private void pictureBox1_MouseDown(object sender, EventArgs e)
        {

            this.Width -= 6;
            this.Height -= 6;
            this.label1.Font = new System.Drawing.Font("Segoe UI", ((this.label1.Font.SizeInPoints / 100) * 98), System.Drawing.FontStyle.Bold);
            this.Location = new Point((this.Location.X + 3), (this.Location.Y + 3));
            this.Refresh();
        }

        public event EventHandler Button_Click;
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
                Button_Click(this, e);
            }
        }
    }
}
