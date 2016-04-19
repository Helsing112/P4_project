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
    public partial class SignInOnJobWindow : Standard_Window_Layout
    {
        public SignInOnJobWindow(string path)
        {
            InitializeComponent();
            Initializejobpeople(path);
        }

        private void Initializejobpeople(string path)
        {
            
            EmployeesReader EmployeeControl = new EmployeesReader(500, 200, path);
            EmployeeControl.Location = new Point(0, 0);
            EmployeesReader.PasswordCorrect += new EventHandler<EmployeeEventArgs>(Close_window);
            Controls.Add(EmployeeControl);
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Close_window(object sender, EmployeeEventArgs e)
        {
            this.Hide();
        }

        private void OnJobWindow_Load(object sender, EventArgs e)
        {

        }

        private void SignInOnJobWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
