using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class ReceiptProduct 
    {
        public Product Product { get; private set; }
        public bool IsPaid { get;  set; }
        public int Amount { get; set; }
        /// <summary>
        /// The product will by default not be paid
        /// </summary>
        public ReceiptProduct(Product Product, int Amount) : this(Product, Amount, false) { }

        public ReceiptProduct(Product Product, int Amount, bool IsPaid)
        {
            this.Amount = Amount;
            this.Product = Product;
            this.IsPaid = IsPaid;
        }

    }
}
