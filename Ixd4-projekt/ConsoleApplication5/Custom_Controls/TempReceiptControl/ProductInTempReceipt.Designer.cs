﻿namespace ConsoleApplication5
{
    partial class ProductInTempReceipt<T> where T :Product
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



        private System.Windows.Forms.Label Namel_label;
        private System.Windows.Forms.Label Price_label;
    }
}
