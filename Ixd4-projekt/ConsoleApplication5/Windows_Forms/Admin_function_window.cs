using System;
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
    public partial class Admin_function_window : Standard_Window_Layout
    {
        private string path_input;
        public Size Size_for_table_panel { get; }

        public Admin_function_window(string path, Size Size_For_table_Panel)
        {
            this.Size_for_table_panel = Size_For_table_Panel;
            InitializeComponent();
            path_input = path;
            login_Button1.Enabled = false;
            AdminControl = new AdminWindomUserControl(path_input, Size_for_table_panel);
            AdminControl.quit_Close_Button1.Button_Click += button2_Click;

        }

        private void InitializeComponent()
        {

            this.txtPassword = new System.Windows.Forms.TextBox();
            this.login_Button1 = new  Login_Button();
            this.quit_Close_Button1 = new  Quit_Close_Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtPassword.Location = new System.Drawing.Point(200, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 61);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // login_Button1
            // 
            this.login_Button1.BackColor = System.Drawing.Color.Transparent;
            this.login_Button1.Image_set = null;
            this.login_Button1.Location = new System.Drawing.Point(200, 286);
            this.login_Button1.Name = "login_Button1";
            this.login_Button1.Size = new System.Drawing.Size(400, 100);
            this.login_Button1.TabIndex = 3;
            this.login_Button1.Textlabel = "Login";
            this.login_Button1.Button_Click += new System.EventHandler(this.button1_Click);
            // 
            // quit_Close_Button1    
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(200, 824);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(400, 100);
            this.quit_Close_Button1.TabIndex = 4;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin_function_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 1198);
            this.Controls.Add(this.quit_Close_Button1);
            this.Controls.Add(this.login_Button1);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin_function_window";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtPassword;
        private AdminWindomUserControl AdminControl;
        private void start()
        {
            Controls.Clear();

            //this.Size = new Size(1200, 800);
            //this.CenterToScreen();
            //Admin_Edit_ctrl admin_edit = new Admin_Edit_ctrl(path_input, Size_for_table_panel);
            //admin_edit.Quit_button.Click += new EventHandler(button2_Click);
            //Controls.Add(admin_edit);
          
            this.CenterToScreen();
           Controls.Add(AdminControl);
        }

        private void Activate_Login_Button()
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                login_Button1.Enabled = true;
            }

            else
            {
                login_Button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                start();
             
              
            }
            else {
              Messages.WrongPassword();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            Activate_Login_Button();
        }
    }
}
