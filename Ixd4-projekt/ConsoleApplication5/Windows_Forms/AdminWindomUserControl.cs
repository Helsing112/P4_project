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
    public partial class AdminWindomUserControl : UserControl
    {

        public Size Size_of_table_panel { get; }

        private string path;
        private string Starting_lib_path;

        public AdminWindomUserControl(string path, Size Size_of_table_panel)
        {
            this.Size_of_table_panel = Size_of_table_panel;
            this.path = path;
            Starting_lib_path = path;



            InitializeComponent();

            this.TableManageButton.Button_Click += new System.EventHandler(this.TableManageButton_Click);
            this.EmployeeAddButton.Button_Click += new System.EventHandler(this.EmployeeAddButton_Click);
            this.ProductsAddButton.Button_Click += new System.EventHandler(this.ProductsAddButton_Click);
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.quit_Close_Button1_Click);
           

        }


        private void TableManageButton_Click(object sender, EventArgs e)
        {
            Table_management_form tables = new Table_management_form(Size_of_table_panel);
            tables.Show();
            tables.BringToFront();

        }

        private void EmployeeAddButton_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<AddEmployees>().Count() == 1)
            {
                Application.OpenForms.OfType<AddEmployees>().First().BringToFront();
            }


            else {

                AddEmployees Editor = new AddEmployees(Starting_lib_path + "Employee Library");
                Editor.ShowDialog();
                Editor.TopMost = true;
            }


        }

        private void ProductsAddButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<XmlFileAdder>().Count() == 1)
            {
                Application.OpenForms.OfType<XmlFileAdder>().First().BringToFront();
            }


            else {

                XmlFileAdder Editor = new XmlFileAdder(path);
                Editor.ShowDialog();
                Editor.TopMost = true;
            }

        }
  

          private void quit_Close_Button1_Click(object sender, EventArgs e)
        {
          
        }

    }
}
