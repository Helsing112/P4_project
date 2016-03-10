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
            this.Text_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceInputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.Create_Category_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_input
            // 
            this.Text_input.Location = new System.Drawing.Point(210, 114);
            this.Text_input.Name = "Text_input";
            this.Text_input.Size = new System.Drawing.Size(328, 22);
            this.Text_input.TabIndex = 0;
            this.Text_input.TextChanged += new System.EventHandler(this.ProductNameTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter name of product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(184, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter price";
            // 
            // textBox1
            // 
            this.PriceInputTextBox.Location = new System.Drawing.Point(210, 163);
            this.PriceInputTextBox.Name = "textBox1";
            this.PriceInputTextBox.Size = new System.Drawing.Size(328, 22);
            this.PriceInputTextBox.TabIndex = 4;
            this.PriceInputTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(179, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(179, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Create Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter name of category";
            // 
            // textBox2
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(210, 362);
            this.CategoryTextBox.Name = "textBox2";
            this.CategoryTextBox.Size = new System.Drawing.Size(328, 22);
            this.CategoryTextBox.TabIndex = 7;
            this.CategoryTextBox.TextChanged += new System.EventHandler(this.CategoryTextbox_TextChanged);
            // 
            // Create_cat_but
            // 
            this.Create_Category_Button.Enabled = false;
            this.Create_Category_Button.Location = new System.Drawing.Point(184, 425);
            this.Create_Category_Button.Name = "Create_cat_but";
            this.Create_Category_Button.Size = new System.Drawing.Size(173, 36);
            this.Create_Category_Button.TabIndex = 9;
            this.Create_Category_Button.Text = "Create Category";
            this.Create_Category_Button.UseVisualStyleBackColor = true;
            this.Create_Category_Button.Click += new System.EventHandler(this.Create_Category_Button_Click);
            // 
            // XmlFileAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 554);
            this.Controls.Add(this.Create_Category_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PriceInputTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_input);
            this.Name = "XmlFileAdder";
            this.Text = "XmlFileAdder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceInputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Button Create_Category_Button;
    }
}