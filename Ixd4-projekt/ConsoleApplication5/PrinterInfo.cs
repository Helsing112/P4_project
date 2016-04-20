using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace ConsoleApplication5
{
  class PrinterInfo
    {
        public string TableName { get; set; }
        public string EmployeeName { get; set; }
        public List<ReceiptProduct> ProductList { get; set; }

        public decimal totalamount { get; set; }
        public PrinterInfo(string TableName, string EmployeeName, List<ReceiptProduct> Products, decimal totalamount)
        {
            this.TableName = TableName;
            this.ProductList = Products;
            this.EmployeeName = EmployeeName;
            this.totalamount = totalamount;
        }
         static public void MethodThatPrints(string TableName, string EmployeeName, List<ReceiptProduct> Products, decimal totalamount)
        {
            PrinterInfo printinfo = new PrinterInfo(TableName, EmployeeName, Products, totalamount);
            
            //private void button1_Click(object sender, EventArgs e)
        
            try
            {
                PrintDocument print = new PrintDocument();
                print.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                print.PrintPage += new PrintPageEventHandler(printinfo.MethodThatDoesThePrinting);
                print.Print();
            }
            catch (Exception ex)
            {

               
            }
        
    }
        public void MethodThatDoesThePrinting(object sender, PrintPageEventArgs ev)
        {
            string stringtoprint = $"************************************************************************* \n You were served by {EmployeeName} at table {TableName}\n You bought:\n";

  

            foreach (var item in ProductList)
            {
                stringtoprint += $"  {item.Amount} {item.Product.Name} {(item.Product.Price*item.Amount)}kr \n ";
            }
            stringtoprint += $"\n \n Total: {totalamount}kr \n *************************************************************************";
            ev.Graphics.DrawString(stringtoprint.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 20, 100);
        }
        }
    }
