namespace ConsoleApplication5
{
    partial class SignOutOnJobWindow
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
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.standard_Label1 = new ConsoleApplication5.Standard_Label();
            this.SuspendLayout();
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(829, 666);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(1);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(128, 34);
            this.quit_Close_Button1.TabIndex = 0;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.quit_Close_Button1_Button_Click);
            // 
            // standard_Label1
            // 
            this.standard_Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standard_Label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.standard_Label1.ForeColor = System.Drawing.Color.Black;
            this.standard_Label1.Location = new System.Drawing.Point(5, 5);
            this.standard_Label1.Name = "standard_Label1";
            this.standard_Label1.Size = new System.Drawing.Size(953, 35);
            this.standard_Label1.TabIndex = 1;
            this.standard_Label1.Text = "LOG OUT";
            this.standard_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignOutOnJobWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 706);
            this.Controls.Add(this.standard_Label1);
            this.Controls.Add(this.quit_Close_Button1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "SignOutOnJobWindow";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "SignOutOnJobWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Quit_Close_Button quit_Close_Button1;
        private Standard_Label standard_Label1;
    }
}