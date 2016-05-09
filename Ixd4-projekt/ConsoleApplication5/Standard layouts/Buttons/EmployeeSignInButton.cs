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
    public partial class EmployeeSignInButton : Std_Button
    {
        public Employee employee { get; set; }
        public EmployeeSignInButton(Employee employee)
        {
            this.employee = employee;
            InitializeComponent(employee); 
        }

        private void EmployeeSignInButton_Load(object sender, EventArgs e)
        {
            Panel temp_panel = new Panel();
            
            this.Size = new Size((Parent.Width-50)/4, (Parent.Height-50)/3);
            this.Margin = new Padding(5);
            this.Anchor = AnchorStyles.None;
        }
    }
}
