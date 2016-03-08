using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            this.Controls.Clear();
            Create_static_controls();
            Console.WriteLine(Controls.Owner);
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
                CreateDynamicLabel(i.ToString(), "N/A", 80, 80 * i);
            }
        }

        private void Create_static_controls()
        {
            Create_home_button();
            // Create_back_button();
            Create_edit_button();
            Create_Closer_Button();
        }

        private void Create_Closer_Button()
        {
            Button Quit_button = new Button();

            // Set Button properties
            Quit_button.Height = 40;
            Quit_button.Width = 100;
            Quit_button.Location = new Point(500, 300);
            Quit_button.Text = "Quit";
            Quit_button.Name = "Quit button";
            // Add a Button Click Event handler
            Quit_button.Click += new EventHandler(Quit_button_click);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(Quit_button);
        }

        private void Quit_button_click(object sender, EventArgs e)
        {
        }

        private void Create_edit_button()
        {
            Button Edit_button = new Button();

            // Set Button properties
            Edit_button.Height = 40;
            Edit_button.Width = 100;
            Edit_button.Location = new Point(200, 300);
            Edit_button.Text = "Edit";
            Edit_button.Name = "Edit button";
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

        private void Create_back_button()
        {
            throw new NotImplementedException();
        }

        private void Create_home_button()
        {
            Button Home_button = new Button();

            // Set Button properties
            Home_button.Height = 40;
            Home_button.Width = 100;
            Home_button.Location = new Point(300, 300);
            Home_button.Text = "Home";
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
