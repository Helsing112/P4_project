using System;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    partial class ProductButtonCtrl <T>
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
        private void InitializeComponent(Product MAD)
        {
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.MAD = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
           
            // 
            // MAD
            // 
            
            this.MAD.AutoSize = true;
            this.MAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
           | System.Windows.Forms.AnchorStyles.Left)
           | System.Windows.Forms.AnchorStyles.Right)));

            this.MAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MAD.Name = "MAD";
            this.MAD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MAD.Size = new System.Drawing.Size(24, 13);
            this.MAD.TabIndex = 0;
            this.MAD.Text = MAD.Name;

            this.MAD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.MAD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TypeButtonCtrl_MouseUp);
            this.MAD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TypeButtonCtrl_MouseDown);


            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ProductButtonCtrl
            // 
     
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MAD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductButtonCtrl";
            this.Size = new System.Drawing.Size(117, 117);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TypeButtonCtrl_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TypeButtonCtrl_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label MAD;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
