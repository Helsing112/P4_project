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
    public partial class EmployeeLoginTest : Standard_Window_Layout
    {
        public EmployeeLoginTest(string path)
        {
            InitializeComponent();

            EmployeesReader EmployeeControl = new EmployeesReader(0, 0, path);
            EmployeeControl.Location = new Point(5, 5);
            EmployeesReader.PasswordCorrect += new EventHandler<EmployeeEventArgs>(Close_window);
            Controls.Add(EmployeeControl);
            this.Size = Screen.PrimaryScreen.Bounds.Size;
        }

        private void Close_window(object sender, EmployeeEventArgs e)
        {
            this.Hide();
        }
    }
}
