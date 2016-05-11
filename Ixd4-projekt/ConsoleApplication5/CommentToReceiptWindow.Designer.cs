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
            this.quit_Close_Button1 = new ConsoleApplication5.Quit_Close_Button();
            this.login_Button1 = new ConsoleApplication5.Login_Button();
            this.textBox_Touch1 = new ConsoleApplication5.TextBox_Touch();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // quit_Close_Button1
            // 
            this.quit_Close_Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.quit_Close_Button1.BackColor = System.Drawing.Color.Transparent;
            this.quit_Close_Button1.Image_set = null;
            this.quit_Close_Button1.Location = new System.Drawing.Point(528, 20);
            this.quit_Close_Button1.Margin = new System.Windows.Forms.Padding(2);
            this.quit_Close_Button1.Name = "quit_Close_Button1";
            this.quit_Close_Button1.Size = new System.Drawing.Size(174, 83);
            this.quit_Close_Button1.TabIndex = 3;
            this.quit_Close_Button1.Textlabel = "Quit";
            this.quit_Close_Button1.Button_Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // login_Button1
            // 
            this.login_Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.login_Button1.BackColor = System.Drawing.Color.Transparent;
            this.login_Button1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Button1.Image_set = null;
            this.login_Button1.Location = new System.Drawing.Point(173, 20);
            this.login_Button1.Margin = new System.Windows.Forms.Padding(4);
            this.login_Button1.Name = "login_Button1";
            this.login_Button1.Size = new System.Drawing.Size(174, 83);
            this.login_Button1.TabIndex = 5;
            this.login_Button1.Textlabel = "Add";
            this.login_Button1.Button_Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // textBox_Touch1
            // 
            this.textBox_Touch1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Touch1.Location = new System.Drawing.Point(27, 52);
            this.textBox_Touch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Touch1.Name = "textBox_Touch1";
            this.textBox_Touch1.Size = new System.Drawing.Size(823, 338);
            this.textBox_Touch1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Touch1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 442F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 442);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.login_Button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.quit_Close_Button1, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 124);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // CommentToReceiptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 648);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CommentToReceiptWindow";
            this.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Quit_Close_Button quit_Close_Button1;
        private Login_Button login_Button1;
        private TextBox_Touch textBox_Touch1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}