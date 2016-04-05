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
using System.Threading;

namespace ConsoleApplication5
{
    public partial class XmlFileAdder : Standard_Window_Layout
    {
        /// <summary>
        /// Window to add new products and categories to the product library
        /// </summary>
        public string _path { get; }
        public string sourceFilePath { get; private set; }
        public string pictureLibraryPath { get; private set; }
        public string productPicturePath { get; set; }

        public XmlFileAdder(string Current_path)
        {

            InitializeComponent();
            add_Button1.Button_Click += new System.EventHandler(this.button2_Click);
            save_Create_Button1.Button_Click += new System.EventHandler(this.button1_Click);
            save_Create_Button2.Button_Click += new System.EventHandler(this.Create_Category_Button_Click);
            Text_input.Click += new System.EventHandler(this.textbox_Click);
            _path = Current_path;

        }

        public void Input_In_TextBoxes()
        {

            if (string.IsNullOrEmpty(Text_input.Text) || string.IsNullOrEmpty(PriceInputTextBox.Text))
            {
                save_Create_Button1.Enabled = false;
            }
            else
            {
                save_Create_Button1.Enabled = true;
            }
        }


        private void ProductNameTextbox_TextChanged(object sender, EventArgs e)
        {
            Input_In_TextBoxes();
        }

        private void textbox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlCreateLibrary creator = new XmlCreateLibrary();
            Product _product = new Product();
            _product.Name = Text_input.Text;
            _product.PicturePath = productPicturePath;
            _product.Price = decimal.Parse(PriceInputTextBox.Text);
            creator.Create_File<Product>(_path, _product);
            Text_input.Clear();
            PriceInputTextBox.Clear();

        }

        private void quit_button_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriceTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Input_In_TextBoxes();

            if (System.Text.RegularExpressions.Regex.IsMatch(PriceInputTextBox.Text, "  ^ [0-9]"))
            {
                PriceInputTextBox.Text = "";
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }


        private void CategoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CategoryTextBox.Text.Length != 0)
            {
                save_Create_Button2.Enabled = true;
            }
            else
            {
                save_Create_Button2.Enabled = false;

            }
            if (System.Text.RegularExpressions.Regex.IsMatch(CategoryTextBox.Text, "  ^ [0-9]"))
            {
                CategoryTextBox.Text = "";
            }

        }

        private void CategoryTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Create_Category_Button_Click(object sender, EventArgs e)
        {
            XmlCreateLibrary creator = new XmlCreateLibrary();
            creator.Create_Category(_path + "\\" + CategoryTextBox.Text);
            CategoryTextBox.Clear();


            MessageBox.Show("New Category Created");
            Thread.Sleep(500);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select picture for item";
            openFileDialog1.Filter = "Png Image|*.png|Jpeg Image|*.jpg|Gif Image|*.gif";
            pictureLibraryPath = @"..\..\..\..\PictureLibrary";
            productPicturePath = pictureLibraryPath + "\\" + Text_input.Text + " picture" + ".png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = (openFileDialog1.FileName);
                File.Copy(sourceFilePath, productPicturePath, true);
                Console.WriteLine(pictureLibraryPath + "\\" + Text_input.Text + " picture" + ".png");
                pictureBox1.Image = Image.FromFile(sourceFilePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void testknap11_Load(object sender, EventArgs e)
        {

        }

        private void newtestbutton1_Load(object sender, EventArgs e)
        {

        }

        private void newtestbutton1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
