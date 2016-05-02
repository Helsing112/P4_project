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
    public partial class StartPageProductViewer : FlowLayoutPanel
    {
        public CategoryNew MainCategory { get; set; }
        public StartPageProductViewer()
        {
            InitializeComponent();
        }
        public virtual void initializeFlowOfProducts(string pathOfLibrary)
        {
            //Get the categories
            XmlProductReader reader = new XmlProductReader();
            MainCategory = reader.Read_product<CategoryNew>(pathOfLibrary);
            ReinitializeFlowOfProducts(MainCategory);
        }
        public void ReinitializeFlowOfProducts(CategoryNew Category)
        {
            this.Controls.Clear();
            foreach (CategoryNew item in Category.Category_list)
            {
                AddCategoryControl(item);
            }
            foreach (Product item in Category.Product_list)
            {
                AddProductControl(item);
            }
        }
        private void AddProductControl(Product ProductToAdd)
        {
            SuperClassProduct temp;
            if (ProductToAdd.IsLogo)
            {
                temp = new ProductLogo(ProductToAdd);
            }
            else if (ProductToAdd.HasImage)
            {
                temp = new ProductWithImage(ProductToAdd);
            }
            else
            {
                temp = new ProductNoImage(ProductToAdd);
            }

            temp.MouseDowned += ProductButtonDown;
            temp.MouseUpped += ProductButtonUp;
            Panel TempHolder = new Panel();
            TempHolder.Size = temp.Size;
            TempHolder.Controls.Add(temp);
            Controls.Add(TempHolder);
        }
        private void AddCategoryControl(CategoryNew CategoryToAdd)
        {
            SuperClassCategory temp;
            if (CategoryToAdd.IsLogo)
            {
                temp = new CategoryLogo(CategoryToAdd);
                //Controls.Add(new CategoryLogo(CategoryToAdd));
            }
            else if (CategoryToAdd.HasImage)
            {
                temp = new CategoryWithImage(CategoryToAdd);
            }
            else
            {
                temp = new CategoryNoImage(CategoryToAdd);
            }

            temp.Button_Click += CategoryClick;
            Panel TempHolder = new Panel();
            TempHolder.Size = temp.Size;
            TempHolder.Controls.Add(temp);
            Controls.Add(TempHolder);
        }

        private void CategoryClick(object sender, EventArgs e)
        {
            if(CategoryClicked != null)
            {
                CategoryClicked(sender, e);
            }
        }
        public event EventHandler CategoryClicked;
        public event EventHandler<ProductEventArgs> MouseDowned;
        public event EventHandler<ProductEventArgs> MouseUpped;
        private void ProductButtonUp(object sender, ProductEventArgs e)
        {
            if (MouseUpped != null)
            {
                MouseUpped(sender, e);
            }
        }

        private void ProductButtonDown(object sender, ProductEventArgs e)
        {
            if (MouseDowned != null)
            {
                MouseDowned(sender, e);
            }
        }
    }
}
