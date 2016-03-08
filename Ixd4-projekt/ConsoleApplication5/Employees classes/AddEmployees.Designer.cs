namespace ConsoleApplication5
{
    partial class AddEmployees
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
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeNametextBox = new System.Windows.Forms.TextBox();
            this.EmployeeIDtextBox = new System.Windows.Forms.TextBox();
            this.EmployeePasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(189, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeNametextBox
            // 
            this.EmployeeNametextBox.Location = new System.Drawing.Point(189, 120);
            this.EmployeeNametextBox.Name = "EmployeeNametextBox";
            this.EmployeeNametextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeNametextBox.TabIndex = 1;
            this.EmployeeNametextBox.TextChanged += new System.EventHandler(this.EmployeeNametextBox_TextChanged);
            // 
            // EmployeeIDtextBox
            // 
            this.EmployeeIDtextBox.Location = new System.Drawing.Point(189, 202);
            this.EmployeeIDtextBox.Name = "EmployeeIDtextBox";
            this.EmployeeIDtextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDtextBox.TabIndex = 2;
            this.EmployeeIDtextBox.TextChanged += new System.EventHandler(this.EmployeeIDtextBox_TextChanged);
            // 
            // EmployeePasswordtextBox
            // 
            this.EmployeePasswordtextBox.Location = new System.Drawing.Point(189, 273);
            this.EmployeePasswordtextBox.Name = "EmployeePasswordtextBox";
            this.EmployeePasswordtextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeePasswordtextBox.TabIndex = 3;
            this.EmployeePasswordtextBox.TextChanged += new System.EventHandler(this.EmployeePasswordtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "EmployeePassword";
            // 
            // AddEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeePasswordtextBox);
            this.Controls.Add(this.EmployeeIDtextBox);
            this.Controls.Add(this.EmployeeNametextBox);
            this.Controls.Add(this.button1);
            this.Name = "AddEmployees";
            this.Text = "AddEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox EmployeeNametextBox;
        private System.Windows.Forms.TextBox EmployeeIDtextBox;
        private System.Windows.Forms.TextBox EmployeePasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}