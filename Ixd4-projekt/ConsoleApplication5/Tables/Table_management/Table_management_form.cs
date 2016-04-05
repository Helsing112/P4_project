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
        private Button Settings_button;

        public Table_management_form(Size Size_of_table_panel)
        {
            table_list = XmlTableFileReader.Read_File_For_Manager(); //get tables from file.
            InitializeComponent(Size_of_table_panel);
        }
        #region Button click eventhandlers
        private void Save_Button_Click(object sender, EventArgs e)
        {
            XmlTableFileWriter.Save(table_panel_for_manager.Controls); //saves the list of buttons from the panel
            Messages.ConfirmTableBeenSaved();
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            Table_Control_Manager temp_control = Table_management_AddTableForm.Show_addForm();
            if(temp_control != null)
            {
                table_panel_for_manager.Add_table(temp_control);
            }
        }
        private void Quit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            table_panel_for_manager.Delete_selected_control();
        }
        private void Settings_button_Click(object sender, EventArgs e)
        {
            Table_management_settings_form settings_form = new Table_management_settings_form();
            settings_form.ShowDialog();
            settings_form.TopMost = true;
        }
        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Size Size_of_table_panel)
        {
            this.Quit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.table_panel_for_manager = new Table_panel_for_manager(table_list);
            this.Save_Button = new Button();
            this.SuspendLayout();
            this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            // 
            // Table_management_form
            //             
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = false;
            this.AutoSize = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table_management_form";
            this.Text = "Table_management_form";
            this.ResumeLayout(false);
            // 
            // Quit_button
            // 
            this.Quit_button.Size = new System.Drawing.Size(75, 75);
            this.Quit_button.Location = new Point(this.Size.Width- Quit_button.Width, this.Size.Height - Quit_button.Height);
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
            this.table_panel_for_manager.AutoScaleMode = AutoScaleMode.Font;
            this.table_panel_for_manager.Location = new System.Drawing.Point(125, 7);
            
            this.table_panel_for_manager.Size = Size_of_table_panel;
            this.table_panel_for_manager.Name = "table_panel_for_manager1";
            try
            {
                this.table_panel_for_manager.BackgroundImage = Image.FromFile(Properties.Settings.Default.Path_of_resturant_plan);
            }
            catch (Exception)
            { //We dont want to crash the system, just because our picture is not there
            }
            this.table_panel_for_manager.BackgroundImageLayout = ImageLayout.Stretch;            
            //
            //Settings Button
            //
            this.Settings_button = new Button();
            this.Settings_button.Size = new Size(75, 75);
            this.Settings_button.Location = new Point(this.Width - Settings_button.Width - 5, 5);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Click += Settings_button_Click;
            this.Settings_button.Text = "Settings";
            //add controls
            this.Controls.Add(Settings_button);
            this.Controls.Add(Save_Button);
            this.Controls.Add(this.Quit_button);
            this.Controls.Add(this.table_panel_for_manager);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
        }




        #endregion
    }
}
