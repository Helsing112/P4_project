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
        public Admin_Edit_ctrl(string path)
        {
            this.path = path;
            Starting_lib_path = path;
            InitializeComponent();
            start();
        }
        private void start()
        {

            int i = 0;
            Controls.Clear();
            Create_static_controls();
            DirectoryInfo mapper = new DirectoryInfo(path);
            foreach (var item in mapper.GetDirectories())
            {
                CreateDynamicButton(i.ToString(), item.Name, 80, 80 * i);
                i++;
            }
            foreach (var item in mapper.GetFiles())
            {
                CreateDynamicLabel(i.ToString(), item.Name, 80, 80 * i);
                i++;
            }
            if (i == 0)
            {
                CreateDynamicLabel(i.ToString(), "No products to show", 80, 80 * i);
            }
        }

        private void Create_static_controls()
        {
            Create_home_button();
            Create_edit_button();
            Create_Closer_Button();
            Create_Employee_Button();
            
            TableManager_button();
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

        private void Create_Employee_Button()
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
            EditEmployee_button.Name = "Edit Employee";
            // Add a Button Click Event handler
            EditEmployee_button.Click += new EventHandler(EditEmployee_button_click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(EditEmployee_button);
        }
        private void EditEmployee_button_click(object sender, EventArgs e)
        {
            AddEmployees Editor = new AddEmployees(Starting_lib_path + "Employee Library");
            Editor.Show();
        }

        private void TableManager_button()
        {

            Button TableManager_button = new Button();

            // Set Button properties
            TableManager_button.Height = 80;
            TableManager_button.Width = 300;
            TableManager_button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            TableManager_button.FlatStyle = FlatStyle.Flat;
            TableManager_button.Font = new System.Drawing.Font("Segoe UI", 20F);


            TableManager_button.Location = new Point(200,100);
            TableManager_button.Text = "Table Manager";
            TableManager_button.Name = " TableManager";
            // Add a Button Click Event handler
            TableManager_button.Click += new EventHandler(TableManager_button_click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(TableManager_button);
        }

        private void TableManager_button_click(object sender, EventArgs e)
        {
            TableAdd TableAdd = new TableAdd();
            TableAdd.Show();
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
            XmlFileAdder Editor = new XmlFileAdder(path);
            Editor.Show();
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
            Console.WriteLine("home added");
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
