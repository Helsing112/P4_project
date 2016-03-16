using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ConsoleApplication5
{
    public partial class AddEmployees : Form
    {
        public string _path { get; }
        public AddEmployees(string path_of_employees)
        {
            InitializeComponent();
            _path = path_of_employees;
            ButtonDeactivated();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            Employee_Library creator = new Employee_Library();
            Employee _Employee = new Employee();
            _Employee.EmployeeName = EmployeeNametextBox.Text;
            _Employee.EmployeeID = int.Parse(EmployeeIDtextBox.Text);
            _Employee.EmployeePassword = EmployeePasswordtextBox.Text;
            creator.Create_File_And_directory<Employee>(_path, _Employee);
            EmployeeNametextBox.Clear();
            EmployeePasswordtextBox.Clear();
            EmployeeIDtextBox.Clear();

            Messages.ConfirmedAddEmployeees();
            
        }

      


        private void EmployeeNametextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonDeactivated();
        }

        private void EmployeeIDtextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonDeactivated();
        }

        private void EmployeePasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            ButtonDeactivated();
        }

        public void ButtonDeactivated()
        {
            if (string.IsNullOrEmpty(EmployeeNametextBox.Text) || string.IsNullOrEmpty(EmployeeIDtextBox.Text) || string.IsNullOrEmpty(EmployeePasswordtextBox.Text))
            {


                button1.Enabled = false;
            }

            else {
                button1.Enabled = true;
            }
                
        }
    }
}
