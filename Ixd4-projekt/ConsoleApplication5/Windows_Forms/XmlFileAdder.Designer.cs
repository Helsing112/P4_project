using System;
using System.Windows.Forms;
namespace ConsoleApplication5
{
    partial class XmlFileAdder
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.add_Button1 = new ConsoleApplication5.Add_Button();
            this.save_Create_Button1 = new ConsoleApplication5.Save_Create_Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PriceInputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Text_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save_Create_Button2 = new ConsoleApplication5.Save_Create_Button();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1016F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 1034);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1604, 15);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 590F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.CategoryTextBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 934);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1604, 100);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(450, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 54);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.CategoryTextBox.Location = new System.Drawing.Point(594, 30);
            this.CategoryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(586, 40);
            this.CategoryTextBox.TabIndex = 7;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 814);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1604, 120);
            this.label4.TabIndex = 6;
            this.label4.Text = "CREATE NEW CATEGORY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 626);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1604, 188);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.4486F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.42991F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.21495F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 411);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1604, 215);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.add_Button1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.save_Create_Button1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(588, 5);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(351, 205);
            this.tableLayoutPanel7.TabIndex = 15;
            // 
            // add_Button1
            // 
            this.add_Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_Button1.BackColor = System.Drawing.Color.Transparent;
            this.add_Button1.Image_set = null;
            this.add_Button1.Location = new System.Drawing.Point(5, 5);
            this.add_Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_Button1.Name = "add_Button1";
            this.add_Button1.Size = new System.Drawing.Size(340, 92);
            this.add_Button1.TabIndex = 21;
            this.add_Button1.Textlabel = "Add Picture";
            // 
            // save_Create_Button1
            // 
            this.save_Create_Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_Create_Button1.BackColor = System.Drawing.Color.Transparent;
            this.save_Create_Button1.Image_set = null;
            this.save_Create_Button1.Location = new System.Drawing.Point(5, 107);
            this.save_Create_Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_Create_Button1.Name = "save_Create_Button1";
            this.save_Create_Button1.Size = new System.Drawing.Size(340, 93);
            this.save_Create_Button1.TabIndex = 22;
            this.save_Create_Button1.Textlabel = "Create Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::ConsoleApplication5.Properties.Resources.placeholder;
            this.pictureBox1.Image = global::ConsoleApplication5.Properties.Resources.placeholder;
            this.pictureBox1.ImageLocation = "@\"C:\\Users\\kranzekage\\Source\\Repos\\P4_project\\PictureLibrary\"";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(947, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 590F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.PriceInputTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 308);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1604, 103);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // PriceInputTextBox
            // 
            this.PriceInputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PriceInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceInputTextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PriceInputTextBox.Location = new System.Drawing.Point(594, 31);
            this.PriceInputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceInputTextBox.Name = "PriceInputTextBox";
            this.PriceInputTextBox.Size = new System.Drawing.Size(586, 40);
            this.PriceInputTextBox.TabIndex = 4;
            this.PriceInputTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(470, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 590F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1016F));
            this.tableLayoutPanel1.Controls.Add(this.Text_input, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 162);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1604, 146);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // Text_input
            // 
            this.Text_input.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Text_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_input.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Text_input.Location = new System.Drawing.Point(594, 53);
            this.Text_input.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Text_input.Name = "Text_input";
            this.Text_input.Size = new System.Drawing.Size(586, 40);
            this.Text_input.TabIndex = 0;
            this.Text_input.TextChanged += new System.EventHandler(this.ProductNameTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1604, 154);
            this.label3.TabIndex = 5;
            this.label3.Text = "CREATE A NEW PRODUCT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save_Create_Button2
            // 
            this.save_Create_Button2.BackColor = System.Drawing.Color.Transparent;
            this.save_Create_Button2.Image_set = null;
            this.save_Create_Button2.Location = new System.Drawing.Point(600, 1058);
            this.save_Create_Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_Create_Button2.Name = "save_Create_Button2";
            this.save_Create_Button2.Size = new System.Drawing.Size(340, 94);
            this.save_Create_Button2.TabIndex = 21;
            this.save_Create_Button2.Textlabel = "Create Category";
            // 
            // XmlFileAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1614);
            this.Controls.Add(this.save_Create_Button2);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "XmlFileAdder";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "XmlFileAdder";
            this.TopMost = true;
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TextBox Text_input;
        private System.Windows.Forms.TextBox PriceInputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        
        private System.Windows.Forms.TextBox CategoryTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label1;
        private Label label2;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel7;
        private Add_Button add_Button1;
        private Save_Create_Button save_Create_Button1;
        private Save_Create_Button save_Create_Button2;
    }
}