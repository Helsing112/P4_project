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
    public partial class SuperClassCategory : Std_Button
    {
        public CategoryNew Category { get; set; }
        public SuperClassCategory()
        {
            //throw new WarningException("This Ctor may not be used");
        }
        public SuperClassCategory(CategoryNew Category)
        {
            this.Category = Category;
        }
    }
}
