using System;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    partial class CreateReceipt
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
            this.Label_TableName = new ConsoleApplication5.Standard_Label();
            this.Button_OtherLibrary = new ConsoleApplication5.Std_Button();
            this.Flow_DrinksCats = new ConsoleApplication5.StartPageProductViewer();
            this.Flow_FoodCats = new ConsoleApplication5.StartPageProductViewer();
            this.Button_BackToTable = new ConsoleApplication5.Back_Button();
            this.Button_Done = new ConsoleApplication5.DoneButton();
            this.Button_Comment = new ConsoleApplication5.CreateReceiptGreyButtons();
            this.Button_PrintBill = new ConsoleApplication5.CreateReceiptGreyButtons();
            this.Label_HeadLineFood = new ConsoleApplication5.Standard_Label();
            this.Label_HeadlineDrinks = new ConsoleApplication5.Standard_Label();
            this.Pay_Button = new ConsoleApplication5.Pay_Button();
            this.tempReceipt1 = new ConsoleApplication5.TempReceipt();
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
            this.panel1.Size = new System.Drawing.Size(435, 61);
            this.panel1.TabIndex = 12;
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
            // Button_OtherLibrary
            // 
            this.Button_OtherLibrary.BackColor = System.Drawing.Color.Transparent;
            this.Button_OtherLibrary.BackgroundImage = global::ConsoleApplication5.Properties.Resources.Product;
            this.Button_OtherLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_OtherLibrary.Image_set = null;
            this.Button_OtherLibrary.Location = new System.Drawing.Point(902, 757);
            this.Button_OtherLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_OtherLibrary.Name = "Button_OtherLibrary";
            this.Button_OtherLibrary.Size = new System.Drawing.Size(154, 61);
            this.Button_OtherLibrary.TabIndex = 17;
            this.Button_OtherLibrary.Textlabel = "OTHER";
            this.Button_OtherLibrary.Button_Click += new System.EventHandler(this.Button_OtherLibrary_Button_Click);
            // 
            // Flow_DrinksCats
            // 
            this.Flow_DrinksCats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flow_DrinksCats.BackColor = System.Drawing.Color.Transparent;
            this.Flow_DrinksCats.Location = new System.Drawing.Point(478, 120);
            this.Flow_DrinksCats.MainCategory = null;
            this.Flow_DrinksCats.Name = "Flow_DrinksCats";
            this.Flow_DrinksCats.Size = new System.Drawing.Size(504, 617);
            this.Flow_DrinksCats.TabIndex = 16;
            // 
            // Flow_FoodCats
            // 
            this.Flow_FoodCats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flow_FoodCats.BackColor = System.Drawing.Color.Transparent;
            this.Flow_FoodCats.Location = new System.Drawing.Point(1004, 120);
            this.Flow_FoodCats.MainCategory = null;
            this.Flow_FoodCats.Name = "Flow_FoodCats";
            this.Flow_FoodCats.Size = new System.Drawing.Size(504, 617);
            this.Flow_FoodCats.TabIndex = 15;
            // 
            // Button_BackToTable
            // 
            this.Button_BackToTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_BackToTable.BackColor = System.Drawing.Color.Transparent;
            this.Button_BackToTable.Image_set = null;
            this.Button_BackToTable.Location = new System.Drawing.Point(1220, 767);
            this.Button_BackToTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_BackToTable.Name = "Button_BackToTable";
            this.Button_BackToTable.Size = new System.Drawing.Size(122, 53);
            this.Button_BackToTable.TabIndex = 13;
            this.Button_BackToTable.Textlabel = "BACK";
            this.Button_BackToTable.Visible = false;
            this.Button_BackToTable.Load += new System.EventHandler(this.Button_BackToTable_Load);
            // 
            // Button_Done
            // 
            this.Button_Done.BackColor = System.Drawing.Color.Transparent;
            this.Button_Done.Image_set = null;
            this.Button_Done.Location = new System.Drawing.Point(247, 685);
            this.Button_Done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Done.Name = "Button_Done";
            this.Button_Done.Size = new System.Drawing.Size(206, 78);
            this.Button_Done.TabIndex = 11;
            this.Button_Done.Textlabel = "DONE";
            // 
            // Button_Comment
            // 
            this.Button_Comment.BackColor = System.Drawing.Color.Transparent;
            this.Button_Comment.Image_set = null;
            this.Button_Comment.Location = new System.Drawing.Point(35, 685);
            this.Button_Comment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Comment.Name = "Button_Comment";
            this.Button_Comment.Size = new System.Drawing.Size(206, 78);
            this.Button_Comment.TabIndex = 10;
            this.Button_Comment.Textlabel = "COMMENT";
            // 
            // Button_PrintBill
            // 
            this.Button_PrintBill.BackColor = System.Drawing.Color.Transparent;
            this.Button_PrintBill.Image_set = null;
            this.Button_PrintBill.Location = new System.Drawing.Point(35, 767);
            this.Button_PrintBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_PrintBill.Name = "Button_PrintBill";
            this.Button_PrintBill.Size = new System.Drawing.Size(206, 78);
            this.Button_PrintBill.TabIndex = 9;
            this.Button_PrintBill.Textlabel = "PRINT";
            // 
            // Label_HeadLineFood
            // 
            this.Label_HeadLineFood.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadLineFood.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadLineFood.Location = new System.Drawing.Point(472, 63);
            this.Label_HeadLineFood.Name = "Label_HeadLineFood";
            this.Label_HeadLineFood.Size = new System.Drawing.Size(504, 54);
            this.Label_HeadLineFood.TabIndex = 8;
            this.Label_HeadLineFood.Text = "FOOD";
            this.Label_HeadLineFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_HeadlineDrinks
            // 
            this.Label_HeadlineDrinks.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadlineDrinks.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadlineDrinks.Location = new System.Drawing.Point(982, 63);
            this.Label_HeadlineDrinks.Name = "Label_HeadlineDrinks";
            this.Label_HeadlineDrinks.Size = new System.Drawing.Size(526, 54);
            this.Label_HeadlineDrinks.TabIndex = 7;
            this.Label_HeadlineDrinks.Text = "DRINKS";
            this.Label_HeadlineDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pay_Button
            // 
            this.Pay_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pay_Button.Image_set = null;
            this.Pay_Button.Location = new System.Drawing.Point(247, 767);
            this.Pay_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pay_Button.Name = "Pay_Button";
            this.Pay_Button.Size = new System.Drawing.Size(206, 78);
            this.Pay_Button.TabIndex = 6;
            this.Pay_Button.Textlabel = "PAY";
            // 
            // tempReceipt1
            // 
            this.tempReceipt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempReceipt1.Location = new System.Drawing.Point(28, 120);
            this.tempReceipt1.Name = "tempReceipt1";
            this.tempReceipt1.Size = new System.Drawing.Size(435, 560);
            this.tempReceipt1.TabIndex = 4;
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.White;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(0, 0);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(1536, 50);
            this.timerInfo1.TabIndex = 1;
            this.timerInfo1.tablename = null;
            // 
            // TEST
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Button_OtherLibrary);
            this.Controls.Add(this.Flow_DrinksCats);
            this.Controls.Add(this.Flow_FoodCats);
            this.Controls.Add(this.Button_BackToTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Done);
            this.Controls.Add(this.Button_Comment);
            this.Controls.Add(this.Button_PrintBill);
            this.Controls.Add(this.Label_HeadLineFood);
            this.Controls.Add(this.Label_HeadlineDrinks);
            this.Controls.Add(this.Pay_Button);
            this.Controls.Add(this.tempReceipt1);
            this.Controls.Add(this.timerInfo1);
            this.Name = "TEST";
            this.Size = new System.Drawing.Size(1536, 864);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TimerInfo timerInfo1;
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
        public StartPageProductViewer Flow_FoodCats;
        public StartPageProductViewer Flow_DrinksCats;
        private Std_Button Button_OtherLibrary;
    }
}
