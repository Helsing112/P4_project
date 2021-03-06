﻿using System;
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
    public partial class CommentToReceiptWindow : Standard_Window_Layout
    {
       
        public string Text { get { return Current_text; } private set { Current_text = value + Environment.NewLine; } }
        public string Comment { get; private set; }

        private string Current_text;

        public CommentToReceiptWindow(string comment)
        {
            InitializeComponent();
            textBox_Touch1.textBox1.Size = textBox_Touch1.Size;
            textBox_Touch1.textBox1.Multiline = true;
            this.Current_text = comment;

            if (Current_text == "")
            {
                textBox_Touch1.textBox1.Text = "";
            }
            else if (Current_text != "")
            {
                textBox_Touch1.textBox1.Text = Current_text;
                //CommentTextBox.SelectionLength = 0;
                SendKeys.Send("{DOWN}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            Text = textBox_Touch1.textBox1.Text;
            Messages.CommentAdded();
            this.Close();

        }

        private void CommentTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
