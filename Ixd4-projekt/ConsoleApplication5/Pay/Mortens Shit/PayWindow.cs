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
    public partial class Paywindow : Form
    {    
        private decimal resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;


        public int Size_of_list_x { get; }
        public int Size_of_list_y { get; }
        public int Height_of_element { get; }
        public decimal TempTotal { get; private set; }

        public Paywindow()
        {
            this.Size_of_list_x = 220;
            this.Size_of_list_y = Size_of_list_y;
            this.Height_of_element = 50;
            InitializeComponent();            
        }

        private void InitializeReiptFlowPanel(List<ReceiptProduct> inputList)
        {   
            //reset the receipt
            PayReceiptFlowPanel.Controls.Clear();
            TempTotal = 0M;
            //Create new
            foreach (ReceiptProduct item in inputList)
            {
                ProductButtonInPayReceipt product_item = new ProductButtonInPayReceipt(Size_of_list_x, Height_of_element, item);
                product_item.BackColor = Color.White;

                PayReceiptFlowPanel.Controls.Add(product_item);

                TempTotal += (item.Amount * item.Product.Price);

            }
            TotalAmountNumber.Text = TempTotal.ToString() + ".-";
        }

        /// <summary>
        /// Clears the controls of the receipt, and initilizes the receipt with new input
        /// </summary>
        /// <param name="table_input"></param>
        public void Show_Pay_window(Table_Info table_input)
        {
            InitializeReiptFlowPanel(table_input.TableReceipt);
            this.TopMost = true;
            this.ShowDialog();
        }

    

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
            {
                textBox_result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text = textBox_result.Text + button.Text;
            }
            else
                textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (resultValue != 0)
            {
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = decimal.Parse(textBox_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            labelCurrentOperation.Text = " ";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
