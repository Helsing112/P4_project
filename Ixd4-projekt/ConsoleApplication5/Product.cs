using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Product
    {
        public decimal Price { get; set; }

        public string Name { get; set; }

        public List<Product> Varianter = new List<Product>();

        public void Add_to_list(string name, decimal price)
        {
            Product new_product = new Product();
            new_product.Name = name;
            new_product.Price = price;

            Varianter.Add(new_product);
        }
    }
}
