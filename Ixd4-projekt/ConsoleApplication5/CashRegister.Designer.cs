namespace ConsoleApplication5
{
    partial class CashRegister
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
            this.textBox_Touch1 = new ConsoleApplication5.Standard_layouts.Buttons.TextBox_Touch();
            this.textBox_Touch2 = new ConsoleApplication5.Standard_layouts.Buttons.TextBox_Touch();
            this.textBox_Touch3 = new ConsoleApplication5.Standard_layouts.Buttons.TextBox_Touch();
            this.standard_Label1 = new ConsoleApplication5.Standard_layouts.Standard_Label();
            this.standard_Label2 = new ConsoleApplication5.Standard_layouts.Standard_Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Touch1
            // 
            this.textBox_Touch1.Location = new System.Drawing.Point(268, 3);
            this.textBox_Touch1.Name = "textBox_Touch1";
            this.textBox_Touch1.Size = new System.Drawing.Size(511, 42);
            this.textBox_Touch1.TabIndex = 0;
            // 
            // textBox_Touch2
            // 
            this.textBox_Touch2.Location = new System.Drawing.Point(268, 280);
            this.textBox_Touch2.Name = "textBox_Touch2";
            this.textBox_Touch2.Size = new System.Drawing.Size(511, 42);
            this.textBox_Touch2.TabIndex = 1;
            // 
            // textBox_Touch3
            // 
            this.textBox_Touch3.Location = new System.Drawing.Point(268, 557);
            this.textBox_Touch3.Name = "textBox_Touch3";
            this.textBox_Touch3.Size = new System.Drawing.Size(511, 42);
            this.textBox_Touch3.TabIndex = 2;
            // 
            // standard_Label1
            // 
            this.standard_Label1.AutoSize = true;
            this.standard_Label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.standard_Label1.ForeColor = System.Drawing.Color.White;
            this.standard_Label1.Location = new System.Drawing.Point(3, 0);
            this.standard_Label1.Name = "standard_Label1";
            this.standard_Label1.Size = new System.Drawing.Size(190, 41);
            this.standard_Label1.TabIndex = 3;
            this.standard_Label1.Text = "Today\'s Sale";
            // 
            // standard_Label2
            // 
            this.standard_Label2.AutoSize = true;
            this.standard_Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standard_Label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.standard_Label2.ForeColor = System.Drawing.Color.White;
            this.standard_Label2.Location = new System.Drawing.Point(3, 0);
            this.standard_Label2.Name = "standard_Label2";
            this.standard_Label2.Size = new System.Drawing.Size(1570, 67);
            this.standard_Label2.TabIndex = 4;
            this.standard_Label2.Text = "Cash Register";
            this.standard_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.standard_Label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1576, 101);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 106);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1576, 839);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_Touch3, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_Touch2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.standard_Label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_Touch1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(791, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(782, 833);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 950);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CashRegister";
            this.Text = "CashRegister";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Standard_layouts.Buttons.TextBox_Touch textBox_Touch1;
        private Standard_layouts.Buttons.TextBox_Touch textBox_Touch2;
        private Standard_layouts.Buttons.TextBox_Touch textBox_Touch3;
        private Standard_layouts.Standard_Label standard_Label1;
        private Standard_layouts.Standard_Label standard_Label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}