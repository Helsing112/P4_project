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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EmployeeAddButton = new ConsoleApplication5.AdminFunctionButtons();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TableManageButton = new ConsoleApplication5.AdminFunctionButtons();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProductsAddButton = new ConsoleApplication5.AdminFunctionButtons();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1091, 108);
            this.panel4.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 510);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.EmployeeAddButton);
            this.panel5.Location = new System.Drawing.Point(349, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 94);
            this.panel5.TabIndex = 8;
            // 
            // EmployeeAddButton
            // 
            this.EmployeeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeAddButton.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeAddButton.Image_set = null;
            this.EmployeeAddButton.Location = new System.Drawing.Point(0, 0);
            this.EmployeeAddButton.Margin = new System.Windows.Forms.Padding(10);
            this.EmployeeAddButton.Name = "EmployeeAddButton";
            this.EmployeeAddButton.Size = new System.Drawing.Size(392, 94);
            this.EmployeeAddButton.TabIndex = 1;
            this.EmployeeAddButton.Textlabel = "Add Employee";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.TableManageButton);
            this.panel3.Location = new System.Drawing.Point(349, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 94);
            this.panel3.TabIndex = 8;
            // 
            // TableManageButton
            // 
            this.TableManageButton.BackColor = System.Drawing.Color.Transparent;
            this.TableManageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableManageButton.Image_set = null;
            this.TableManageButton.Location = new System.Drawing.Point(0, 0);
            this.TableManageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableManageButton.Name = "TableManageButton";
            this.TableManageButton.Size = new System.Drawing.Size(392, 94);
            this.TableManageButton.TabIndex = 0;
            this.TableManageButton.Textlabel = "Table Manage";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.ProductsAddButton);
            this.panel2.Location = new System.Drawing.Point(349, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 94);
            this.panel2.TabIndex = 8;
            // 
            // ProductsAddButton
            // 
            this.ProductsAddButton.BackColor = System.Drawing.Color.Transparent;
            this.ProductsAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsAddButton.Image_set = null;
            this.ProductsAddButton.Location = new System.Drawing.Point(0, 0);
            this.ProductsAddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsAddButton.Name = "ProductsAddButton";
            this.ProductsAddButton.Size = new System.Drawing.Size(392, 94);
            this.ProductsAddButton.TabIndex = 2;
            this.ProductsAddButton.Textlabel = "Add Product";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quit_Close_Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 699);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 263);
            this.panel1.TabIndex = 7;
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(775, 127);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(4);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(288, 106);
            this.quit_Close_Button1.TabIndex = 3;
            this.quit_Close_Button1.Textlabel = "Quit";
            // 
            // AdminWindomUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminWindomUserControl";
            this.Size = new System.Drawing.Size(1091, 962);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AdminFunctionButtons TableManageButton;
        private AdminFunctionButtons EmployeeAddButton;
        private AdminFunctionButtons ProductsAddButton;
        public Quit_Close_Button quit_Close_Button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}
