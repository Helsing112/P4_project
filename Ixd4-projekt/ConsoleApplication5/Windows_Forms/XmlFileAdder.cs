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
    public partial class XmlFileAdder : Form
    {
        private string _path { get; }
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
            _product.Price = decimal.Parse(PriceInputTextBox.Text);

            creator.Create_File<Product>(_path, _product);

            Text_input.Clear();
            PriceInputTextBox.Clear();
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
            creator.Create_Category(_path + "\\" + CategoryTextBox.Text);
            CategoryTextBox.Clear();
        }
    }
}
