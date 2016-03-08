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
    public partial class CompleteLibraryReader : Form
    {
        private string temp_path;
        private string ORIGINAL_PATH;
        
        public CompleteLibraryReader(string path)
        {
            InitializeComponent();
            temp_path = path;
            ORIGINAL_PATH = path;

            Start(ORIGINAL_PATH);
        }

        private void Start(string path)
        {
            Controls.Clear();
            CategorySubItemsReader Category = new CategorySubItemsReader(path);
            Category.start();
            int i = 0;
            foreach (Category item in Category.MasterCategory.Category_list)
            {
                CreateCategoryButton(item.Name, item.Name, 40, 50*i);
                i++;
            }
            foreach (Product item in Category.MasterCategory.Product_list)
            {
                CreateProductButton(item.Name, item.Name + item.Price, 40, 50 * i);
                i++;
            }
        }

        private void CreateCategoryButton(string name, string text, int x, int y)
        {
            Button dynamicButton = new Button();

            dynamicButton.Height = 40;
            dynamicButton.Width = 100;
            dynamicButton.Location = new Point(x, y);
            dynamicButton.Text = text;
            dynamicButton.Name = name;

            dynamicButton.Click += new EventHandler(CategoryButtonClick);

            Controls.Add(dynamicButton);
        }

        private void CategoryButtonClick(object sender, EventArgs e)
        {
            Button tmp_button = (Button)sender;
            temp_path = temp_path + "\\" +  tmp_button.Name;
            Start(temp_path);

        }

        private void CreateProductButton(string name, string text, int x, int y)
        {
            // Create a Button object 
            Button dynamicButton = new Button();

            // Set Button properties
            dynamicButton.Height = 100;
            dynamicButton.Width = 100;
            dynamicButton.Location = new Point(x, y);
            dynamicButton.Text = text;
            dynamicButton.Name = name;

            // Add a Button Click Event handler
            dynamicButton.Click += new EventHandler(ProductButtonClick);

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(dynamicButton);

        }

        private void ProductButtonClick(object sender, EventArgs e)
        {

        }
    }
}
