using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication5
{
    public class ProductWithAmount : Product
    {
        public int Amount { get; set; }
        public ProductWithAmount(int Representing_amount)
        {
            Amount = Representing_amount;
        }
    }
}