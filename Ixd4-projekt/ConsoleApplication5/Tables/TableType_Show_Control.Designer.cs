namespace ConsoleApplication5
{
    partial class TableType_Show_Control
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
            this.label_TypeName = new System.Windows.Forms.Label();
            this.panel_Display = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_TypeName
            // 
            this.label_TypeName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TypeName.Location = new System.Drawing.Point(0, 0);
            this.label_TypeName.Name = "label_TypeName";
            this.label_TypeName.Size = new System.Drawing.Size(148, 26);
            this.label_TypeName.TabIndex = 0;
            this.label_TypeName.Text = "Type";
            this.label_TypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_TypeName.Click += new System.EventHandler(this.label_TypeName_Click);
            // 
            // panel_Display
            // 
            this.panel_Display.Location = new System.Drawing.Point(3, 29);
            this.panel_Display.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Display.Name = "panel_Display";
            this.panel_Display.Size = new System.Drawing.Size(142, 89);
            this.panel_Display.TabIndex = 1;
            // 
            // TableType_preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Display);
            this.Controls.Add(this.label_TypeName);
            this.Name = "TableType_preview";
            this.Size = new System.Drawing.Size(148, 121);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_TypeName;
        private System.Windows.Forms.Panel panel_Display;
    }
}
