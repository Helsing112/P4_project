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
    public partial class SignInPanelControl : UserControl
    {
        public SignInPanelControl()
        {
            InitializeComponent();
            Employeepanel = new EmployeeSignInPanel() {Size = this.Size};
            Controls.Add(Employeepanel);
            BorderStyle = BorderStyle.None;
        }
        public EmployeeSignInPanel Employeepanel;
    }
}
