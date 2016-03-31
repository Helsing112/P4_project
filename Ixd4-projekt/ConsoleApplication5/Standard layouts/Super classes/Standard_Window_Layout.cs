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
    /// <summary>
    /// Standard properties for windows. Sets the borderstyle and background color. 
    /// </summary>
    public partial class Standard_Window_Layout : Form
    {
        public Standard_Window_Layout()
        {

            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#29344c");


        }
    }
}
