using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            textBox_Touch1.Focus();

            this.textBox_Touch1.textBox1.Font = new Font("Segoe UI", 30);
            this.textBox_Touch1.textBox1.TextChanged += new EventHandler(txtPassword_TextChanged);
            this.textBox_Touch1.textBox1.Height = login_Button1.Height;
            this.textBox_Touch1.Height = login_Button1.Height;
            this.textBox_Touch1.Width = login_Button1.Width;


            path_input = path;
            login_Button1.Enabled = false;
            AdminControl = new AdminWindomUserControl(path_input, Size_for_table_panel);
            AdminControl.quit_Close_Button1.Button_Click += button2_Click;
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width/3, Screen.PrimaryScreen.Bounds.Height-150);

        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Touch1 = new ConsoleApplication5.TextBox_Touch();
            this.login_Button1 = new ConsoleApplication5.Login_Button();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Touch1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.login_Button1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.7619F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.23809F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 583);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quit_Close_Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(9, 1187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 303);
            this.panel1.TabIndex = 5;
            // 
            // textBox_Touch1
            // 
            this.textBox_Touch1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Touch1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.textBox_Touch1.Location = new System.Drawing.Point(268, 231);
            this.textBox_Touch1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Touch1.Name = "textBox_Touch1";
            this.textBox_Touch1.Size = new System.Drawing.Size(510, 56);
            this.textBox_Touch1.TabIndex = 0;
            // 
            // login_Button1
            // 
            this.login_Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_Button1.BackColor = System.Drawing.Color.Transparent;
            this.login_Button1.Image_set = null;
            this.login_Button1.Location = new System.Drawing.Point(256, 386);
            this.login_Button1.Margin = new System.Windows.Forms.Padding(5);
            this.login_Button1.Name = "login_Button1";
            this.login_Button1.Size = new System.Drawing.Size(533, 125);
            this.login_Button1.TabIndex = 3;
            this.login_Button1.Textlabel = "Login";
            this.login_Button1.Button_Click += new System.EventHandler(this.button1_Click);
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(272, 57);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(533, 125);
            this.quit_Close_Button1.TabIndex = 4;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin_function_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 1498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Admin_function_window";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
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
