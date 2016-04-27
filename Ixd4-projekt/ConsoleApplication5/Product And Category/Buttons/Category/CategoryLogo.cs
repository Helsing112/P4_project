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
    public partial class CategoryLogo : SuperClassCategory
    {
        public CategoryLogo() : base()
        {

        }
        public CategoryLogo(CategoryNew Category) : base(Category)
        {
            InitializeComponent();
            InitializeData();

        }

        private void InitializeData()
        {
            this.BackgroundImage = Image.FromFile(Category.PathOfImage);
        }
    }
}
