namespace ConsoleApplication5
{
    partial class SignInOnJobWindow
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
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkin = new ConsoleApplication5.Standard_Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.White;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(14, 12);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(6);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(1508, 50);
            this.timerInfo1.TabIndex = 0;
            this.timerInfo1.tablename = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1508, 97);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // checkin
            // 
            this.checkin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkin.AutoSize = true;
            this.checkin.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.checkin.ForeColor = System.Drawing.Color.DimGray;
            this.checkin.Location = new System.Drawing.Point(590, 4);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(327, 89);
            this.checkin.TabIndex = 0;
            this.checkin.Text = "CHECK IN";
            // 
            // SignInOnJobWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1536, 895);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.timerInfo1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "SignInOnJobWindow";
            this.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.Text = "SignInOnJobWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TimerInfo timerInfo1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Standard_Label checkin;
    }
}