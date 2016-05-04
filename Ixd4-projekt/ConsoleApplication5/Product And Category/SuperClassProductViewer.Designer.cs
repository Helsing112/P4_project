using System.Windows.Forms;
namespace ConsoleApplication5
{
    partial class SuperClassProductViewer
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
            this.Flow_ProductsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelBackButton = new System.Windows.Forms.Panel();
            this.back_Button1 = new ConsoleApplication5.Back_Button();
            this.Label_Headline = new ConsoleApplication5.Standard_Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelBackButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flow_ProductsFlow
            // 
            this.Flow_ProductsFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flow_ProductsFlow.AutoScroll = true;
            this.Flow_ProductsFlow.Location = new System.Drawing.Point(0, 87);
            this.Flow_ProductsFlow.Name = "Flow_ProductsFlow";
            this.Flow_ProductsFlow.Size = new System.Drawing.Size(705, 413);
            this.Flow_ProductsFlow.TabIndex = 0;
            // 
            // PanelBackButton
            // 
            this.PanelBackButton.Controls.Add(this.back_Button1);
            this.PanelBackButton.Location = new System.Drawing.Point(3, 3);
            this.PanelBackButton.Name = "PanelBackButton";
            this.PanelBackButton.Size = new System.Drawing.Size(167, 81);
            this.PanelBackButton.TabIndex = 2;
            // 
            // back_Button1
            // 
            this.back_Button1.BackColor = System.Drawing.Color.Transparent;
            this.back_Button1.Image_set = null;
            this.back_Button1.Location = new System.Drawing.Point(0, 0);
            this.back_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_Button1.Name = "back_Button1";
            this.back_Button1.Size = new System.Drawing.Size(167, 79);
            this.back_Button1.TabIndex = 0;
            this.back_Button1.Textlabel = "Back";
            // 
            // Label_Headline
            // 
            this.Label_Headline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Headline.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_Headline.ForeColor = System.Drawing.Color.Black;
            this.Label_Headline.Location = new System.Drawing.Point(176, 3);
            this.Label_Headline.Name = "Label_Headline";
            this.Label_Headline.Size = new System.Drawing.Size(356, 81);
            this.Label_Headline.TabIndex = 3;
            this.Label_Headline.Text = "standard_Label1";
            this.Label_Headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Headline);
            this.panel1.Controls.Add(this.PanelBackButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 85);
            this.panel1.TabIndex = 4;
            // 
            // SuperClassProductViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Flow_ProductsFlow);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SuperClassProductViewer";
            this.Size = new System.Drawing.Size(705, 500);
            this.PanelBackButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel Flow_ProductsFlow;
        private System.Windows.Forms.Panel PanelBackButton;
        public Back_Button back_Button1;
        private Standard_Label Label_Headline;
        private Panel panel1;
    }
}
