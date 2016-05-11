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
            this.EmployeeAddButton = new ConsoleApplication5.AdminFunctionButtons();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductsAddButton = new ConsoleApplication5.AdminFunctionButtons();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableManageButton = new ConsoleApplication5.AdminFunctionButtons();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.quit_Close_Button2 = new ConsoleApplication5.EndProgramButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmployeeAddButton);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 80);
            this.panel1.TabIndex = 4;
            // 
            // EmployeeAddButton
            // 
            this.EmployeeAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmployeeAddButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeAddButton.Image_set = null;
            this.EmployeeAddButton.Location = new System.Drawing.Point(163, 9);
            this.EmployeeAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeAddButton.Name = "EmployeeAddButton";
            this.EmployeeAddButton.Size = new System.Drawing.Size(200, 69);
            this.EmployeeAddButton.TabIndex = 1;
            this.EmployeeAddButton.Textlabel = "Add Employee";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ProductsAddButton);
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 80);
            this.panel3.TabIndex = 0;
            // 
            // ProductsAddButton
            // 
            this.ProductsAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductsAddButton.BackColor = System.Drawing.Color.Transparent;
            this.ProductsAddButton.Image_set = null;
            this.ProductsAddButton.Location = new System.Drawing.Point(163, 11);
            this.ProductsAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsAddButton.Name = "ProductsAddButton";
            this.ProductsAddButton.Size = new System.Drawing.Size(200, 67);
            this.ProductsAddButton.TabIndex = 2;
            this.ProductsAddButton.Textlabel = "Add Product";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TableManageButton);
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 80);
            this.panel2.TabIndex = 3;
            // 
            // TableManageButton
            // 
            this.TableManageButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableManageButton.BackColor = System.Drawing.Color.Transparent;
            this.TableManageButton.Image_set = null;
            this.TableManageButton.Location = new System.Drawing.Point(163, 11);
            this.TableManageButton.Margin = new System.Windows.Forms.Padding(2);
            this.TableManageButton.Name = "TableManageButton";
            this.TableManageButton.Size = new System.Drawing.Size(200, 69);
            this.TableManageButton.TabIndex = 0;
            this.TableManageButton.Textlabel = "Table Manage";
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(332, 391);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(2);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(200, 80);
            this.quit_Close_Button1.TabIndex = 3;
            this.quit_Close_Button1.Textlabel = "Quit";
            // 
            // quit_Close_Button2
            // 
            this.quit_Close_Button2.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button2.Image_set = null;
            this.quit_Close_Button2.Location = new System.Drawing.Point(19, 391);
            this.quit_Close_Button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quit_Close_Button2.Name = "quit_Close_Button2";
            this.quit_Close_Button2.Size = new System.Drawing.Size(145, 80);
            this.quit_Close_Button2.TabIndex = 6;
            this.quit_Close_Button2.Textlabel = "Exit Program";
            // 
            // AdminWindomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quit_Close_Button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quit_Close_Button1);
            this.Name = "AdminWindomUserControl";
            this.Size = new System.Drawing.Size(798, 1198);
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
    }
}
