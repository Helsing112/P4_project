﻿using System;
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
    public partial class Admin_function_window : Form
    {
        private string path_input;
        public Admin_function_window(string path)
        {
            InitializeComponent();
            path_input = path;
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Font = new Font(button1.Font.FontFamily, 20);
            this.button1.Font = new Font("Segoe UI", button1.Font.Size);

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 150);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 100);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Font = new Font(button1.Font.FontFamily, 30);
            this.txtPassword.Font = new Font("Segoe UI", button1.Font.Size);
            this.txtPassword.TextAlign = HorizontalAlignment.Center;

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 600);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Font = new Font(button1.Font.FontFamily, 20);
            this.button2.Font = new Font("Segoe UI", button1.Font.Size);

            // 
            // Admin_function_window
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1000);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_function_window";
            this.Text = "Admin Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private Button button2;

        private void start()
        {
            Admin_Edit_ctrl admin_edit = new Admin_Edit_ctrl(path_input);

            Controls.Add(admin_edit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                Controls.Clear();
                start();
            }
            else {
                MessageBox.Show("Wrong Password");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
