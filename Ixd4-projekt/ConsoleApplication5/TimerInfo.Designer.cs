using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    partial class TimerInfo
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Clock_Label = new ConsoleApplication5.Standard_Label();
            this.Employee_Name = new ConsoleApplication5.Standard_Label();
            this.Table_Info = new ConsoleApplication5.Standard_Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Table_Info, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Employee_Name, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Clock_Label, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1809, 150);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Clock_Label
            // 
            this.Clock_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Clock_Label.AutoSize = true;
            this.Clock_Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_Label.ForeColor = System.Drawing.Color.Black;
            this.Clock_Label.Location = new System.Drawing.Point(3, 42);
            this.Clock_Label.Name = "Clock_Label";
            this.Clock_Label.Size = new System.Drawing.Size(370, 65);
            this.Clock_Label.TabIndex = 6;
            this.Clock_Label.Text = "standard_Label1";
            this.Clock_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Employee_Name
            // 
            this.Employee_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Employee_Name.AutoSize = true;
            this.Employee_Name.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Employee_Name.ForeColor = System.Drawing.Color.Transparent;
            this.Employee_Name.Location = new System.Drawing.Point(1209, 48);
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.Size = new System.Drawing.Size(0, 54);
            this.Employee_Name.TabIndex = 7;
            this.Employee_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Table_Info
            // 
            this.Table_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Table_Info.AutoSize = true;
            this.Table_Info.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Table_Info.ForeColor = System.Drawing.Color.Transparent;
            this.Table_Info.Location = new System.Drawing.Point(904, 48);
            this.Table_Info.Name = "Table_Info";
            this.Table_Info.Size = new System.Drawing.Size(0, 54);
            this.Table_Info.TabIndex = 8;
            // 
            // TimerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TimerInfo";
            this.Size = new System.Drawing.Size(1809, 150);
            this.Load += new System.EventHandler(this.TimerInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Standard_Label Clock_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Standard_Label Employee_Name;
        private Standard_Label Table_Info;
    }
}
