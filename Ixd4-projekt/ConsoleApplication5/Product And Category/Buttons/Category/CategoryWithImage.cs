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
    public partial class CategoryWithImage : SuperClassCategory
    {
        public CategoryWithImage() :base()
        {

        }
        public CategoryWithImage(CategoryNew Category) : base(Category)
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            this.CategoryPicture.BackgroundImage = Image.FromFile(Category.PathOfImage);
            this.Textlabel = Category.Name;
        }

        private void CategoryPicture_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1_MouseDown(sender, e);
        }

        private void CategoryPicture_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1_MouseUp(sender, e);
        }
    }
}
