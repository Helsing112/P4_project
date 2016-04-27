using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class CategoryNew
    {
        public bool HasImage { get;   set; }
        public bool IsLogo { get; set; }
        public string _pathOfImage;
        public string PathOfImage { get { return _pathOfImage; }
            set
            {
                _pathOfImage = value;
                if(_pathOfImage == "")
                {
                    HasImage = false;
                }
                else
                {
                    HasImage = true;
                }
            }}
        public string Name { get; set; }
        public List<Product> Product_list { get; set; }
        public List<CategoryNew> Category_list { get; set; }
        public CategoryNew()
        {
            Category_list = new List<CategoryNew>();
            Product_list = new List<Product>();
        }
    }
}
