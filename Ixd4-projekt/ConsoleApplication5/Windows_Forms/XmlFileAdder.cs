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
    public partial class XmlFileAdder : Form
    {
        public string _path { get; }
        public string sourceFilePath { get; private set; }
        public string pictureLibraryPath { get; private set; }
        public string productPicturePath { get; set; }

        public XmlFileAdder(string Current_path)
        {
            InitializeComponent();
            _path = Current_path;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Input_In_TextBoxes() {
            if (string.IsNullOrEmpty(Text_input.Text) || string.IsNullOrEmpty(PriceInputTextBox.Text))
        {
                button1.Enabled = false;
            }
            else
            {
            button1.Enabled = true;

        }
            }


        private void ProductNameTextbox_TextChanged(object sender, EventArgs e)
        {

            Input_In_TextBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateLibrary creator = new CreateLibrary();
            Product _product = new Product();
            _product.Name = Text_input.Text;
            _product.PicturePath = productPicturePath;
            _product.Price = decimal.Parse(PriceInputTextBox.Text);
            


            creator.Create_File<Product>(_path, _product);

            Text_input.Clear();
            PriceInputTextBox.Clear();


            //button1.BackColor = Color.Green;
            //MessageBox.Show(_product.Name + " Added" + "\n" + "Price: " + _product.Price);
            //Thread.Sleep(500);
            //button1.BackColor = Color.White;
        }

        private void PriceTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Input_In_TextBoxes();
        }

        private void CategoryTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CategoryTextBox.Text.Length != 0)
            {
                Create_Category_Button.Enabled = true;
        }
            else
            {
                Create_Category_Button.Enabled = false;

            }
        }

        private void Create_Category_Button_Click(object sender, EventArgs e)
        {
            CreateLibrary creator = new CreateLibrary();
            creator.Create_Category(_path + "\\" + CategoryTextBox.Text);
            CategoryTextBox.Clear();


            Create_Category_Button.BackColor = Color.Green;
            MessageBox.Show("New Category Created");
            Thread.Sleep(500);
            Create_Category_Button.BackColor = Color.White;
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
    }
}
