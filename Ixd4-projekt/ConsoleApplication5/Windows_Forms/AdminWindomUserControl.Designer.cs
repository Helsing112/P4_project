namespace ConsoleApplication5
{
    partial class AdminWindomUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quit_Close_Button2 = new ConsoleApplication5.EndProgramButton();
            this.TableManageButton = new ConsoleApplication5.AdminFunctionButtons();
            this.ProductsAddButton = new ConsoleApplication5.AdminFunctionButtons();
            this.EmployeeAddButton = new ConsoleApplication5.AdminFunctionButtons();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.UpdateButton = new ConsoleApplication5.Pay_Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeeAddButton);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 98);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductsAddButton);
            this.panel3.Location = new System.Drawing.Point(0, 272);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 98);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TableManageButton);
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 98);
            this.panel2.TabIndex = 3;
            // 
            // quit_Close_Button2
            // 
            this.quit_Close_Button2.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button2.Image_set = null;
            this.quit_Close_Button2.Location = new System.Drawing.Point(1, 532);
            this.quit_Close_Button2.Margin = new System.Windows.Forms.Padding(1);
            this.quit_Close_Button2.Name = "quit_Close_Button2";
            this.quit_Close_Button2.Size = new System.Drawing.Size(194, 87);
            this.quit_Close_Button2.TabIndex = 6;
            this.quit_Close_Button2.Textlabel = "Exit Program";
            // 
            // TableManageButton
            // 
            this.TableManageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableManageButton.BackColor = System.Drawing.Color.Transparent;
            this.TableManageButton.Image_set = null;
            this.TableManageButton.Location = new System.Drawing.Point(127, 11);
            this.TableManageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableManageButton.Name = "TableManageButton";
            this.TableManageButton.Size = new System.Drawing.Size(267, 85);
            this.TableManageButton.TabIndex = 0;
            this.TableManageButton.Textlabel = "Table Manage";
            // 
            // ProductsAddButton
            // 
            this.ProductsAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductsAddButton.BackColor = System.Drawing.Color.Transparent;
            this.ProductsAddButton.Image_set = null;
            this.ProductsAddButton.Location = new System.Drawing.Point(127, 14);
            this.ProductsAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductsAddButton.Name = "ProductsAddButton";
            this.ProductsAddButton.Size = new System.Drawing.Size(267, 82);
            this.ProductsAddButton.TabIndex = 2;
            this.ProductsAddButton.Textlabel = "Add Product";
            // 
            // EmployeeAddButton
            // 
            this.EmployeeAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeAddButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeAddButton.Image_set = null;
            this.EmployeeAddButton.Location = new System.Drawing.Point(127, 8);
            this.EmployeeAddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeAddButton.Name = "EmployeeAddButton";
            this.EmployeeAddButton.Size = new System.Drawing.Size(267, 85);
            this.EmployeeAddButton.TabIndex = 1;
            this.EmployeeAddButton.Textlabel = "Add Employee";
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(318, 532);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(194, 87);
            this.quit_Close_Button1.TabIndex = 3;
            this.quit_Close_Button1.Textlabel = "Quit";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Image_set = null;
            this.UpdateButton.Location = new System.Drawing.Point(318, 437);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(194, 91);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Textlabel = "Update";
            // 
            // AdminWindomUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.quit_Close_Button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quit_Close_Button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminWindomUserControl";
            this.Size = new System.Drawing.Size(528, 631);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AdminFunctionButtons TableManageButton;
        private AdminFunctionButtons EmployeeAddButton;
        private AdminFunctionButtons ProductsAddButton;
        public Quit_Close_Button quit_Close_Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public EndProgramButton quit_Close_Button2;
        public Pay_Button UpdateButton;
    }
}
