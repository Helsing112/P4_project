﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace ConsoleApplication5
{
    public partial class Admin_Edit_ctrl : UserControl
    {

        private string path;
        private string Starting_lib_path;
        public Size Size_of_table_panel { get; }

        public Admin_Edit_ctrl(string path, Size Size_of_table_panel)
        {
            this.Size_of_table_panel = Size_of_table_panel;
            this.path = path;
            Starting_lib_path = path;
            InitializeComponent();
            start();

        }
        private void start()
        {

            Controls.Clear();
            Create_static_controls();
            DirectoryInfo mapper = new DirectoryInfo(path);
            //foreach (var item in mapper.GetDirectories())
            //{
            //    CreateDynamicButton(i.ToString(), item.Name, 80, 80 * i);
            //    i++;
            //}
            //foreach (var item in mapper.GetFiles())
            //{
            //    CreateDynamicLabel(i.ToString(), item.Name, 80, 80 * i);
            //    i++;
            //}
            //if (i == 0)
            //{
            //    CreateDynamicLabel(i.ToString(), "No products to show", 80, 80 * i);
            //}
        }

        private void Create_static_controls()
        {
            Create_home_button();
         
            Create_edit_button();
            Create_Closer_Button();
            Create_Employee_Button();
            Create_table_manager_button();
            
          
        }

        private void Create_table_manager_button()
        {
            Button Table_manager_button = new Button();

            // Set Button properties
            Table_manager_button.Height = 80;
            Table_manager_button.Width = 300;
            Table_manager_button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            Table_manager_button.Font = new System.Drawing.Font("Segoe UI", 20F);
            Table_manager_button.Location = new Point(500,500);
            Table_manager_button.FlatStyle = FlatStyle.Flat;
            //Quit_button.Location = new Point(500, 300);
            Table_manager_button.Text = "Manage Tables";
            Table_manager_button.Name = "Table_button";
            // Add a Button Click Event handler
            Table_manager_button.Click += Table_manager_button_Click;


            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(Table_manager_button);
        }

        private void Table_manager_button_Click(object sender, EventArgs e)
        {
            Table_management_form tables = new Table_management_form(Size_of_table_panel);            
            tables.Show();
            tables.BringToFront();
        }

        private void Create_Closer_Button()
        {
            Quit_button = new Button();

            // Set Button properties
            Quit_button.Height = 80;
            Quit_button.Width = 300;
            Quit_button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            //Quit_button.Font = new System.Drawing.Font(font1.Families[0], 20F);
            Quit_button.Location = new Point(900);
            Quit_button.FlatStyle = FlatStyle.Flat;
            Quit_button.Text = "QUIT";
            Quit_button.Name = "Quit button";
            // Add a Button Click Event handler
            //Quit_button.Click += new EventHandler(Quit_button_click);
            

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(Quit_button);
        }
        public Button Quit_button;

        public void Create_Employee_Button()
        {
            Button EditEmployee_button = new Button();

            // Set Button properties
            EditEmployee_button.Height = 80;
            EditEmployee_button.Width = 300;
            EditEmployee_button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            EditEmployee_button.FlatStyle = FlatStyle.Flat;
            EditEmployee_button.Font = new System.Drawing.Font("Segoe UI", 20F);
            EditEmployee_button.Location = new Point(300);
            EditEmployee_button.Text = "ADD EMPLOYEE";
            EditEmployee_button.Name = "EditEmployee";
            // Add a Button Click Event handler
            EditEmployee_button.Click += new EventHandler(EditEmployee_button_click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(EditEmployee_button);
        }
        public void EditEmployee_button_click(object sender, EventArgs e)
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
        private void Quit_button_click(object sender, EventArgs e)
        {
            
        }

        private void Create_edit_button()
        {
            Button Edit_button = new Button();

            // Set Button properties
            Edit_button.Height = 80;
            Edit_button.Width = 300;
            Edit_button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            Edit_button.FlatStyle = FlatStyle.Flat;
            Edit_button.Location = new Point(0);
            Edit_button.Text = "ADD PRODUCTS";
            Edit_button.Name = "Edit button";
            Edit_button.Font = new System.Drawing.Font("Segoe UI", 20F);

            // Add a Button Click Event handler
            Edit_button.Click += new EventHandler(Edit_button_click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(Edit_button);
        }

        private void Edit_button_click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<ProductAdderForm>().Count() == 1)
            {
                Application.OpenForms.OfType<ProductAdderForm>().First().BringToFront();
            }
            else
            {
            ProductAdderForm Editor = new ProductAdderForm();
            Editor.ShowDialog();
            }
        }


        private void Create_home_button()
        {
            Button Home_button = new Button();

            // Set Button properties
            Home_button.Height = 80;
            Home_button.Width = 300;
            Home_button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            Home_button.FlatStyle = FlatStyle.Flat;
            Home_button.Font = new System.Drawing.Font("Segoe UI", 20F);

            Home_button.Location = new Point(600);
            Home_button.Text = "HOME";
            Home_button.Name = "Home button";
            // Add a Button Click Event handler
            Home_button.Click += new EventHandler(Home_button_click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(Home_button);
        }
        private void Home_button_click(object sender, EventArgs e)
        {
            path = Starting_lib_path;
            start();
        }
        private void CreateDynamicLabel(string name, string label, int x, int y)
        {
            Label dynamic_label = new Label();

            dynamic_label.Height = 40;
            dynamic_label.Width = 100;
            dynamic_label.Location = new Point(x, y);
            dynamic_label.Text = label;
            dynamic_label.Name = "Label number" + name;
            dynamic_label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(dynamic_label);
        }

        private void CreateDynamicButton(string name, string text, int x, int y)
        {
            // Create a Button object 
            Button dynamicButton = new Button();

            // Set Button properties
            dynamicButton.Height = 40;
            dynamicButton.Width = 100;
            dynamicButton.Location = new Point(x, y);
            dynamicButton.Text = text;
            dynamicButton.Name = "Button number" + name;

            // Add a Button Click Event handler
            dynamicButton.Click += new EventHandler(DynamicButton_Click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(dynamicButton);

        }


        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            path = path + "\\" + button.Text;
            this.start();

        }
    }
}
