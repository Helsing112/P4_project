using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApplication5
{
    public partial class ProductAdderForm : Standard_Window_Layout
    {
        private int _NoimageOrImageOrLogo;
        public string CurrentPathOfLib { get; private set; }
        public int NoimageOrImageOrLogo { get { return _NoimageOrImageOrLogo; } private set
            {
                if(value == -1)
                {
                    Button_ChooseNoImage.label1.ForeColor = Color.Black;
                    Button_ChooseLogo.label1.ForeColor = Color.White;
                    Button_ChooseWithImage.label1.ForeColor = Color.White;
                }
                else if (value == 0)
                {
                    Button_ChooseNoImage.label1.ForeColor = Color.White;
                    Button_ChooseLogo.label1.ForeColor = Color.White;
                    Button_ChooseWithImage.label1.ForeColor = Color.Black;
                }
                else if (value == 1)
                {
                    Button_ChooseNoImage.label1.ForeColor = Color.White;
                    Button_ChooseLogo.label1.ForeColor = Color.Black;
                    Button_ChooseWithImage.label1.ForeColor = Color.White;
                }
                _NoimageOrImageOrLogo = value;
            } } //-1 for No Image, 0 for image, 1 for Logo
        public string pictureLibraryPath { get; private set; }
        public string sourceFilePath { get; private set; }
        public string productPicturePath { get; private set; }

        public ProductAdderForm()
        {
            InitializeComponent();
            Initialize_events();
            NoimageOrImageOrLogo = -1;

        }

        private void Initialize_events()
        {
            Button_Drinks.Button_Click += Button_Drinks_Button_Click;
            Button_food.Button_Click += Button_food_Button_Click;
            Button_other.Button_Click += Button_other_Button_Click;

            Button_Quit.Button_Click += Button_Quit_Button_Click;

            Button_ChooseLogo.Button_Click += Button_ChooseLogo_Button_Click;
            Button_ChooseNoImage.Button_Click += Button_ChooseNoImage_Button_Click;
            Button_ChooseWithImage.Button_Click += Button_ChooseWithImage_Button_Click;

            Button_AddPicture.Button_Click += Button_AddPicture_Button_Click;

            Button_AddCategory.Button_Click += Button_AddCategory_Button_Click;
            Button_AddProduct.Button_Click += Button_AddProduct_Button_Click;
        }

        private void Button_AddProduct_Button_Click(object sender, EventArgs e)
        {
            Product tempProd = new Product();
            decimal price;
            if (TextBox_PriceInput.Text == "")
            {
                Messages.DenyProductNoPrice();
            }
            else
            {
                try
                {
                    price = decimal.Parse(TextBox_PriceInput.Text);
                    if (NoimageOrImageOrLogo == -1) // Category has no image
                    {
                        tempProd.Name = TextBox_nameInput.Text;
                        tempProd.Price = price;
                        tempProd.PathOfImage = "";
                    }
                    else if (NoimageOrImageOrLogo == 0) //Category has image and text
                    {
                        tempProd.Name = TextBox_nameInput.Text;
                        tempProd.Price = price;
                        tempProd.PathOfImage = productPicturePath;
                    }
                    else if (NoimageOrImageOrLogo == 1) // Category Has logo
                    {
                        tempProd.Name = TextBox_nameInput.Text;
                        tempProd.Price = price;
                        tempProd.PathOfImage = productPicturePath;
                        tempProd.IsLogo = true;
                    }
                    if (TextBox_nameInput.Text == "")
                    {
                        Messages.DenyProductOrCatNoName("category");
                    }
                    else
                    {
                        superClassProductViewer1.CurrentCategory.Product_list.Add(tempProd);
                        superClassProductViewer1.ReinitializeFlowOfProducts(superClassProductViewer1.CurrentCategory);
                        Messages.ConfirmedAddProduct();
                        XmlCreateLibrary.Create_File_TEST(CurrentPathOfLib, superClassProductViewer1.MainCategory);
                    }
                }
                catch (FormatException)
                {
                    Messages.DenyProductPriceFormat();
                }
            }            
        }

        private void Button_AddCategory_Button_Click(object sender, EventArgs e)
        {
            CategoryNew tempCat = new CategoryNew();

            if(NoimageOrImageOrLogo == -1) // Category has no image
            {
                tempCat.Name = TextBox_nameInput.Text;
                tempCat.PathOfImage = "";
            }
            else if (NoimageOrImageOrLogo == 0) //Category has image and text
            {
                tempCat.Name = TextBox_nameInput.Text;
                tempCat.PathOfImage = productPicturePath;
            }
            else if (NoimageOrImageOrLogo == 1) // Category Has logo
            {
                tempCat.Name = TextBox_nameInput.Text;
                tempCat.PathOfImage = productPicturePath;
                tempCat.IsLogo = true;
            }
            if (TextBox_nameInput.Text == "")
            {
                Messages.DenyProductOrCatNoName("category");
            }
            else
            {
                superClassProductViewer1.CurrentCategory.Category_list.Add(tempCat);
                superClassProductViewer1.ReinitializeFlowOfProducts(superClassProductViewer1.CurrentCategory);
                Messages.ConfirmedAddCategory();

                XmlCreateLibrary.Create_File_TEST(CurrentPathOfLib, superClassProductViewer1.MainCategory);
            }
        }

        private void Button_AddPicture_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select picture for item";
            openFileDialog1.Filter = "Png Image|*.png|Jpeg Image|*.jpg|Gif Image|*.gif";
            pictureLibraryPath = @"..\..\..\..\PictureLibrary";
            openFileDialog1.InitialDirectory = pictureLibraryPath;

            productPicturePath = pictureLibraryPath + "\\" + TextBox_nameInput.Text + " picture" + ".png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = (openFileDialog1.FileName);
                File.Copy(sourceFilePath, productPicturePath, true);
                pictureBox_ChooseImage.Image = Image.FromFile(sourceFilePath);
            }
        }    

        private void Button_ChooseWithImage_Button_Click(object sender, EventArgs e)
        {
            NoimageOrImageOrLogo = 0;
        }

        private void Button_ChooseNoImage_Button_Click(object sender, EventArgs e)
        {
            NoimageOrImageOrLogo = -1;
        }

        private void Button_ChooseLogo_Button_Click(object sender, EventArgs e)
        {
            NoimageOrImageOrLogo = 1;
        }

        private void Button_Quit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button_other_Button_Click(object sender, EventArgs e)
        {
            CurrentPathOfLib = Properties.Resources.LocationOfProductLib + Properties.Resources.OtherLibFile;
            superClassProductViewer1.initializeFlowOfProducts(CurrentPathOfLib);

            Button_other.label1.ForeColor = Color.Black;
            Button_food.label1.ForeColor = Color.White;
            Button_Drinks.label1.ForeColor = Color.White;
        }

        private void Button_food_Button_Click(object sender, EventArgs e)
        {
            CurrentPathOfLib = Properties.Resources.LocationOfProductLib + Properties.Resources.FoodLibFile;
            superClassProductViewer1.initializeFlowOfProducts(CurrentPathOfLib);

            Button_other.label1.ForeColor = Color.White;
            Button_food.label1.ForeColor = Color.Black;
            Button_Drinks.label1.ForeColor = Color.White;
        }

        private void Button_Drinks_Button_Click(object sender, EventArgs e)
        {
            CurrentPathOfLib = Properties.Resources.LocationOfProductLib + Properties.Resources.DrinkLibFile;
            superClassProductViewer1.initializeFlowOfProducts(CurrentPathOfLib);

            Button_other.label1.ForeColor = Color.White;
            Button_food.label1.ForeColor = Color.White;
            Button_Drinks.label1.ForeColor = Color.Black;
        }
    }
}
