namespace ConsoleApplication5
{
    partial class StartPage
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
            this.Label_HeadlineSelectUser = new ConsoleApplication5.Standard_Label();
            this.employeeSignInPanel1 = new ConsoleApplication5.EmployeeSignInPanel();
            this.adminStartButton1 = new ConsoleApplication5.AdminStartButton();
            this.checkOutButton1 = new ConsoleApplication5.CheckOutButton();
            this.checkInButton1 = new ConsoleApplication5.CheckInButton();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.SuspendLayout();
            // 
            // Label_HeadlineSelectUser
            // 
            this.Label_HeadlineSelectUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_HeadlineSelectUser.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.Label_HeadlineSelectUser.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadlineSelectUser.Location = new System.Drawing.Point(580, 86);
            this.Label_HeadlineSelectUser.Name = "Label_HeadlineSelectUser";
            this.Label_HeadlineSelectUser.Size = new System.Drawing.Size(1081, 67);
            this.Label_HeadlineSelectUser.TabIndex = 5;
            this.Label_HeadlineSelectUser.Text = "SELECT USER";
            this.Label_HeadlineSelectUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_HeadlineSelectUser.Click += new System.EventHandler(this.Label_HeadlineSelectUser_Click);
            // 
            // employeeSignInPanel1
            // 
            this.employeeSignInPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeSignInPanel1.Location = new System.Drawing.Point(580, 170);
            this.employeeSignInPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeSignInPanel1.Name = "employeeSignInPanel1";
            this.employeeSignInPanel1.Size = new System.Drawing.Size(1081, 803);
            this.employeeSignInPanel1.TabIndex = 4;
            // 
            // adminStartButton1
            // 
            this.adminStartButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminStartButton1.BackColor = System.Drawing.Color.Transparent;
            this.adminStartButton1.Image_set = null;
            this.adminStartButton1.Location = new System.Drawing.Point(1718, 893);
            this.adminStartButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminStartButton1.Name = "adminStartButton1";
            this.adminStartButton1.Size = new System.Drawing.Size(156, 80);
            this.adminStartButton1.TabIndex = 3;
            this.adminStartButton1.Textlabel = "ADMIN";
            this.adminStartButton1.Load += new System.EventHandler(this.adminStartButton1_Load);
            // 
            // checkOutButton1
            // 
            this.checkOutButton1.BackColor = System.Drawing.Color.Transparent;
            this.checkOutButton1.Image_set = null;
            this.checkOutButton1.Location = new System.Drawing.Point(87, 533);
            this.checkOutButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkOutButton1.Name = "checkOutButton1";
            this.checkOutButton1.Size = new System.Drawing.Size(271, 150);
            this.checkOutButton1.TabIndex = 2;
            this.checkOutButton1.Textlabel = "CHECK OUT";
            // 
            // checkInButton1
            // 
            this.checkInButton1.BackColor = System.Drawing.Color.Transparent;
            this.checkInButton1.Image_set = null;
            this.checkInButton1.Location = new System.Drawing.Point(87, 329);
            this.checkInButton1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkInButton1.Name = "checkInButton1";
            this.checkInButton1.Size = new System.Drawing.Size(271, 150);
            this.checkInButton1.TabIndex = 1;
            this.checkInButton1.Textlabel = "CHECK IN";
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.White;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(0, 0);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(1920, 50);
            this.timerInfo1.TabIndex = 0;
            this.timerInfo1.tablename = null;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_HeadlineSelectUser);
            this.Controls.Add(this.employeeSignInPanel1);
            this.Controls.Add(this.adminStartButton1);
            this.Controls.Add(this.checkOutButton1);
            this.Controls.Add(this.checkInButton1);
            this.Controls.Add(this.timerInfo1);
            this.Name = "StartPage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        public TimerInfo timerInfo1;
        public CheckInButton checkInButton1;
        public CheckOutButton checkOutButton1;
        public AdminStartButton adminStartButton1;
        public EmployeeSignInPanel employeeSignInPanel1;
        private Standard_Label Label_HeadlineSelectUser;
    }
}
