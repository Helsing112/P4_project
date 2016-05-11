namespace ConsoleApplication5
{
    partial class CommentToReceiptWindow
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
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.login_Button1 = new ConsoleApplication5.Login_Button();
            this.SuspendLayout();
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.CommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentTextBox.Location = new System.Drawing.Point(52, 43);
            this.CommentTextBox.MaxLength = 500;
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(183, 52);
            this.CommentTextBox.TabIndex = 0;
            this.CommentTextBox.TextChanged += new System.EventHandler(this.CommentTextBox_TextChanged);
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(148, 118);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(1);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(87, 43);
            this.quit_Close_Button1.TabIndex = 3;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // login_Button1
            // 
            this.login_Button1.BackColor = System.Drawing.Color.Transparent;
            this.login_Button1.Image_set = null;
            this.login_Button1.Location = new System.Drawing.Point(52, 118);
            this.login_Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_Button1.Name = "login_Button1";
            this.login_Button1.Size = new System.Drawing.Size(87, 43);
            this.login_Button1.TabIndex = 5;
            this.login_Button1.Textlabel = "Add";
            this.login_Button1.Button_Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // CommentToReceiptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 187);
            this.Controls.Add(this.login_Button1);
            this.Controls.Add(this.quit_Close_Button1);
            this.Controls.Add(this.CommentTextBox);
            this.Name = "CommentToReceiptWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CommentTextBox;
        private Quit_Close_Button quit_Close_Button1;
        private Login_Button login_Button1;
    }
}