﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ConsoleApplication5
{
    /// <summary>
    /// Window where the user can add a new employee
    /// </summary>
    public partial class AddEmployees : Standard_Window_Layout
    {
        public string _path { get; }

        private readonly List<Employee> _empList = new List<Employee>();

        public AddEmployees(string path_of_employees)
        {
            InitializeComponent();
            _path = path_of_employees;
            this.Add_Employee_Button.Button_Click += new System.EventHandler(this.button1_Click);
            this.quit_Close_Button1.Button_Click += new EventHandler(quit_Close_Button1_Click);

            this.Name_TextBox.textBox1.TextChanged += new System.EventHandler(this.EmployeeNametextBox_TextChanged);
            this.ID_TextBox.textBox1.TextChanged += new System.EventHandler(this.EmployeeIDtextBox_TextChanged);
            this.Password_TextBox.textBox1.TextChanged += new System.EventHandler(this.EmployeePasswordtextBox_TextChanged);

            DirectoryInfo Employer = new DirectoryInfo(_path);
            foreach (var item in Employer.GetFiles())
            {
                Employee Waiter = XmlEmployeeReader.Read_Employee<Employee>(item.FullName);
                _empList.Add(Waiter);
            }

            Add_Employee_Button.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Employee_Library creator = new Employee_Library();
            Employee employee = new Employee
            {
                EmployeeName = Name_TextBox.textBox1.Text,
                EmployeeID = int.Parse(ID_TextBox.textBox1.Text),
                EmployeePassword = Password_TextBox.textBox1.Text
            };

            creator.Create_File_And_directory<Employee>(_path, employee);
            Password_TextBox.textBox1.Clear();
            ID_TextBox.textBox1.Clear();
            Name_TextBox.textBox1.Clear();

            Messages.ConfirmedAddEmployeees();
        }

        private void quit_Close_Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enable_Add_Button()
        {
            try
            {
               if (DoesIdAlreadyExist(Convert.ToInt16(ID_TextBox.textBox1.Text)) &&
                    !string.IsNullOrWhiteSpace(Name_TextBox.textBox1.Text) &&
                    !string.IsNullOrWhiteSpace(ID_TextBox.textBox1.Text) &&
                    !string.IsNullOrWhiteSpace(Password_TextBox.textBox1.Text))
                {
                    Add_Employee_Button.Enabled = true;
                }
                else
                {
                    Add_Employee_Button.Enabled = false;
                }
            }
            catch (FormatException)
            {
                
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

        private bool DoesIdAlreadyExist(int ID)
        {
            return _empList.All(item => ID != item.EmployeeID);
        }

        // password changed event
        private void EmployeePasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            Enable_Add_Button();
        }
    }
}
