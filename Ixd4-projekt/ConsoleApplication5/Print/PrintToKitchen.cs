using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;


namespace ConsoleApplication5
{
    class PrintToKitchen
    {
        public string TableName { get; set; }
        public string EmployeeName { get; set; }
        public List<ReceiptProduct> ProductList { get; set; }
        public string TextFromComment { get; set; }
        public string Printername { get; set; }

        
        public PrintToKitchen(string Tablename, string employename, List<ReceiptProduct> Products, string textfromcomment, string printername)
        {
            this.TableName = Tablename;
            this.ProductList = Products;
            this.EmployeeName = employename;
            this.TextFromComment = textfromcomment;
            this.Printername = printername;
        }




    }
}
