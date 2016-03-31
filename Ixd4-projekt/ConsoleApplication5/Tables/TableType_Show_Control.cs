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
    public partial class TableType_Show_Control : UserControl
    {
        public TableType_Show_Control(Table_Control_Manager input)
        {
            InitializeComponent();
            Add_table_preview(input);
        }

        private void Add_table_preview(Table_Control_Manager input)
        {
            label_TypeName.Text = input.Name;
            //if(input.Width > input.Height)
            //{
            //    float ratio = input.Height / input.Width;
            //    input.Width = panel_Display.Width - 5;
            //    input.Height = (int)(input.Width * ratio);
            //}
            //else
            //{
            //    float ratio = input.Width / input.Height;
            //    input.Height = panel_Display.Height - 5;
            //    input.Width = (int)(input.Height * ratio);
            //}
            input.Location = new Point(0, 0);
            input.Click += Click_onTableType;
            panel_Display.Controls.Add(input);
        }

        public EventHandler TableTypeClicked;
        private void Click_onTableType(object sender, EventArgs e)
        {
            if(TableTypeClicked != null)
            {
                TableTypeClicked(sender, e); //activate the event tabletypeclicked
            }
        }

        private void label_TypeName_Click(object sender, EventArgs e)
        {

        }
    }
}
