namespace ConsoleApplication5
{
    partial class Table_management_AddTableForm
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
            this.Panel_ForFlowdiagram = new System.Windows.Forms.Panel();
            this.Label_forFlowPanel = new System.Windows.Forms.Label();
            this.label_AddNewTable = new System.Windows.Forms.Label();
            this.Label_tableNumber = new System.Windows.Forms.Label();
            this.textBox_NumberInput = new System.Windows.Forms.TextBox();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.label_preview = new System.Windows.Forms.Label();
            this.button_flip = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_add_confirm = new System.Windows.Forms.Button();
            this.Flow_TableType = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_ForFlowdiagram.SuspendLayout();
            this.panel_preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_ForFlowdiagram
            // 
            this.Panel_ForFlowdiagram.Controls.Add(this.Flow_TableType);
            this.Panel_ForFlowdiagram.Location = new System.Drawing.Point(13, 108);
            this.Panel_ForFlowdiagram.Name = "Panel_ForFlowdiagram";
            this.Panel_ForFlowdiagram.Size = new System.Drawing.Size(256, 478);
            this.Panel_ForFlowdiagram.TabIndex = 0;
            // 
            // Flow_TableType
            // 
            this.Flow_TableType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow_TableType.Location = new System.Drawing.Point(0, 0);
            this.Flow_TableType.Margin = new System.Windows.Forms.Padding(0);
            this.Flow_TableType.AutoScroll = true;
            this.Flow_TableType.Name = "Flow_TableType";
            this.Flow_TableType.Size = new System.Drawing.Size(256, 478);
            this.Flow_TableType.TabIndex = 0;
            // 
            // Label_forFlowPanel
            // 
            this.Label_forFlowPanel.AutoSize = true;
            this.Label_forFlowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_forFlowPanel.Location = new System.Drawing.Point(46, 79);
            this.Label_forFlowPanel.Name = "Label_forFlowPanel";
            this.Label_forFlowPanel.Size = new System.Drawing.Size(187, 26);
            this.Label_forFlowPanel.TabIndex = 1;
            this.Label_forFlowPanel.Text = "Choose table type";
            // 
            // label_addNewTable
            // 
            this.label_AddNewTable.AutoSize = true;
            this.label_AddNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddNewTable.Location = new System.Drawing.Point(169, 18);
            this.label_AddNewTable.Name = "label1";
            this.label_AddNewTable.Size = new System.Drawing.Size(194, 29);
            this.label_AddNewTable.TabIndex = 2;
            this.label_AddNewTable.Text = "Add a new table";
            // 
            // Label_tableNumber
            // 
            this.Label_tableNumber.AutoSize = true;
            this.Label_tableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_tableNumber.Location = new System.Drawing.Point(292, 170);
            this.Label_tableNumber.Name = "Label_tableNumber";
            this.Label_tableNumber.Size = new System.Drawing.Size(220, 26);
            this.Label_tableNumber.TabIndex = 3;
            this.Label_tableNumber.Text = "Choose table number";
            // 
            // textBox_NumberInput
            // 
            this.textBox_NumberInput.Location = new System.Drawing.Point(297, 199);
            this.textBox_NumberInput.MaxLength = 25;
            this.textBox_NumberInput.Name = "textBox_NumberInput";
            this.textBox_NumberInput.Size = new System.Drawing.Size(215, 22);
            this.textBox_NumberInput.TabIndex = 4;
            this.textBox_NumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_NumberInput.TextChanged += TextBox_NumberInput_TextChanged;
            // 
            // panel_preview
            // 
            this.panel_preview.Location = new System.Drawing.Point(298, 298);
            this.panel_preview.Name = "panel1";
            this.panel_preview.Size = new System.Drawing.Size(215, 163);
            this.panel_preview.TabIndex = 5;
            // 
            // label_preview
            // 
            this.label_preview.AutoSize = true;
            this.label_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_preview.Location = new System.Drawing.Point(360, 249);
            this.label_preview.Name = "label2";
            this.label_preview.Size = new System.Drawing.Size(90, 26);
            this.label_preview.TabIndex = 6;
            this.label_preview.Text = "Preview";
            // 
            // button_flip
            // 
            this.button_flip.Enabled = false;
            this.button_flip.Location = new System.Drawing.Point(490, 250);
            this.button_flip.Name = "button_flip";
            this.button_flip.Size = new System.Drawing.Size(43, 27);
            this.button_flip.TabIndex = 8;
            this.button_flip.Text = "Flip";
            this.button_flip.UseVisualStyleBackColor = true;
            this.button_flip.Click += new System.EventHandler(this.button_flip_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(438, 539);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 47);
            this.button_quit.TabIndex = 7;
            this.button_quit.Text = "Exit";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_add_confirm
            // 
            this.button_add_confirm.Location = new System.Drawing.Point(357, 539);
            this.button_add_confirm.Name = "button_add_confirm";
            this.button_add_confirm.Size = new System.Drawing.Size(75, 47);
            this.button_add_confirm.TabIndex = 8;
            this.button_add_confirm.Text = "Add table";
            this.button_add_confirm.UseVisualStyleBackColor = true;
            this.button_add_confirm.Click += new System.EventHandler(this.button_add_confirm_Click);
            // 
            // Table_management_AddTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 601);
            this.Controls.Add(this.button_add_confirm);
            this.Controls.Add(this.button_flip);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.label_preview);
            this.Controls.Add(this.panel_preview);
            this.Controls.Add(this.textBox_NumberInput);
            this.Controls.Add(this.Label_tableNumber);
            this.Controls.Add(this.label_AddNewTable);
            this.Controls.Add(this.Label_forFlowPanel);
            this.Controls.Add(this.Panel_ForFlowdiagram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table_management_AddTableForm";
            this.Text = "Table_management_AddTableForm";
            this.Panel_ForFlowdiagram.ResumeLayout(false);
            this.panel_preview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel Panel_ForFlowdiagram;
        private System.Windows.Forms.Label Label_forFlowPanel;
        private System.Windows.Forms.Label label_AddNewTable;
        private System.Windows.Forms.Label Label_tableNumber;
        private System.Windows.Forms.TextBox textBox_NumberInput;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.Label label_preview;
        private System.Windows.Forms.Button button_flip;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_add_confirm;
        private System.Windows.Forms.FlowLayoutPanel Flow_TableType;
    }
}