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
            this.CommentButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(52, 101);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(75, 43);
            this.CommentButton.TabIndex = 1;
            this.CommentButton.Text = "Comment";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(160, 101);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 43);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(52, 43);
            this.CommentTextBox.MaxLength = 500;
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(183, 52);
            this.CommentTextBox.TabIndex = 0;
            this.CommentTextBox.TextChanged += new System.EventHandler(this.CommentTextBox_TextChanged);
            // 
            // CommentToReceiptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 187);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CommentButton);
            this.Name = "CommentToReceiptWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CommentButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox CommentTextBox;
    }
}