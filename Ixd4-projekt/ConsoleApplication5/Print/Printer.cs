using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Drawing;

namespace ConsoleApplication5
{
    class Printer
    {
        public Table_Info TableInfo { get; set; }
        public Employee EmployeeInfo { get; set; }
        public string Totalamount { get; set; }
        public List<ReceiptProduct> BoughtProds { get; set; }
        public Printer(Table_Info TableInfo, Employee EmployeeInfo, string totalAmount)
        {
            this.TableInfo = TableInfo;
            this.EmployeeInfo = EmployeeInfo;
            this.Totalamount = totalAmount;
        }

        public static void Print_ToReceipt(Table_Info TableInfo, Employee EmployeeInfo, string TotalAmount, List<ReceiptProduct> BoughtProducts)
        {
            Printer printinfo = new Printer(TableInfo, EmployeeInfo, TotalAmount);
            printinfo.BoughtProds = BoughtProducts;
            // selects the standard printer and prints to it
            try
            {
                PrintDocument print = new PrintDocument();
                print.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                print.PrintPage += new PrintPageEventHandler(printinfo.PrintEventhandler_Receipt);

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

        static public void Print_ToKitchen(Table_Info TableInfo, Employee EmployeeInfo, string Printername)
        {
            Printer printinfo = new Printer(TableInfo, EmployeeInfo, "0");


            try
            {
                PrintDocument print = new PrintDocument();
                print.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1170);
                print.PrintPage += new PrintPageEventHandler(printinfo.Printeventahnder_PrintToKitchen);
                print.PrinterSettings.PrinterName = Printername;


                if (print.PrinterSettings.IsValid)
                {
                    print.Print();
                }
                else {
                    Messages.PrinterError();
                }


            }
            catch (InvalidPrinterException)
            {


            }

        }
        private void Printeventahnder_PrintToKitchen(object sender, PrintPageEventArgs ev)
        {
            Graphics graphics = ev.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString(" Orders", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            offset = offset + 20;
            const string format = "{0,-5} {1,-10} {2,10}";
            string stringtoprint = "\n";

            foreach (var item in TableInfo.TableReceipt)
            {
                stringtoprint += string.Format(format, item.Amount, item.Product.Name, "\n");
                offset = offset + 20;
            }
            ev.Graphics.DrawString(stringtoprint.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 20, 100);

            offset = offset + 50;

            string StringWithEmployeeAndTable = $"Waiter: {EmployeeInfo.EmployeeName} Table: {TableInfo.Table_name}";
            string StringWithComment = $" Comment: \n {TableInfo.TableComment}";

            ev.Graphics.DrawString(StringWithEmployeeAndTable.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, startX, startY + offset);

            offset = offset + 40;
            ev.Graphics.DrawString(StringWithComment.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, startX, startY + offset);



        }
        public void PrintEventhandler_Receipt(object sender, PrintPageEventArgs ev)
        {

            Graphics graphics = ev.Graphics;

            Font font = new Font("Courier New", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphics.DrawString(" O'learys Bar and Resturant", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            string top = "Item Name".PadRight(30) + "Price";

            graphics.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight;

            graphics.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + 5;

            const string format = "{0,-3} {1,-20} {2,10} {3,0}";
            string stringtoprint = "\n";

            foreach (var item in BoughtProds)
            {
                stringtoprint += string.Format(format, item.Amount, item.Product.Name, (item.Product.Price * item.Amount), "kr\n");
                offset = offset + 20;
            }
            ev.Graphics.DrawString(stringtoprint.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, 20, 100);
            offset = offset + 40;

            graphics.DrawString("Total".PadRight(30) + String.Format("{0:c}", Totalamount), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            string StringWithEmployeeAndTable = $"You were served by {EmployeeInfo.EmployeeName} at table {TableInfo.Table_name}";
            offset = offset + 30;
            ev.Graphics.DrawString(StringWithEmployeeAndTable.ToString(), new Font("Courier New", 12, FontStyle.Regular), Brushes.Black, startX, startY + offset);

            offset = offset + 30;
            graphics.DrawString("Thank you for visiting O'learys", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphics.DrawString("please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
        }
    }
}
