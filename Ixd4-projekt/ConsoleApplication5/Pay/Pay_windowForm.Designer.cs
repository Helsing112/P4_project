using System;

namespace ConsoleApplication5
{
    partial class Pay_windowForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_numpad = new System.Windows.Forms.Panel();
            this.discount_buttons2 = new ConsoleApplication5.Discount_buttons();
            this.Button_clear = new ConsoleApplication5.Discount_buttons();
            this.Label_EnteredAmount = new ConsoleApplication5.Standard_Label();
            this.button_num_decimalPt = new ConsoleApplication5.Numpad_button();
            this.button_num_3 = new ConsoleApplication5.Numpad_button();
            this.button_num_6 = new ConsoleApplication5.Numpad_button();
            this.button_num_9 = new ConsoleApplication5.Numpad_button();
            this.button_num_2 = new ConsoleApplication5.Numpad_button();
            this.button_num_1 = new ConsoleApplication5.Numpad_button();
            this.button_num_0 = new ConsoleApplication5.Numpad_button();
            this.button_num_4 = new ConsoleApplication5.Numpad_button();
            this.button_num_5 = new ConsoleApplication5.Numpad_button();
            this.button_num_8 = new ConsoleApplication5.Numpad_button();
            this.button_num_7 = new ConsoleApplication5.Numpad_button();
            this.Button_pay = new ConsoleApplication5.Pay_Button();
            this.Panel_quit = new System.Windows.Forms.Panel();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.panel_Split = new System.Windows.Forms.Panel();
            this.split_button1 = new ConsoleApplication5.Split_button();
            this.Label_totalText = new ConsoleApplication5.Standard_Label();
            this.label_paidText = new ConsoleApplication5.Standard_Label();
            this.label_remaingingText = new ConsoleApplication5.Standard_Label();
            this.Label_total_Number = new ConsoleApplication5.Standard_Label();
            this.Label_Paid_number = new ConsoleApplication5.Standard_Label();
            this.Label_Remain_Number = new ConsoleApplication5.Standard_Label();
            this.Panel_receipt = new System.Windows.Forms.Panel();
            this.Flow_receiptMain = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_tableInfo = new ConsoleApplication5.Standard_Label();
            this.Panel_numpad.SuspendLayout();
            this.Panel_quit.SuspendLayout();
            this.panel_Split.SuspendLayout();
            this.Panel_receipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_numpad
            // 
            this.Panel_numpad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_numpad.Controls.Add(this.Button_pay);
            this.Panel_numpad.Controls.Add(this.discount_buttons2);
            this.Panel_numpad.Controls.Add(this.Button_clear);
            this.Panel_numpad.Controls.Add(this.Label_EnteredAmount);
            this.Panel_numpad.Controls.Add(this.button_num_decimalPt);
            this.Panel_numpad.Controls.Add(this.button_num_3);
            this.Panel_numpad.Controls.Add(this.button_num_6);
            this.Panel_numpad.Controls.Add(this.button_num_9);
            this.Panel_numpad.Controls.Add(this.button_num_2);
            this.Panel_numpad.Controls.Add(this.button_num_1);
            this.Panel_numpad.Controls.Add(this.button_num_0);
            this.Panel_numpad.Controls.Add(this.button_num_4);
            this.Panel_numpad.Controls.Add(this.button_num_5);
            this.Panel_numpad.Controls.Add(this.button_num_8);
            this.Panel_numpad.Controls.Add(this.button_num_7);
            this.Panel_numpad.Location = new System.Drawing.Point(401, 44);
            this.Panel_numpad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_numpad.Name = "Panel_numpad";
            this.Panel_numpad.Size = new System.Drawing.Size(341, 426);
            this.Panel_numpad.TabIndex = 0;
            // 
            // discount_buttons2
            // 
            this.discount_buttons2.BackColor = System.Drawing.Color.Transparent;
            this.discount_buttons2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_buttons2.Image_set = null;
            this.discount_buttons2.Location = new System.Drawing.Point(252, 65);
            this.discount_buttons2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discount_buttons2.Name = "discount_buttons2";
            this.discount_buttons2.Size = new System.Drawing.Size(85, 134);
            this.discount_buttons2.TabIndex = 14;
            this.discount_buttons2.Textlabel = "%";
            // 
            // Button_clear
            // 
            this.Button_clear.BackColor = System.Drawing.Color.Transparent;
            this.Button_clear.Image_set = null;
            this.Button_clear.Location = new System.Drawing.Point(251, 203);
            this.Button_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_clear.Name = "Button_clear";
            this.Button_clear.Size = new System.Drawing.Size(86, 132);
            this.Button_clear.TabIndex = 13;
            this.Button_clear.Textlabel = "CLEAR";
            // 
            // Label_EnteredAmount
            // 
            this.Label_EnteredAmount.BackColor = System.Drawing.Color.White;
            this.Label_EnteredAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_EnteredAmount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_EnteredAmount.ForeColor = System.Drawing.Color.Black;
            this.Label_EnteredAmount.Location = new System.Drawing.Point(0, 0);
            this.Label_EnteredAmount.Name = "Label_EnteredAmount";
            this.Label_EnteredAmount.Size = new System.Drawing.Size(341, 57);
            this.Label_EnteredAmount.TabIndex = 11;
            this.Label_EnteredAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_num_decimalPt
            // 
            this.button_num_decimalPt.BackColor = System.Drawing.Color.Transparent;
            this.button_num_decimalPt.Button_Amount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.button_num_decimalPt.Image_set = null;
            this.button_num_decimalPt.Location = new System.Drawing.Point(168, 272);
            this.button_num_decimalPt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_decimalPt.Name = "button_num_decimalPt";
            this.button_num_decimalPt.Size = new System.Drawing.Size(77, 65);
            this.button_num_decimalPt.TabIndex = 10;
            this.button_num_decimalPt.Textlabel = ".";
            // 
            // button_num_3
            // 
            this.button_num_3.BackColor = System.Drawing.Color.Transparent;
            this.button_num_3.Button_Amount = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.button_num_3.Image_set = null;
            this.button_num_3.Location = new System.Drawing.Point(168, 203);
            this.button_num_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_3.Name = "button_num_3";
            this.button_num_3.Size = new System.Drawing.Size(77, 65);
            this.button_num_3.TabIndex = 9;
            this.button_num_3.Textlabel = "3";
            // 
            // button_num_6
            // 
            this.button_num_6.BackColor = System.Drawing.Color.Transparent;
            this.button_num_6.Button_Amount = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.button_num_6.Image_set = null;
            this.button_num_6.Location = new System.Drawing.Point(168, 134);
            this.button_num_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_6.Name = "button_num_6";
            this.button_num_6.Size = new System.Drawing.Size(77, 65);
            this.button_num_6.TabIndex = 8;
            this.button_num_6.Textlabel = "6";
            // 
            // button_num_9
            // 
            this.button_num_9.BackColor = System.Drawing.Color.Transparent;
            this.button_num_9.Button_Amount = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.button_num_9.Image_set = null;
            this.button_num_9.Location = new System.Drawing.Point(168, 65);
            this.button_num_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_9.Name = "button_num_9";
            this.button_num_9.Size = new System.Drawing.Size(77, 65);
            this.button_num_9.TabIndex = 7;
            this.button_num_9.Textlabel = "9";
            // 
            // button_num_2
            // 
            this.button_num_2.BackColor = System.Drawing.Color.Transparent;
            this.button_num_2.Button_Amount = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.button_num_2.Image_set = null;
            this.button_num_2.Location = new System.Drawing.Point(84, 203);
            this.button_num_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_2.Name = "button_num_2";
            this.button_num_2.Size = new System.Drawing.Size(77, 65);
            this.button_num_2.TabIndex = 6;
            this.button_num_2.Textlabel = "2";
            // 
            // button_num_1
            // 
            this.button_num_1.BackColor = System.Drawing.Color.Transparent;
            this.button_num_1.Button_Amount = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.button_num_1.Image_set = null;
            this.button_num_1.Location = new System.Drawing.Point(0, 203);
            this.button_num_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_1.Name = "button_num_1";
            this.button_num_1.Size = new System.Drawing.Size(77, 65);
            this.button_num_1.TabIndex = 5;
            this.button_num_1.Textlabel = "1";
            // 
            // button_num_0
            // 
            this.button_num_0.BackColor = System.Drawing.Color.Transparent;
            this.button_num_0.Button_Amount = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.button_num_0.Image_set = null;
            this.button_num_0.Location = new System.Drawing.Point(0, 272);
            this.button_num_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_0.Name = "button_num_0";
            this.button_num_0.Size = new System.Drawing.Size(163, 65);
            this.button_num_0.TabIndex = 4;
            this.button_num_0.Textlabel = "0";
            // 
            // button_num_4
            // 
            this.button_num_4.BackColor = System.Drawing.Color.Transparent;
            this.button_num_4.Button_Amount = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.button_num_4.Image_set = null;
            this.button_num_4.Location = new System.Drawing.Point(0, 134);
            this.button_num_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_4.Name = "button_num_4";
            this.button_num_4.Size = new System.Drawing.Size(77, 65);
            this.button_num_4.TabIndex = 3;
            this.button_num_4.Textlabel = "4";
            // 
            // button_num_5
            // 
            this.button_num_5.BackColor = System.Drawing.Color.Transparent;
            this.button_num_5.Button_Amount = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.button_num_5.Image_set = null;
            this.button_num_5.Location = new System.Drawing.Point(84, 134);
            this.button_num_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_5.Name = "button_num_5";
            this.button_num_5.Size = new System.Drawing.Size(77, 65);
            this.button_num_5.TabIndex = 2;
            this.button_num_5.Textlabel = "5";
            // 
            // button_num_8
            // 
            this.button_num_8.BackColor = System.Drawing.Color.Transparent;
            this.button_num_8.Button_Amount = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.button_num_8.Image_set = null;
            this.button_num_8.Location = new System.Drawing.Point(84, 65);
            this.button_num_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_8.Name = "button_num_8";
            this.button_num_8.Size = new System.Drawing.Size(77, 65);
            this.button_num_8.TabIndex = 1;
            this.button_num_8.Textlabel = "8";
            // 
            // button_num_7
            // 
            this.button_num_7.BackColor = System.Drawing.Color.Transparent;
            this.button_num_7.Button_Amount = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.button_num_7.Image_set = null;
            this.button_num_7.Location = new System.Drawing.Point(0, 65);
            this.button_num_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_num_7.Name = "button_num_7";
            this.button_num_7.Size = new System.Drawing.Size(77, 65);
            this.button_num_7.TabIndex = 0;
            this.button_num_7.Textlabel = "7";
            // 
            // Button_pay
            // 
            this.Button_pay.BackColor = System.Drawing.Color.Transparent;
            this.Button_pay.Image_set = null;
            this.Button_pay.Location = new System.Drawing.Point(167, 348);
            this.Button_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_pay.Name = "Button_pay";
            this.Button_pay.Size = new System.Drawing.Size(169, 76);
            this.Button_pay.TabIndex = 12;
            this.Button_pay.Textlabel = "PAY";
            // 
            // Panel_quit
            // 
            this.Panel_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_quit.Controls.Add(this.quit_Close_Button1);
            this.Panel_quit.Location = new System.Drawing.Point(614, 501);
            this.Panel_quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_quit.Name = "Panel_quit";
            this.Panel_quit.Size = new System.Drawing.Size(128, 60);
            this.Panel_quit.TabIndex = 3;
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(0, 0);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(128, 60);
            this.quit_Close_Button1.TabIndex = 0;
            this.quit_Close_Button1.Textlabel = "QUIT";
            // 
            // panel_Split
            // 
            this.panel_Split.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Split.Controls.Add(this.split_button1);
            this.panel_Split.Location = new System.Drawing.Point(399, 389);
            this.panel_Split.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Split.Name = "panel_Split";
            this.panel_Split.Size = new System.Drawing.Size(163, 81);
            this.panel_Split.TabIndex = 4;
            // 
            // split_button1
            // 
            this.split_button1.BackColor = System.Drawing.Color.Transparent;
            this.split_button1.Image_set = null;
            this.split_button1.Location = new System.Drawing.Point(0, -2);
            this.split_button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.split_button1.Name = "split_button1";
            this.split_button1.Size = new System.Drawing.Size(163, 81);
            this.split_button1.TabIndex = 0;
            this.split_button1.Textlabel = "SPLIT BILL";
            // 
            // Label_totalText
            // 
            this.Label_totalText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_totalText.AutoSize = true;
            this.Label_totalText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Label_totalText.ForeColor = System.Drawing.Color.Black;
            this.Label_totalText.Location = new System.Drawing.Point(188, 473);
            this.Label_totalText.Name = "Label_totalText";
            this.Label_totalText.Size = new System.Drawing.Size(64, 28);
            this.Label_totalText.TabIndex = 5;
            this.Label_totalText.Text = "Total:";
            this.Label_totalText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_paidText
            // 
            this.label_paidText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_paidText.AutoSize = true;
            this.label_paidText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_paidText.ForeColor = System.Drawing.Color.Black;
            this.label_paidText.Location = new System.Drawing.Point(193, 501);
            this.label_paidText.Name = "label_paidText";
            this.label_paidText.Size = new System.Drawing.Size(58, 28);
            this.label_paidText.TabIndex = 6;
            this.label_paidText.Text = "Paid:";
            // 
            // label_remaingingText
            // 
            this.label_remaingingText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_remaingingText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_remaingingText.ForeColor = System.Drawing.Color.Black;
            this.label_remaingingText.Location = new System.Drawing.Point(111, 528);
            this.label_remaingingText.Name = "label_remaingingText";
            this.label_remaingingText.Size = new System.Drawing.Size(149, 31);
            this.label_remaingingText.TabIndex = 7;
            this.label_remaingingText.Text = "Remaining:";
            this.label_remaingingText.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label_total_Number
            // 
            this.Label_total_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_total_Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Label_total_Number.ForeColor = System.Drawing.Color.Black;
            this.Label_total_Number.Location = new System.Drawing.Point(255, 473);
            this.Label_total_Number.Name = "Label_total_Number";
            this.Label_total_Number.Size = new System.Drawing.Size(123, 28);
            this.Label_total_Number.TabIndex = 8;
            this.Label_total_Number.Text = "0,00";
            this.Label_total_Number.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Paid_number
            // 
            this.Label_Paid_number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Paid_number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Paid_number.ForeColor = System.Drawing.Color.Black;
            this.Label_Paid_number.Location = new System.Drawing.Point(249, 501);
            this.Label_Paid_number.Name = "Label_Paid_number";
            this.Label_Paid_number.Size = new System.Drawing.Size(128, 28);
            this.Label_Paid_number.TabIndex = 9;
            this.Label_Paid_number.Text = "0,00";
            this.Label_Paid_number.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Remain_Number
            // 
            this.Label_Remain_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Remain_Number.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Label_Remain_Number.ForeColor = System.Drawing.Color.Black;
            this.Label_Remain_Number.Location = new System.Drawing.Point(251, 528);
            this.Label_Remain_Number.Name = "Label_Remain_Number";
            this.Label_Remain_Number.Size = new System.Drawing.Size(127, 32);
            this.Label_Remain_Number.TabIndex = 10;
            this.Label_Remain_Number.Text = "0,00";
            this.Label_Remain_Number.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel_receipt
            // 
            this.Panel_receipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_receipt.Controls.Add(this.Flow_receiptMain);
            this.Panel_receipt.Controls.Add(this.Label_tableInfo);
            this.Panel_receipt.Location = new System.Drawing.Point(16, 12);
            this.Panel_receipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_receipt.Name = "Panel_receipt";
            this.Panel_receipt.Size = new System.Drawing.Size(361, 458);
            this.Panel_receipt.TabIndex = 12;
            // 
            // Flow_receiptMain
            // 
            this.Flow_receiptMain.BackColor = System.Drawing.Color.White;
            this.Flow_receiptMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Flow_receiptMain.Location = new System.Drawing.Point(0, 32);
            this.Flow_receiptMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Flow_receiptMain.Name = "Flow_receiptMain";
            this.Flow_receiptMain.Size = new System.Drawing.Size(361, 426);
            this.Flow_receiptMain.TabIndex = 1;
            // 
            // Label_tableInfo
            // 
            this.Label_tableInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_tableInfo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.Label_tableInfo.ForeColor = System.Drawing.Color.Black;
            this.Label_tableInfo.Location = new System.Drawing.Point(0, 0);
            this.Label_tableInfo.Name = "Label_tableInfo";
            this.Label_tableInfo.Size = new System.Drawing.Size(361, 30);
            this.Label_tableInfo.TabIndex = 0;
            this.Label_tableInfo.Text = "Table ";
            this.Label_tableInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pay_windowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 570);
            this.Controls.Add(this.Panel_receipt);
            this.Controls.Add(this.Label_Remain_Number);
            this.Controls.Add(this.Label_Paid_number);
            this.Controls.Add(this.Label_total_Number);
            this.Controls.Add(this.label_remaingingText);
            this.Controls.Add(this.label_paidText);
            this.Controls.Add(this.Label_totalText);
            this.Controls.Add(this.panel_Split);
            this.Controls.Add(this.Panel_quit);
            this.Controls.Add(this.Panel_numpad);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Pay_windowForm";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "Pay_windowForm";
            this.Load += new System.EventHandler(this.Pay_windowForm_Load);
            this.Panel_numpad.ResumeLayout(false);
            this.Panel_quit.ResumeLayout(false);
            this.panel_Split.ResumeLayout(false);
            this.Panel_receipt.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel Panel_numpad;
        private Numpad_button button_num_decimalPt;
        private Numpad_button button_num_3;
        private Numpad_button button_num_6;
        private Numpad_button button_num_9;
        private Numpad_button button_num_2;
        private Numpad_button button_num_1;
        private Numpad_button button_num_0;
        private Numpad_button button_num_4;
        private Numpad_button button_num_5;
        private Numpad_button button_num_8;
        private Numpad_button button_num_7;
        private Standard_Label Label_EnteredAmount;
        private Pay_Button Button_pay;
        private Discount_buttons discount_buttons2;
        private Discount_buttons Button_clear;
        private System.Windows.Forms.Panel Panel_quit;
        private Quit_Close_Button quit_Close_Button1;
        private System.Windows.Forms.Panel panel_Split;
        private Split_button split_button1;
        private  Standard_Label Label_totalText;
        private  Standard_Label label_paidText;
        private  Standard_Label label_remaingingText;
        private  Standard_Label Label_total_Number;
        private  Standard_Label Label_Paid_number;
        private  Standard_Label Label_Remain_Number;
        private System.Windows.Forms.Panel Panel_receipt;
        private System.Windows.Forms.FlowLayoutPanel Flow_receiptMain;
        private Standard_Label Label_tableInfo;
    }
}