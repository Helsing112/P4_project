namespace ConsoleApplication5
{
    partial class test3 : Standard_Window_Layout
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
            this.standard_Button_layout2 = new ConsoleApplication5.Standard_Button_layout();
            this.standard_Button_layout1 = new ConsoleApplication5.Standard_Button_layout();
            this.SuspendLayout();
            // 
            // standard_Button_layout2
            // 
            this.standard_Button_layout2.BackColor = System.Drawing.Color.Pink;
            this.standard_Button_layout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standard_Button_layout2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.standard_Button_layout2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.standard_Button_layout2.Location = new System.Drawing.Point(633, 218);
            this.standard_Button_layout2.Name = "standard_Button_layout2";
            this.standard_Button_layout2.Size = new System.Drawing.Size(400, 100);
            this.standard_Button_layout2.TabIndex = 0;
            this.standard_Button_layout2.Text = "standard_Button_layout2";
            this.standard_Button_layout2.UseVisualStyleBackColor = false;
            // 
            // standard_Button_layout1
            // 
            this.standard_Button_layout1.BackColor = System.Drawing.Color.Pink;
            this.standard_Button_layout1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standard_Button_layout1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.standard_Button_layout1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.standard_Button_layout1.Location = new System.Drawing.Point(532, 442);
            this.standard_Button_layout1.Name = "standard_Button_layout1";
            this.standard_Button_layout1.Size = new System.Drawing.Size(400, 100);
            this.standard_Button_layout1.TabIndex = 1;
            this.standard_Button_layout1.Text = "standard_Button_layout1";
            this.standard_Button_layout1.UseVisualStyleBackColor = false;
            // 
            // test3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1586, 916);
            this.Controls.Add(this.standard_Button_layout1);
            this.Controls.Add(this.standard_Button_layout2);
            this.Name = "test3";
            this.ResumeLayout(false);

        }

        #endregion

        private Standard_Button_layout standard_Button_layout2;
        private Standard_Button_layout standard_Button_layout1;
    }
}