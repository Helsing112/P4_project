using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace ConsoleApplication5
{
    class PrintToKitchen
    {
        public string TableName { get; set; }
        public string EmployeeName { get; set; }
        public List<ReceiptProduct> ProductList { get; set; }
        public PrintToKitchen(string Tablename, string employename, List<ReceiptProduct> Products)
        {
            this.TableName = TableName;
            this.ProductList = Products;
            this.EmployeeName = EmployeeName;
        }

        static public void MethodThatPrints(string TableName, string EmployeeName, List<ReceiptProduct> Products)
        {
            PrintToKitchen printinfo = new PrintToKitchen(TableName, EmployeeName, Products);


            try
            {
                PrintDocument print = new PrintDocument();
                print.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                print.PrintPage += new PrintPageEventHandler(printinfo.MethodThatPrintsToKitchen);
                print.Print();
            }
            catch (Exception ex)
            {


            }

        }

        private void MethodThatPrintsToKitchen(object sender, PrintPageEventArgs ev)
        {
            Graphics graphics = ev.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString(" Morten Linnets Fun&Go", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);


            const string format = "{0,-5} {1,-10} {2,10} {3,0}";
            string stringtoprint = "\n";

            foreach (var item in ProductList)
            {
                stringtoprint += string.Format(format, item.Amount, item.Product.Name, (item.Product.Price * item.Amount), "kr\n");
                offset = offset + 20;
            }
            ev.Graphics.DrawString(stringtoprint.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 20, 100);
            offset = offset + 40;

            string StringWithEmployeeAndTable = $"You were served by {EmployeeName} at table {TableName}";



        }
    }
}
