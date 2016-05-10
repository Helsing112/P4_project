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
            this.standard_Label1 = new ConsoleApplication5.Standard_Label();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.SuspendLayout();
            // 
            // standard_Label1
            // 
            this.standard_Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standard_Label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standard_Label1.ForeColor = System.Drawing.Color.DimGray;
            this.standard_Label1.Location = new System.Drawing.Point(4, 4);
            this.standard_Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.standard_Label1.Name = "standard_Label1";
            this.standard_Label1.Size = new System.Drawing.Size(714, 65);
            this.standard_Label1.TabIndex = 1;
            this.standard_Label1.Text = "CHECK OUT";
            this.standard_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(517, 489);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(1);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(200, 80);
            this.quit_Close_Button1.TabIndex = 0;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.quit_Close_Button1_Button_Click);
            // 
            // SignOutOnJobWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 574);
            this.Controls.Add(this.standard_Label1);
            this.Controls.Add(this.quit_Close_Button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignOutOnJobWindow";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "SignOutOnJobWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Quit_Close_Button quit_Close_Button1;
        private Standard_Label standard_Label1;
    }
}