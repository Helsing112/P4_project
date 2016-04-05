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
    public partial class TextBox_NonInput : TextBox_Touch
    {
        public TextBox_NonInput()
        {
            InitializeComponent();
        }

        internal override void textbox_Click(object sender, EventArgs e)
        {           
        }
    }
}
