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
        
    
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;


        public int Size_of_list_x { get; }
        public int Size_of_list_y { get; }
        public int Height_of_element { get; }
        public decimal TempTotal { get; private set; }

        public Paywindow(List<ProductWithAmount> InputList)
        {
            this.Size_of_list_x = 220;
            this.Size_of_list_y = Size_of_list_y;
            this.Height_of_element = 50;
            InitializeComponent();
            InitializeReiptFlowPanel(InputList);
            
        }

        private void InitializeReiptFlowPanel(List<ProductWithAmount> inputList)
        {
          
            foreach (ProductWithAmount item in inputList)
            {
                PruductButtonInPayReceipt product_item = new PruductButtonInPayReceipt(Size_of_list_x, Height_of_element, item);
                product_item.BackColor = Color.White;

                PayReceiptFlowPanel.Controls.Add(product_item);

                TempTotal += (item.Amount * item.Price);

            }
            TotalAmountNumber.Text = TempTotal.ToString() + ".-";



            //if (TempTotal != tempPrice)
            //{
            //    TotalAmountNumber.Text = TempTotal.ToString() + ".-";
            //}
            //else { 

            //    TotalAmountNumber.Text = tempPrice.ToString();
            //}

        }

    

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (isOperationPerformed))
                textBox_result.Clear();
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
                //button15.PerformClick();    Ligmedtegnet
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            labelCurrentOperation.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = " ";
        }

        private void button_Click10(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
            }
            resultValue = Double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = " ";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
