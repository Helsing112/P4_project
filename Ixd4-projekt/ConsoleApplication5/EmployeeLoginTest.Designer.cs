namespace ConsoleApplication5
{
    partial class EmployeeLoginTest
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
            this.standard_Label1 = new ConsoleApplication5.Standard_Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // standard_Label1
            // 
            this.standard_Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.standard_Label1.AutoSize = true;
            this.standard_Label1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.standard_Label1.ForeColor = System.Drawing.Color.DimGray;
            this.standard_Label1.Location = new System.Drawing.Point(887, 0);
            this.standard_Label1.Name = "standard_Label1";
            this.standard_Label1.Size = new System.Drawing.Size(327, 86);
            this.standard_Label1.TabIndex = 0;
            this.standard_Label1.Text = "CHECK IN";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.standard_Label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 156);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2101, 86);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.White;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(7, 6);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(6);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(2101, 150);
            this.timerInfo1.TabIndex = 2;
            this.timerInfo1.tablename = null;
            // 
            // EmployeeLoginTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2115, 1145);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.timerInfo1);
            this.Name = "EmployeeLoginTest";
            this.Text = "EmployeeLoginTest";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Standard_Label standard_Label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TimerInfo timerInfo1;
    }
}