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
    public partial class CategoryNoImage : SuperClassCategory
    {
        public CategoryNoImage() : base()
        {

        }

        public CategoryNoImage(CategoryNew Category) : base(Category)
        {
            InitializeComponent();
            InitializeData();

        }

        private void InitializeData()
        {
            this.Textlabel = Category.Name;
        }
    }
}
