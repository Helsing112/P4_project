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
    /// <summary>
    /// Window where the user can add a new employee
    /// </summary>
    public partial class AddEmployees : Standard_Window_Layout
    {
        public string _path { get; }
        public AddEmployees(string path_of_employees)
        {
            InitializeComponent();
            _path = path_of_employees;
            this.Add_Employee_Button.Button_Click += new System.EventHandler(this.button1_Click);
            this.Name_TextBox.textBox1.TextChanged += new System.EventHandler(this.EmployeeNametextBox_TextChanged);
            this.ID_TextBox.textBox1.TextChanged += new System.EventHandler(this.EmployeeIDtextBox_TextChanged);
            this.Password_TextBox.textBox1.TextChanged += new System.EventHandler(this.EmployeePasswordtextBox_TextChanged);

            Add_Employee_Button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee_Library creator = new Employee_Library();
            Employee _Employee = new Employee();
            _Employee.EmployeeName = Name_TextBox.textBox1.Text;
            _Employee.EmployeeID = int.Parse(ID_TextBox.textBox1.Text);
            _Employee.EmployeePassword = Password_TextBox.textBox1.Text;
            creator.Create_File_And_directory<Employee>(_path, _Employee);
            Password_TextBox.textBox1.Clear();
            ID_TextBox.textBox1.Clear();
            Name_TextBox.textBox1.Clear();

            Messages.ConfirmedAddEmployeees();
        }

        private void Enable_Add_Button()
        {
            if ((!string.IsNullOrWhiteSpace(Name_TextBox.textBox1.Text)) && (!string.IsNullOrWhiteSpace(ID_TextBox.textBox1.Text)) && (!string.IsNullOrWhiteSpace(Password_TextBox.textBox1.Text))) 
            {
                Add_Employee_Button.Enabled = true;
            }
            else
            {
                Add_Employee_Button.Enabled = false;
            }
        }

        // name changed event
        private void EmployeeNametextBox_TextChanged(object sender, EventArgs e)
        {
            Enable_Add_Button();
        }

        // Can only write numbers in ID field
        private void EmployeeIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ID_TextBox.textBox1.Text, "  ^ [0-9]+$"))
            {
                Add_Employee_Button.Enabled = false;
            }
            else
            {
                Enable_Add_Button();
            }
        }

        // password changed event
        private void EmployeePasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            Enable_Add_Button();
        }
    }
}
