using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class Table_management_form : Form
    {
        private List<Table_Control_Manager> table_list;
        private System.Windows.Forms.Button Quit_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private Button Save_Button;
        private Table_panel_for_manager table_panel_for_manager;

        public Table_management_form()
        {
            table_list = XmlTableFileReader.Read_File(); //get tables from file.
            InitializeComponent();
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            XmlTableFileWriter.Save(table_panel_for_manager.Controls); //saves the list of buttons from the panel
            Messages.ConfirmTableBeenSaved();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            table_panel_for_manager.Add_table(new Table_Control_Manager());
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            table_panel_for_manager.Delete_selected_control();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Quit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.table_panel_for_manager = new Table_panel_for_manager(table_list);
            this.Save_Button = new Button();
            this.SuspendLayout();
            this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.BackColor = Color.Blue;
            // 
            // Quit_button
            // 
            this.Quit_button.Size = new System.Drawing.Size(75, 75);
            this.Quit_button.Location = new Point(this.Size.Width + 150, this.Size.Height - Quit_button.Height - 10);
            this.Quit_button.Anchor = AnchorStyles.Bottom;
            this.Quit_button.Name = "Quit_button";
            this.Quit_button.TabIndex = 0;
            this.Quit_button.Text = "Quit";
            this.Quit_button.UseVisualStyleBackColor = true;
            this.Quit_button.Click += Quit_button_Click;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(22, 13);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 75);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add Table";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += Add_button_Click;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(22, 93);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 75);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "Delete Table";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += Delete_Button_Click;
            //
            // Save Button
            //
            this.Save_Button.Location = new System.Drawing.Point(22, 173);
            this.Save_Button.Name = "Save Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 75);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += Save_Button_Click;
            // 
            // table_panel_for_manager1
            // 
            this.table_panel_for_manager.Anchor = AnchorStyles.None;
            this.table_panel_for_manager.Location = new System.Drawing.Point(125, 7);
            this.table_panel_for_manager.Width = this.Size.Width - 200;
            this.table_panel_for_manager.Height = this.Size.Height;
            this.table_panel_for_manager.Name = "table_panel_for_manager1";
            this.table_panel_for_manager.TabIndex = 3;
            this.table_panel_for_manager.BackColor = Color.Black;
            // 
            // Table_management_form
            //             
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = false;
            this.AutoSize = false;
            this.Controls.Add(Save_Button);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.table_panel_for_manager);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table_management_form";
            this.Text = "Table_management_form";
            this.ResumeLayout(false);
        }


        #endregion
    }
}
