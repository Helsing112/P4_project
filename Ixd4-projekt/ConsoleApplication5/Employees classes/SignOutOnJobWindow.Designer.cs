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
            this.SuspendLayout();
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(360, 303);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(1);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(96, 28);
            this.quit_Close_Button1.TabIndex = 0;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.quit_Close_Button1_Button_Click);
            // 
            // SignOutOnJobWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 365);
            this.Controls.Add(this.quit_Close_Button1);
            this.Name = "SignOutOnJobWindow";
            this.Text = "SignOutOnJobWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private Quit_Close_Button quit_Close_Button1;
    }
}