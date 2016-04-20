using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Product
    {
        private bool _Is_set = false;
        private decimal _price;
        /// <summary>
        /// Boolean that determines wether price has been set
        /// </summary>
        public bool Is_set { get { return _Is_set; } }
        public decimal Price
        {            
            get { return _price; }
            set { _price = value; _Is_set = true; }
        }

        public string Name { get; set; }

        public string PicturePath { get; set; }

        public List<Product> Varianter = new List<Product>();

        public void Add_to_Varrianter_list(string name, decimal price, string PicturePath)
        {
            Product new_product = new Product();
            new_product.Name = name;
            new_product.Price = price;
            new_product.PicturePath = PicturePath;

            Varianter.Add(new_product);
        }
        public override string ToString()
        {
            return (Name + " " + _price+ " " + "kr");
  
        }
    }
}
