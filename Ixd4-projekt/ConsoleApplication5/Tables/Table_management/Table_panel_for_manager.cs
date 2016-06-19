using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class Table_panel_for_manager : UserControl
    {
        //fields for drag and drop
        private Control activeControl; //field to store which control is clicked
        private Point previousLocation;
        //fields for selection
        private Table_Control_Manager selectedControl;
        public Control ActiveControl { get { return activeControl; }}
        private Color selectedControlPrevBackColor;
        public Table_panel_for_manager(List<Table_Control_Manager> List_input)
        {
            InitializeComponent();
            Add_controls(List_input);
        }
        public void Add_table(Table_Control_Manager input_table) //function to add table from "outside"
        {
            input_table.MouseDown += Table_MouseDown;
            input_table.MouseUp += Table_MouseUp;
            input_table.MouseMove += Table_MouseMove;
            this.Controls.Add(input_table);
        }
        private void Add_controls(List<Table_Control_Manager> list_input)
        {
            foreach (Table_Control_Manager item in list_input)//iterate through the Buttons of the List 
            {
                item.MouseDown += Table_MouseDown;
                item.MouseUp += Table_MouseUp;
                item.MouseMove += Table_MouseMove;
                Controls.Add(item);                 
            }
        }

        #region Event handlers for drag & drop and click of table
        private void Table_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
            {
                return;
            }
            Point location = activeControl.Location;

            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
        }

        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            activeControl = null;
            selectedControl = (Table_Control_Manager)sender;        
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
        }
        public void Delete_selected_control()
        {
            if(selectedControl != null)
            selectedControl.delete_control();
        }
        #endregion

        #region Component Designer generated code
        /// <summary> 
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Table_panel_for_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.Name = "Table_panel_for_manager";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ResumeLayout(false);
        }



        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion

    }
}
