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
    public partial class StartPage : UserControl
    {
        public StartPage()
        {
            InitializeComponent();
            this.employeeSignInPanel1._panelForEmployee.Size = employeeSignInPanel1.Size;
        }

        private void adminStartButton1_Load(object sender, EventArgs e)
        {

        }

        private void Label_HeadlineSelectUser_Click(object sender, EventArgs e)
        {

        }
    }
}
