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
    public partial class ProductLogo : SuperClassProduct
    {
        public ProductLogo() : base()
        {

        }
        public ProductLogo(Product Product) : base(Product)
        {
            InitializeComponent();
            initializeData();
        }

        private void initializeData()
        {
            this.pictureBox1.BackgroundImage = Image.FromFile(Product.PathOfImage);

        }
    }
}
