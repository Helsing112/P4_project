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
    public partial class CommentToReceiptWindow : Standard_Window_Layout
    {
       
        public string Text { get; set; }
        public string Comment { get; private set; }

        public CommentToReceiptWindow(string comment)
        {
            InitializeComponent();
            this.Comment= comment;

            if (Comment == null)
            {
                CommentTextBox.Text = "";
            }
            else if (Comment != null)
            {
                CommentTextBox.Text = (Comment + "\n");
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
            Text = CommentTextBox.Text;
            Messages.CommentAdded();
            this.Close();

        }

        private void CommentTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
