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
        public string Printername { get; set; }

        public decimal totalamount { get; set; }

        public PrinterInfo(string TableName, string EmployeeName, List<ReceiptProduct> Products, decimal totalamount, string printername)
        {
            this.TableName = TableName;
            this.ProductList = Products;
            this.EmployeeName = EmployeeName;
            this.totalamount = totalamount;
            this.Printername = printername;
        }
         public static void MethodThatPrints(string TableName, string EmployeeName, List<ReceiptProduct> Products, decimal totalamount, string Printername)
        {
            PrinterInfo printinfo = new PrinterInfo(TableName, EmployeeName, Products, totalamount, Printername);
            
            // selects the standard printer and prints to it
            try
            {
                PrintDocument print = new PrintDocument();
                print.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                print.PrintPage += new PrintPageEventHandler(printinfo.MethodThatDoesThePrinting);

                foreach (var printers in PrinterSettings.InstalledPrinters)
                {
                    print.PrinterSettings.PrinterName = printers.ToString();
                    if (print.PrinterSettings.IsDefaultPrinter)
                    {
                        break;
                    }
                }
                print.Print();

            }
            catch (InvalidPrinterException)
            {
                Messages.PrinterError();
            }

        }
        public void MethodThatDoesThePrinting(object sender, PrintPageEventArgs ev)
        {

            Graphics graphics = ev.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString(" Morten Linnets Fun&Go", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            string top = "Item Name".PadRight(30) + "Price";

            graphics.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight;

            graphics.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + 5;

            const string format = "{0,-5} {1,-10} {2,10} {3,0}";
            string stringtoprint = "\n";

            foreach (var item in ProductList)
            {
               stringtoprint += string.Format(format, item.Amount, item.Product.Name, (item.Product.Price * item.Amount),"kr\n");
               offset = offset + 20;
            }
            ev.Graphics.DrawString(stringtoprint.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 20, 100);
            offset = offset + 40;

            graphics.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalamount), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            string StringWithEmployeeAndTable = $"You were served by {EmployeeName} at table {TableName}";
            offset = offset + 30;
            ev.Graphics.DrawString(StringWithEmployeeAndTable.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, startX, startY + offset);

            offset = offset + 30; 
            graphics.DrawString("       Thank-you for givin' us moneyz,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphics.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);






            //string stringtoprint = $"************************************************************************* \n You were served by {EmployeeName} at table {TableName}\n You bought:\n";

  

            //foreach (var item in ProductList)
            //{
            //    stringtoprint += $"  {item.Amount} {item.Product.Name} {(item.Product.Price*item.Amount)}kr \n ";
            //}
            //stringtoprint += $"\n \n Total: {totalamount}kr \n *************************************************************************";
            //ev.Graphics.DrawString(stringtoprint.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 20, 100);
        }
        }
    }
