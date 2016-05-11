using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace ConsoleApplication5
{
    public class Table_button_Xml_data //used to save the relevant data of the buttons
    {
        public string Table_Text { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Table_Button_Type_Xml_data TableType { get; set; }
    }
    public class Table_Button_Type_Xml_data //Used to save the relevant data of the button types
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public Region Region { get; set; }
    }
    public abstract class Table_Control : Button //the superclass of the buttons. Should ONLY contain the general aestethics
    {
        public Color OccupiedColor = Color.FromArgb(74, 74, 74);
        public Color NOTOccupiedColor = Color.LightGray;
    }
    public class Table_Control_Manager : Table_Control //The table_control for the manager window.
    {
        public void delete_control()
        {
            this.Parent = null;            
        }
        public Table_Control_Manager CloneForAddConfirm()
        {
            Table_Control_Manager temp_control = new Table_Control_Manager();
            temp_control.Size = this.Size;
            temp_control.Text = this.Text;
            return temp_control;
        }


    }
    public class Table_Control_MainPage : Table_Control //The table_control for the Main window.
    {
        public Table_Info TableInfo { get; set; }
        public Table_Control_MainPage(string Table_name)
        {
            TableInfo = new Table_Info(Table_name);
            this.Text = Table_name;
            TableInfo.TableReceiptIsEmpty += TableIsNotOcupied;
            TableInfo.TableReceiptIsNOTEmpty += TableIsOccupied;
            this.BackColor = NOTOccupiedColor;
        }

        private void TableIsOccupied(object sender, EventArgs e)
        {
            this.BackColor = OccupiedColor;
        }

        private void TableIsNotOcupied(object sender, EventArgs e)
        {
            this.BackColor = NOTOccupiedColor;
            TableInfo.TableComment = string.Empty;
        }

        internal void removeProducts(List<ReceiptProduct> productsToRemove)
        {
            TableInfo.RemoveProducts(productsToRemove);
        }
    }
    public class Table_Info //class for the table controls MainPage to store relevant data of the receipt.
    {
        public decimal PaidAmount { get; set; }
        public string Table_name { get; }

        public string TableComment { get; set; }
        public List<ReceiptProduct> TableReceipt { get; set; }
        public Table_Info(string table_name)
        {
            this.Table_name = table_name;
            TableReceipt = new List<ReceiptProduct>();
        }

        public void AddReceiptProducts(ReceiptProduct ProductToAdd)
        {
            TableReceipt.Add(ProductToAdd);
            if(TableReceipt.Count != 0 && TableReceiptIsNOTEmpty != null)
            {
                TableReceiptIsNOTEmpty(this, new EventArgs());
            }
        }

        public void ClearAllProductsFromReciept()
        {
            TableReceipt.Clear();
            CheckIfEmpty();
        }
        public void CheckIfEmpty()
        {
            if (TableReceipt.Count == 0 && TableReceiptIsEmpty != null)
            {
                TableReceiptIsEmpty(this, new EventArgs());
                
            }
            if (TableReceipt.Count != 0 && TableReceiptIsNOTEmpty != null)
            {
                TableReceiptIsNOTEmpty(this, new EventArgs());
            }
        }
        public event EventHandler TableReceiptIsNOTEmpty;
        public event EventHandler TableReceiptIsEmpty;
        internal void RemoveProducts(List<ReceiptProduct> productsToRemove)
        {
            foreach (ReceiptProduct item in productsToRemove)
            {
                ReceiptProduct temp = TableReceipt.First(x => x.Product.Name == item.Product.Name);
                temp.Amount -= item.Amount;
                if (temp.Amount <= 0)
                {
                    TableReceipt.RemoveAll(x => x.Product.Name == item.Product.Name);
                }
            }
            if (TableReceipt.Count == 0 && TableReceiptIsEmpty != null)
            {
                TableReceiptIsEmpty(this, new EventArgs());
            }
        }
    }

    public class OneTimePaymentTable_info : Table_Info
    {
        public OneTimePaymentTable_info() : base("ONE TIME PAYMENT")
        {
        }
    }

}
