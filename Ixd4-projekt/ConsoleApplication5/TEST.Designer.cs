using System;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    partial class TEST
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.Label_TableName = new ConsoleApplication5.Standard_Label();
            this.Label_HeadlineDrinks = new ConsoleApplication5.Standard_Label();
            this.Label_HeadLineFood = new ConsoleApplication5.Standard_Label();
            this.tempReceipt1 = new ConsoleApplication5.TempReceipt();
            this.Button_Comment = new ConsoleApplication5.CreateReceiptGreyButtons();
            this.Button_PrintBill = new ConsoleApplication5.CreateReceiptGreyButtons();
            this.Button_Done = new ConsoleApplication5.DoneButton();
            this.Pay_Button = new ConsoleApplication5.Pay_Button();
            this.ProductView_Foods = new ConsoleApplication5.SuperClassProductViewer();
            this.ProductView_Drinks = new ConsoleApplication5.SuperClassProductViewer();
            this.Button_BackToTable = new ConsoleApplication5.Back_Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label_TableName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 149);
            this.panel1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.22656F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.45313F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_HeadlineDrinks, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Label_HeadLineFood, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tempReceipt1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ProductView_Foods, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProductView_Drinks, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.92709F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.11198F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2560, 1600);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Button_Comment, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Button_PrintBill, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Button_Done, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Pay_Button, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1232);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(847, 365);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Button_BackToTable);
            this.panel2.Location = new System.Drawing.Point(2313, 1462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 135);
            this.panel2.TabIndex = 14;
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.White;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(0, 0);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(6);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(2560, 50);
            this.timerInfo1.TabIndex = 1;
            this.timerInfo1.tablename = null;
            // 
            // Label_TableName
            // 
            this.Label_TableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_TableName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_TableName.ForeColor = System.Drawing.Color.Black;
            this.Label_TableName.Location = new System.Drawing.Point(0, 0);
            this.Label_TableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TableName.Name = "Label_TableName";
            this.Label_TableName.Size = new System.Drawing.Size(843, 147);
            this.Label_TableName.TabIndex = 0;
            this.Label_TableName.Text = "TABLE";
            this.Label_TableName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_HeadlineDrinks
            // 
            this.Label_HeadlineDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_HeadlineDrinks.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadlineDrinks.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadlineDrinks.Location = new System.Drawing.Point(1681, 0);
            this.Label_HeadlineDrinks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HeadlineDrinks.Name = "Label_HeadlineDrinks";
            this.Label_HeadlineDrinks.Size = new System.Drawing.Size(875, 159);
            this.Label_HeadlineDrinks.TabIndex = 7;
            this.Label_HeadlineDrinks.Text = "DRINKS";
            this.Label_HeadlineDrinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Label_HeadLineFood
            // 
            this.Label_HeadLineFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_HeadLineFood.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadLineFood.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadLineFood.Location = new System.Drawing.Point(857, 0);
            this.Label_HeadLineFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_HeadLineFood.Name = "Label_HeadLineFood";
            this.Label_HeadLineFood.Size = new System.Drawing.Size(816, 159);
            this.Label_HeadLineFood.TabIndex = 8;
            this.Label_HeadLineFood.Text = "FOOD";
            this.Label_HeadLineFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tempReceipt1
            // 
            this.tempReceipt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempReceipt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempReceipt1.Location = new System.Drawing.Point(4, 164);
            this.tempReceipt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tempReceipt1.Name = "tempReceipt1";
            this.tempReceipt1.Size = new System.Drawing.Size(845, 1060);
            this.tempReceipt1.TabIndex = 4;
            // 
            // Button_Comment
            // 
            this.Button_Comment.AutoSize = true;
            this.Button_Comment.BackColor = System.Drawing.Color.Transparent;
            this.Button_Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Comment.Image_set = null;
            this.Button_Comment.Location = new System.Drawing.Point(20, 20);
            this.Button_Comment.Margin = new System.Windows.Forms.Padding(20);
            this.Button_Comment.Name = "Button_Comment";
            this.Button_Comment.Size = new System.Drawing.Size(383, 142);
            this.Button_Comment.TabIndex = 10;
            this.Button_Comment.Textlabel = "COMMENT";
            // 
            // Button_PrintBill
            // 
            this.Button_PrintBill.BackColor = System.Drawing.Color.Transparent;
            this.Button_PrintBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_PrintBill.Image_set = null;
            this.Button_PrintBill.Location = new System.Drawing.Point(20, 202);
            this.Button_PrintBill.Margin = new System.Windows.Forms.Padding(20);
            this.Button_PrintBill.Name = "Button_PrintBill";
            this.Button_PrintBill.Size = new System.Drawing.Size(383, 143);
            this.Button_PrintBill.TabIndex = 9;
            this.Button_PrintBill.Textlabel = "PRINT";
            // 
            // Button_Done
            // 
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Done.Image_set = null;
            this.Button_Done.Location = new System.Drawing.Point(443, 20);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(20);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(384, 142);
            this.Button_Done.TabIndex = 11;
            this.Button_Done.Textlabel = "DONE";
            // 
            // Pay_Button
            // 
            this.Pay_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pay_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pay_Button.Image_set = null;
            this.Pay_Button.Location = new System.Drawing.Point(443, 202);
            this.Pay_Button.Margin = new System.Windows.Forms.Padding(20);
            this.Pay_Button.Name = "Pay_Button";
            this.Pay_Button.Size = new System.Drawing.Size(384, 143);
            this.Pay_Button.TabIndex = 6;
            this.Pay_Button.Textlabel = "PAY";
            // 
            // ProductView_Foods
            // 
            this.ProductView_Foods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductView_Foods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductView_Foods.Location = new System.Drawing.Point(1681, 164);
            this.ProductView_Foods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductView_Foods.Name = "ProductView_Foods";
            this.ProductView_Foods.Size = new System.Drawing.Size(875, 1060);
            this.ProductView_Foods.TabIndex = 3;
            // 
            // ProductView_Drinks
            // 
            this.ProductView_Drinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductView_Drinks.Location = new System.Drawing.Point(857, 164);
            this.ProductView_Drinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductView_Drinks.Name = "ProductView_Drinks";
            this.ProductView_Drinks.Size = new System.Drawing.Size(816, 1060);
            this.ProductView_Drinks.TabIndex = 2;
            // 
            // Button_BackToTable
            // 
            this.Button_BackToTable.BackColor = System.Drawing.Color.Transparent;
            this.Button_BackToTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_BackToTable.Image_set = null;
            this.Button_BackToTable.Location = new System.Drawing.Point(0, 0);
            this.Button_BackToTable.Margin = new System.Windows.Forms.Padding(20);
            this.Button_BackToTable.Name = "Button_BackToTable";
            this.Button_BackToTable.Size = new System.Drawing.Size(244, 135);
            this.Button_BackToTable.TabIndex = 13;
            this.Button_BackToTable.Textlabel = "BACK";
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timerInfo1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TEST";
            this.Size = new System.Drawing.Size(2560, 1600);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public SuperClassProductViewer ProductView_Drinks;
        public SuperClassProductViewer ProductView_Foods;
        public TempReceipt tempReceipt1;
        public Pay_Button Pay_Button;
        public Standard_Label Label_HeadlineDrinks;
        public Standard_Label Label_HeadLineFood;
        public CreateReceiptGreyButtons Button_PrintBill;
        public CreateReceiptGreyButtons Button_Comment;
        public DoneButton Button_Done;
        public Panel panel1;
        public Standard_Label Label_TableName;
        public Back_Button Button_BackToTable;
        public TimerInfo timerInfo1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
    }
}
