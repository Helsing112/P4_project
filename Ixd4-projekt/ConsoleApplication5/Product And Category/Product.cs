using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Product
    {
        public bool IsLogo { get;  set; }
        public bool _Is_set = false;
        public decimal _price;
        /// <summary>
        /// Boolean that determines wether price has been set
        /// </summary>
        public bool Is_set { get { return _Is_set; } set { } }
        public decimal Price
        {            
            get { return _price; }
            set { _price = value; _Is_set = true; }
        }

        public string Name { get; set; }

        public bool HasImage { get; set; }
        public string _pathOfImage;
        public string PathOfImage
        {
            get { return _pathOfImage; }
            set
            {
                _pathOfImage = value;
                if (_pathOfImage == "")
                {
                    HasImage = false;
                }
                else
                {
                    HasImage = true;
                }
            }
        }
        public string Comment { get; set; }
        public List<Product> Varianter = new List<Product>();

        public void Add_to_Varrianter_list(string name, decimal price, string PicturePath)
        {
            Product new_product = new Product();
            new_product.Name = name;
            new_product.Price = price;
            new_product.PathOfImage = PicturePath;

            Varianter.Add(new_product);
        }
        public override string ToString()
        {
            return (Name + " " + _price+ " " + "kr");
  
        }
    }
}
