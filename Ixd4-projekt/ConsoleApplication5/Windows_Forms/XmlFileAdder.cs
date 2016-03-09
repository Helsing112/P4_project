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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateLibrary creator = new CreateLibrary();
            Product _product = new Product();
            _product.Name = Text_input.Text;
            _product.Price = decimal.Parse(textBox1.Text);
            _product.PicturePath = productPicturePath;



            creator.Create_File<Product>(_path, _product);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Create_cat_but.Enabled = true;
        }

        private void Create_cat_but_Click(object sender, EventArgs e)
        {
            CreateLibrary creator = new CreateLibrary();
            creator.Create_Category(_path + "\\" + textBox2.Text);
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
