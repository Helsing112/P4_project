using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Category
    {
        public string PathOfImage { get; }
        public string Name { get; set; }
        public List<Product> Product_list { get; set; }
        public List<Category> Category_list { get; set; }
        public Category(string name, string path)
        {
            Name = name;
            PathOfImage = path + "\\Category_Cover_Image";
            Category_list = new List<Category>();
            Product_list = new List<Product>();
        }
    }
}
