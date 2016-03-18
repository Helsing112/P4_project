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
    public partial class TreeViewerControl : UserControl
    {
        private string temp_path;
        private string INPUT_PATH;
        public int SizeTotal_x { get; private set; }
        public int SizeTotal_y { get; private set; }
        public string Path { get; private set; }
        public TreeViewerControl(int SizeOfControl_x, int SizeOfControl_y, string path)
        {
            SizeTotal_x = SizeOfControl_x;
            SizeTotal_y = SizeOfControl_y;
            Path = path;
            temp_path = path;
            INPUT_PATH = path;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TreeViewerControl";
            this.Width = SizeTotal_x;
            this.Height = SizeTotal_y;
            this.BackColor = Color.Azure;
            this.Load += new System.EventHandler(this.TreeViewerControl_Load);
            this.ResumeLayout(false);
        }

        private void TreeViewerControl_Load(object sender, EventArgs e)
        {
            Start(Path);
        }
        private void Start(string path)
        {
            Controls.Clear();
            CategorySubItemsReader Category = new CategorySubItemsReader(path);
            Category.start();
            int i = 0;
            foreach (Category item in Category.MasterCategory.Category_list)
            {
                CreateCategoryButton(item.Name, item.Name, 40, 50 * i);
                i++;
            }
            foreach (Product item in Category.MasterCategory.Product_list)
            {
                createproductbutton(item, 40, 50 * i);
                i++;
            }
            if (!string.Equals(temp_path,INPUT_PATH))
            {
                BackButton();
            }
        }

        private void createproductbutton(Product product, int x, int y)
        {
            ProductButtonCtrl<Product> temp_product_but = new ProductButtonCtrl<Product>(product);
            temp_product_but.Location = new Point(x, y);
            temp_product_but.BackgroundImage = Image.FromFile(product.PicturePath);
            temp_product_but.BackgroundImageLayout = ImageLayout.Stretch;


            //All subscribers!!----------------------------------------------------------------------
            temp_product_but.MouseDowned += new EventHandler<ProductEventArgs>(ProductButtonDown);
            temp_product_but.MouseUpped += new EventHandler<ProductEventArgs>(ProductButtonUp);
            
            Controls.Add(temp_product_but);
        }

        private void CreateCategoryButton(string name, string text, int x, int y)
        {
            // Create a Button object 
            Button dynamicButton = new Button();
            // Set Button properties
            dynamicButton.Height = 40;
            dynamicButton.Width = 100;
            dynamicButton.Location = new Point(x, y);
            dynamicButton.Text = text;
            dynamicButton.Name = name;
            // Add a Button Click Event handler
            dynamicButton.Click += new EventHandler(CategoryButtonClick);
            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            Controls.Add(dynamicButton);
        }

        private void CategoryButtonClick(object sender, EventArgs e)
        {
            Button tmp_button = (Button)sender;
            temp_path = temp_path + "\\" + tmp_button.Name;
            Start(temp_path);
        }       

        // Knap i valg af varer til at gå tilbage i menuen. 
        private void BackButton()
        {
            Button BackButton = new Button();
            BackButton.Height = 40;
            BackButton.Width = 100;
            BackButton.Dock = DockStyle.Bottom;
            BackButton.Text = "Back";
            BackButton.Name = "Back";
            BackButton.Click += new EventHandler(BackButtonClick);
            Controls.Add(BackButton);
        }
        private void BackButtonClick(object sender, EventArgs e)
        {
            string lastPath = temp_path.Substring(0, temp_path.LastIndexOf('\\'));
            temp_path = lastPath;
            Start(temp_path);
        }
        //event for mouse upped
        public EventHandler<ProductEventArgs> MouseUpped;
        private void ProductButtonUp(object sender, ProductEventArgs e)
        {
            OnMouseUpped(e.product);
        }
        protected virtual void OnMouseUpped(Product product)
        {
            if (MouseUpped != null)
            {
                MouseUpped(this, new ProductEventArgs() { product = product });
            }
        }
        //Event for mouse down
        public EventHandler<ProductEventArgs> MouseDowned;
        private void ProductButtonDown(object sender, ProductEventArgs e)
        {
            OnMouseDowned(e.product);
        }
        protected virtual void OnMouseDowned(Product product)
        {
            if (MouseDowned != null)
            {
                MouseDowned(this, new ProductEventArgs() { product = product });
            }
        }
    }
}
