using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class Pay_windowForm : Standard_Window_Layout
    {
        private decimal _paidAmount;
        private decimal _totalAmount;
        bool IsSplitActive;
        public decimal PaidAmount { get { return _paidAmount; } //prop for paid amount will update remaining and paid amount labels if set
            private set { _paidAmount = value;
                Label_Remain_Number.Text = (TotalAmount - PaidAmount).ToString();
                Label_Paid_number.Text = PaidAmount.ToString();}}
        public decimal TotalAmount { get { return _totalAmount; }//prop for total amount will update remaining and total amount labels if set
            private set { _totalAmount = value;
                Label_Remain_Number.Text = (TotalAmount - PaidAmount).ToString();
                Label_total_Number.Text = TotalAmount.ToString();} }
        public ReceiptCompleteInfo ReceiptInfo { get; private set; }
        public Pay_windowForm()
        {
            InitializeComponent();
            InitializeSplitCompoenets();
            SubscribeEvents();
            
        }
        Panel Panel_splitReceipt;
        Standard_Label Label_SplitTop;
        FlowLayoutPanel Flow_SplitReceipt;
       
        #region Eventhandlers
        private void SubscribeEvents()
        {
            Flow_receiptMain.ControlAdded += Total_amountHandler;
            Flow_receiptMain.ControlRemoved += Total_amountHandler;

            quit_Close_Button1.Button_Click += Quit_click;

            split_button1.Button_Click += SplitButton_click;
            #region numpad button subscribes
            Button_clear.Button_Click += Clear_numpad_click;
            Button_pay.Button_Click += Pay_button_click;

            #region Number button subscribes
            button_num_0.Button_Click += operator_click;
            button_num_1.Button_Click += operator_click;
            button_num_2.Button_Click += operator_click;
            button_num_3.Button_Click += operator_click;
            button_num_4.Button_Click += operator_click;
            button_num_5.Button_Click += operator_click;
            button_num_6.Button_Click += operator_click;
            button_num_7.Button_Click += operator_click;
            button_num_8.Button_Click += operator_click;
            button_num_9.Button_Click += operator_click;
            button_num_decimalPt.Button_Click += operator_click;
            #endregion
            #endregion
        }

        private void SplitButton_click(object sender, EventArgs e)
        {
            if (IsSplitActive)
            {
                DeActivateSplit();
            }
            else
            {
                ActivateSplit();
            }
        }
        private void ActivateSplit()
        {
            if(IsSplitActive == false)
            {
                foreach (Control item in this.Flow_receiptMain.Controls.OfType<ProductButtonInPayReceipt>().ToArray())
                {
                    Flow_receiptMain.Controls.Remove(item);
                    Flow_SplitReceipt.Controls.Add(item);                    
                }
               
                this.Width += Panel_receipt.Width + 20;
                this.CenterToScreen();
                IsSplitActive = true;
                Controls.Add(Panel_splitReceipt);
            }
        }
        private void ProductClickHandler(object sender, EventArgs e)
        {
            ProductButtonInPayReceipt temp = (ProductButtonInPayReceipt)sender;
            if (IsSplitActive && temp.Parent == Flow_receiptMain)
            {
                addProductsToSplitReceipt(temp, 1);
            }
            if(temp.Parent == Flow_SplitReceipt)
            {
                addProductToMainReceipt(temp, 1);
            }
        }

        private void addProductsToSplitReceipt(ProductButtonInPayReceipt productToAdd, int AmountToAdd)
        {
            try
            {
                Flow_SplitReceipt.Controls
                    .OfType<ProductButtonInPayReceipt>()
                    .ToList()
                    .First(x => x.Product_input.Product == productToAdd.Product_input.Product)
                    .Amount_to_represent += AmountToAdd;
                productToAdd.Amount_to_represent -= AmountToAdd;
            }
            catch (InvalidOperationException) //This will only be caught when there is no controls with that product
            {
                ProductButtonInPayReceipt temp = new 
                    ProductButtonInPayReceipt(Flow_receiptMain.Size.Width - 20, 50, new ReceiptProduct(productToAdd.Product_input.Product, AmountToAdd));
                temp.ProductClick += ProductClickHandler;
                Flow_SplitReceipt.Controls.Add(temp);
                productToAdd.Amount_to_represent -= AmountToAdd;
            }
            Update_TotalAmount();
        }

        private void addProductToMainReceipt(ProductButtonInPayReceipt productToAdd, int AmountToAdd)
        {
            try
            {
                Flow_receiptMain.Controls
                    .OfType<ProductButtonInPayReceipt>()
                    .ToList()
                    .First(x => x.Product_input.Product == productToAdd.Product_input.Product)
                    .Amount_to_represent += AmountToAdd;
                productToAdd.Amount_to_represent -= AmountToAdd;
            }
            catch (InvalidOperationException) //This will only be caught when there is no controls with that product
            {
                ProductButtonInPayReceipt temp = new
                    ProductButtonInPayReceipt(Flow_SplitReceipt.Size.Width - 20, 50, new ReceiptProduct(productToAdd.Product_input.Product, AmountToAdd));
                temp.ProductClick += ProductClickHandler;
                Flow_receiptMain.Controls.Add(temp);
                productToAdd.Amount_to_represent -= AmountToAdd;
            }
            Update_TotalAmount();
        }

        private void DeActivateSplit()
        {
            if (IsSplitActive)
            {
                Panel_splitReceipt.Parent = null;
                this.Width -= Panel_receipt.Width + 20;
                this.CenterToScreen();
                Create_receipt(ReceiptInfo);
                IsSplitActive = false;
                Flow_SplitReceipt.Controls.Clear();
            }
        }


        private void Pay_button_click(object sender, EventArgs e)
        {
            if(Label_EnteredAmount.Text != "")
            {
                PaidAmount += Decimal.Parse(Label_EnteredAmount.Text);
                ReceiptInfo.Table.PaidAmount = PaidAmount;
                Label_EnteredAmount.Text = "";
            }
        }

        private void Clear_numpad_click(object sender, EventArgs e)
        {
            Label_EnteredAmount.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Numpad_button reciever = (Numpad_button)sender;
            if(reciever.label1.Text == "." && (Label_EnteredAmount.Text.Contains(".") || Label_EnteredAmount.Text == "")) //only one decimal point or a deciamlpoint as the first char
            {
            }
            else
            {
                Label_EnteredAmount.Text += reciever.label1.Text;
            }
        }

        private void Quit_click(object sender, EventArgs e)
        {
            this.Hide();
            DeActivateSplit();
            Flow_SplitReceipt.Controls.Clear();
            Flow_receiptMain.Controls.Clear();
        }
        private void Total_amountHandler(object sender, ControlEventArgs e)
        {
            Update_TotalAmount();
        }

        private void Update_TotalAmount()
        {
            decimal NewTotal = 0M;
            foreach (var item in Flow_receiptMain.Controls)
            {
                if (item is ProductButtonInPayReceipt)
                {
                    ProductButtonInPayReceipt temp = (ProductButtonInPayReceipt)item;
                    NewTotal += temp.TotalPrice;
                }
            }
            TotalAmount = NewTotal;
        }

        private void Pay_windowForm_Load(object sender, EventArgs e)
        {

        }
        #endregion



        private void Create_receipt(ReceiptCompleteInfo paymentInfo)
        {
            Flow_receiptMain.Controls.Clear();
            this.ReceiptInfo = paymentInfo;
            foreach (var item in paymentInfo.Table.TableReceipt)
            {
                ProductButtonInPayReceipt tempBut = new ProductButtonInPayReceipt(Flow_receiptMain.Size.Width - 20, 50, item);
                tempBut.ProductClick += ProductClickHandler;
                Flow_receiptMain.Controls.Add(tempBut);
            }
            PaidAmount = paymentInfo.Table.PaidAmount;//Gets any paid amount that there has been paid in previous payments

            Label_tableInfo.Text = "Table: " + paymentInfo.Table.Table_name;
        }

        internal void Show_Pay_window(ReceiptCompleteInfo paymentInfo)
        {
            Create_receipt(paymentInfo);
            this.ShowDialog();
        }
        private void InitializeSplitCompoenets()
        {
            Panel_splitReceipt = new Panel();
            Panel_splitReceipt.Size = Panel_receipt.Size;
            Panel_splitReceipt.Location = new Point(20, Panel_receipt.Location.Y);

            Label_SplitTop = new Standard_Label();
            Label_SplitTop.Size = Label_tableInfo.Size;
            Label_SplitTop.Font = Label_tableInfo.Font;
            Label_SplitTop.TextAlign = Label_tableInfo.TextAlign;
            Label_SplitTop.AutoSize = Label_tableInfo.AutoSize;
            Label_SplitTop.Text = "Remaining Items";
            Label_SplitTop.Location = Label_tableInfo.Location;

            Flow_SplitReceipt = new FlowLayoutPanel();
            Flow_SplitReceipt.Size = Flow_receiptMain.Size;
            Flow_SplitReceipt.BackColor = Flow_receiptMain.BackColor;
            Flow_SplitReceipt.Location = Flow_receiptMain.Location;

            Panel_splitReceipt.Controls.Add(Label_SplitTop);
            Panel_splitReceipt.Controls.Add(Flow_SplitReceipt);
        }
    }
}
