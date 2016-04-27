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
            this.ProductView_Foods = new ConsoleApplication5.SuperClassProductViewer();
            this.ProductView_Drinks = new ConsoleApplication5.SuperClassProductViewer();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.tempReceipt1 = new ConsoleApplication5.TempReceipt();
            this.SuspendLayout();
            // 
            // ProductView_Foods
            // 
            this.ProductView_Foods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductView_Foods.Location = new System.Drawing.Point(591, 173);
            this.ProductView_Foods.Margin = new System.Windows.Forms.Padding(0);
            this.ProductView_Foods.Name = "ProductView_Foods";
            this.ProductView_Foods.Size = new System.Drawing.Size(647, 814);
            this.ProductView_Foods.TabIndex = 3;
            // 
            // ProductView_Drinks
            // 
            this.ProductView_Drinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductView_Drinks.Location = new System.Drawing.Point(1254, 173);
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
            this.timerInfo1.Size = new System.Drawing.Size(1920, 46);
            this.timerInfo1.TabIndex = 1;
            this.timerInfo1.tablename = null;
            // 
            // tempReceipt1
            // 
            this.tempReceipt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempReceipt1.Location = new System.Drawing.Point(14, 173);
            this.tempReceipt1.Name = "tempReceipt1";
            this.tempReceipt1.Size = new System.Drawing.Size(531, 791);
            this.tempReceipt1.TabIndex = 4;
            // 
            // TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tempReceipt1);
            this.Controls.Add(this.ProductView_Foods);
            this.Controls.Add(this.ProductView_Drinks);
            this.Controls.Add(this.timerInfo1);
            this.Name = "TEST";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        private TimerInfo timerInfo1;
        private SuperClassProductViewer ProductView_Drinks;
        private SuperClassProductViewer ProductView_Foods;
        private TempReceipt tempReceipt1;
    }
}
