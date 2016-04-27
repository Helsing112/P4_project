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
    public partial class ProductWithImage : SuperClassProduct
    {
        public ProductWithImage() : base()
        {

        }
        public ProductWithImage(Product Product) : base(Product)
        {
            InitializeComponent();
            initializeData();
        }

        private void initializeData()
        {
            this.PictureOfProduct.MouseDown += OnMouseDown;
            this.PictureOfProduct.MouseUp += OnMouseUp;
            this.Textlabel = Product.Name;
            this.PictureOfProduct.BackgroundImage = Image.FromFile(Product.PathOfImage);           
        }

        private void PictureOfProduct_Click(object sender, EventArgs e)
        {
        }
    }
}
