using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class PrinterInfo
    {
        public string TableName { get; set; }
        public string EmployeeName { get; set; }
        public List<ReceiptProduct> ProductList { get; set; }
        public PrinterInfo(string TableName, string EmployeeName, List<ReceiptProduct> Products)
        {
            this.TableName = TableName;
            this.ProductList = Products;
            this.EmployeeName = EmployeeName;
        }
    }
}
