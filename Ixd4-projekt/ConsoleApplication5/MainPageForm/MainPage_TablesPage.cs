using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class Main_page
    {
        public Employee ActiveEmployee { get; private set; }
        /// <summary>
        /// Clears controls and Draws the page with the table panel
        /// </summary>
        /// <param name="Active_employee">The employee that is active</param>
        private void Draw_tablesPage(Employee Active_employee)
        {
            Controls.Clear();
            ActiveEmployee = Active_employee;

            Controls.Add(tables_panel);
            Controls.Add(BackToFrontPageButton);
        }
        
        private void Initialize_Field_Controls_tablesPage()
        {
            BackToFrontPage_button(new System.Drawing.Point(12, 245), new System.Drawing.Size(139, 79));
            Tables_panel(new Point(200, 20), Size_of_table_panel);
        }
        //field controls
        Table_Panel_for_MainPage tables_panel;
        Button BackToFrontPageButton;

        #region Table page methods--------------------------
        private void Tables_panel(Point Location_input, Size size_input)
        {
            tables_panel = new Table_Panel_for_MainPage(size_input);
            tables_panel.TableClick += OnTableClick;
            tables_panel.Location = Location_input;
        }



        public void BackToFrontPage_button(Point Location_input, Size size_input)
        {
            BackToFrontPageButton = new Button();
            BackToFrontPageButton.Location = Location_input;
            BackToFrontPageButton.Name = "CheckInButton";
            BackToFrontPageButton.Size = size_input;
            BackToFrontPageButton.TabIndex = 0;
            BackToFrontPageButton.Text = "Back";
            BackToFrontPageButton.UseVisualStyleBackColor = true;
            BackToFrontPageButton.Click += new System.EventHandler(BackToFrontPage_click);
        }
        #endregion

        #region Eventhandlers-----------------------------
        public void BackToFrontPage_click(object sender, EventArgs e)
        {
            Draw_startPage(); //returns to the start page
        }
        private void OnTableClick(object sender, EventArgs e)
        {
            Table_Control_MainPage temp_control = (Table_Control_MainPage)sender;
            Draw_CreateReceipt(ActiveEmployee, temp_control.TableInfo);
        }
        #endregion
    }
}
