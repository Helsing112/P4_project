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
            this.Button_BackToTable = new ConsoleApplication5.Back_Button();
            this.Label_TableName = new ConsoleApplication5.Standard_Label();
            this.Button_Done = new ConsoleApplication5.DoneButton();
            this.Button_Comment = new ConsoleApplication5.CreateReceiptGreyButtons();
            this.Button_PrintBill = new ConsoleApplication5.CreateReceiptGreyButtons();
            this.Label_HeadLineFood = new ConsoleApplication5.Standard_Label();
            this.Label_HeadlineDrinks = new ConsoleApplication5.Standard_Label();
            this.Pay_Button = new ConsoleApplication5.Pay_Button();
            this.tempReceipt1 = new ConsoleApplication5.TempReceipt();
            this.ProductView_Foods = new ConsoleApplication5.SuperClassProductViewer();
            this.ProductView_Drinks = new ConsoleApplication5.SuperClassProductViewer();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label_TableName);
            this.panel1.Location = new System.Drawing.Point(28, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 61);
            this.panel1.TabIndex = 12;
            // 
            // Button_BackToTable
            // 
            this.Button_BackToTable.BackColor = System.Drawing.Color.Transparent;
            this.Button_BackToTable.Image_set = null;
            this.Button_BackToTable.Location = new System.Drawing.Point(1710, 963);
            this.Button_BackToTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_BackToTable.Name = "Button_BackToTable";
            this.Button_BackToTable.Size = new System.Drawing.Size(187, 79);
            this.Button_BackToTable.TabIndex = 13;
            this.Button_BackToTable.Textlabel = "BACK";
            // 
            // Label_TableName
            // 
            this.Label_TableName.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_TableName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_TableName.ForeColor = System.Drawing.Color.Black;
            this.Label_TableName.Location = new System.Drawing.Point(0, 0);
            this.Label_TableName.Name = "Label_TableName";
            this.Label_TableName.Size = new System.Drawing.Size(249, 59);
            this.Label_TableName.TabIndex = 0;
            this.Label_TableName.Text = "TABLE";
            this.Label_TableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button_Done
            // 
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.Image_set = null;
            this.Button_Done.Location = new System.Drawing.Point(288, 808);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(250, 105);
            this.Button_Done.TabIndex = 11;
            this.Button_Done.Textlabel = "DONE";
            // 
            // Button_Comment
            // 
            this.Button_Comment.BackColor = System.Drawing.Color.Transparent;
            this.Button_Comment.Image_set = null;
            this.Button_Comment.Location = new System.Drawing.Point(28, 808);
            this.Button_Comment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Comment.Name = "Button_Comment";
            this.Button_Comment.Size = new System.Drawing.Size(250, 105);
            this.Button_Comment.TabIndex = 10;
            this.Button_Comment.Textlabel = "COMMENT";
            // 
            // Button_PrintBill
            // 
            this.Button_PrintBill.BackColor = System.Drawing.Color.Transparent;
            this.Button_PrintBill.Image_set = null;
            this.Button_PrintBill.Location = new System.Drawing.Point(28, 917);
            this.Button_PrintBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_PrintBill.Name = "Button_PrintBill";
            this.Button_PrintBill.Size = new System.Drawing.Size(250, 105);
            this.Button_PrintBill.TabIndex = 9;
            this.Button_PrintBill.Textlabel = "PRINT";
            // 
            // Label_HeadLineFood
            // 
            this.Label_HeadLineFood.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadLineFood.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadLineFood.Location = new System.Drawing.Point(587, 75);
            this.Label_HeadLineFood.Name = "Label_HeadLineFood";
            this.Label_HeadLineFood.Size = new System.Drawing.Size(647, 35);
            this.Label_HeadLineFood.TabIndex = 8;
            this.Label_HeadLineFood.Text = "FOOD";
            this.Label_HeadLineFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_HeadlineDrinks
            // 
            this.Label_HeadlineDrinks.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadlineDrinks.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadlineDrinks.Location = new System.Drawing.Point(1250, 75);
            this.Label_HeadlineDrinks.Name = "Label_HeadlineDrinks";
            this.Label_HeadlineDrinks.Size = new System.Drawing.Size(647, 35);
            this.Label_HeadlineDrinks.TabIndex = 7;
            this.Label_HeadlineDrinks.Text = "DRINKS";
            this.Label_HeadlineDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pay_Button
            // 
            this.Pay_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pay_Button.Image_set = null;
            this.Pay_Button.Location = new System.Drawing.Point(288, 917);
            this.Pay_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pay_Button.Name = "Pay_Button";
            this.Pay_Button.Size = new System.Drawing.Size(250, 105);
            this.Pay_Button.TabIndex = 6;
            this.Pay_Button.Textlabel = "PAY";
            // 
            // tempReceipt1
            // 
            this.tempReceipt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempReceipt1.Location = new System.Drawing.Point(28, 120);
            this.tempReceipt1.Name = "tempReceipt1";
            this.tempReceipt1.Size = new System.Drawing.Size(531, 666);
            this.tempReceipt1.TabIndex = 4;
            // 
            // ProductView_Foods
            // 
            this.ProductView_Foods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductView_Foods.Location = new System.Drawing.Point(587, 120);
            this.ProductView_Foods.Margin = new System.Windows.Forms.Padding(0);
            this.ProductView_Foods.Name = "ProductView_Foods";
            this.ProductView_Foods.Size = new System.Drawing.Size(647, 814);
            this.ProductView_Foods.TabIndex = 3;
            // 
            // ProductView_Drinks
            // 
            this.ProductView_Drinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductView_Drinks.Location = new System.Drawing.Point(1250, 120);
            this.ProductView_Drinks.Margin = new System.Windows.Forms.Padding(0);
            this.ProductView_Drinks.Name = "ProductView_Drinks";
            this.ProductView_Drinks.Size = new System.Drawing.Size(647, 814);
            this.ProductView_Drinks.TabIndex = 2;
            // 
            // timerInfo1
            // 
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(0, 0);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(1920, 55);
            this.timerInfo1.TabIndex = 1;
            this.timerInfo1.tablename = null;
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_BackToTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Done);
            this.Controls.Add(this.Button_Comment);
            this.Controls.Add(this.Button_PrintBill);
            this.Controls.Add(this.Label_HeadLineFood);
            this.Controls.Add(this.Label_HeadlineDrinks);
            this.Controls.Add(this.Pay_Button);
            this.Controls.Add(this.tempReceipt1);
            this.Controls.Add(this.ProductView_Foods);
            this.Controls.Add(this.ProductView_Drinks);
            this.Controls.Add(this.timerInfo1);
            this.Name = "TEST";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TimerInfo timerInfo1;
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
    }
}
