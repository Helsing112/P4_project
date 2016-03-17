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
    public partial class testknapvindue : Form
    {
        public testknapvindue()
        {
            InitializeComponent();
            testknap1 knap1 = new testknap1();
            Controls.Add(knap1);
            
        }


    }
}
