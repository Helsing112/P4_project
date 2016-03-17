namespace ConsoleApplication5
{
    partial class testknapvindue
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
            this.testknap11 = new ConsoleApplication5.testknap1();
            this.SuspendLayout();
            // 
            // testknap11
            // 
            this.testknap11.BackColor = System.Drawing.Color.Transparent;
            this.testknap11.Location = new System.Drawing.Point(94, 83);
            this.testknap11.Name = "testknap11";
            this.testknap11.Size = new System.Drawing.Size(99, 86);
            this.testknap11.TabIndex = 0;
            // 
            // testknapvindue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.testknap11);
            this.Name = "testknapvindue";
            this.Text = "testknapvindue";
            this.ResumeLayout(false);

        }

        #endregion

        private testknap1 testknap11;
    }
}