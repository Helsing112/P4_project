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
            textBox_Touch1.textBox1.Size = textBox_Touch1.Size;
            textBox_Touch1.textBox1.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);

            path_input = path;
            login_Button1.Enabled = false;
            AdminControl = new AdminWindomUserControl(path_input, Size_for_table_panel);
            AdminControl.quit_Close_Button1.Button_Click += button2_Click;

        }

        private void InitializeComponent()
        {
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.login_Button1 = new ConsoleApplication5.Login_Button();
            this.textBox_Touch1 = new ConsoleApplication5.TextBox_Touch();
            this.SuspendLayout();
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(266, 1031);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(2);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(534, 125);
            this.quit_Close_Button1.TabIndex = 4;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.button2_Click);
            // 
            // login_Button1
            // 
            this.login_Button1.BackColor = System.Drawing.Color.Transparent;
            this.login_Button1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button1.Image_set = null;
            this.login_Button1.Location = new System.Drawing.Point(266, 358);
            this.login_Button1.Margin = new System.Windows.Forms.Padding(2);
            this.login_Button1.Name = "login_Button1";
            this.login_Button1.Size = new System.Drawing.Size(534, 125);
            this.login_Button1.TabIndex = 3;
            this.login_Button1.Textlabel = "LOGIN";
            this.login_Button1.Button_Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Touch1
            // 
            this.textBox_Touch1.Location = new System.Drawing.Point(266, 210);
            this.textBox_Touch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Touch1.Name = "textBox_Touch1";
            this.textBox_Touch1.Size = new System.Drawing.Size(532, 78);
            this.textBox_Touch1.TabIndex = 5;
            // 
            // Admin_function_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 1223);
            this.Controls.Add(this.textBox_Touch1);
            this.Controls.Add(this.quit_Close_Button1);
            this.Controls.Add(this.login_Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin_function_window";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResumeLayout(false);

        }
        public AdminWindomUserControl AdminControl;
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
            if (!string.IsNullOrWhiteSpace(textBox_Touch1.textBox1.Text))
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
            if (textBox_Touch1.textBox1.Text == "password")
            {
                start();
             
              
            }
            else
            {
              Messages.WrongPassword();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            textBox_Touch1.textBox1.PasswordChar = '*';
            Activate_Login_Button();
        }
    }
}
