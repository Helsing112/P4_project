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
            this.TimerText = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TableInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerText
            // 
            this.TimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerText.Location = new System.Drawing.Point(812, 0);
            this.TimerText.MaxLength = 9;
            this.TimerText.Name = "TimerText";
            this.TimerText.ReadOnly = true;
            this.TimerText.Size = new System.Drawing.Size(126, 38);
            this.TimerText.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(3, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(100, 38);
            this.NameTextBox.TabIndex = 4;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // TableInfo
            // 
            this.TableInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableInfo.Location = new System.Drawing.Point(388, 0);
            this.TableInfo.Name = "TableInfo";
            this.TableInfo.ReadOnly = true;
            this.TableInfo.Size = new System.Drawing.Size(100, 38);
            this.TableInfo.TabIndex = 5;
            // 
            // TimerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TableInfo);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TimerText);
            this.Name = "TimerInfo";
            this.Size = new System.Drawing.Size(938, 150);
            this.Load += new System.EventHandler(this.TimerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TimerText;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TableInfo;
    }
}
