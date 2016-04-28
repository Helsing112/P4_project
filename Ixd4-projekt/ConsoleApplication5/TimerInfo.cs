using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace ConsoleApplication5
{
    public partial class TimerInfo : UserControl
    {
        public TimerInfo()
        {
            InitializeComponent();

        }

        public void UpdateEmployeename(Employee name)
        {

            if (name.EmployeeName == null)
            {
                Employee_Name.Text = "";
            }
            else
            {
                Employee_Name.Text = name.EmployeeName;
            }
          
        }
        public void UpdateTableName(Table_Info table)
        {

            try
            {
                Table_Info.Text = (table.Table_name);
            }
            catch (NullReferenceException)
            {
                Employee_Name.Text = "";
            }            
        }
        public void DeleteNameAndTablesFromTimer()
        {
            Table_Info.Text = "";
            Employee_Name.Text = "";

        }

        public string tablename { get; set; }
        public string employeename { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock_Label.Text = string.Format("{0:t} d. {0:d}", DateTime.Now);
        }


        private void TableInfo_Click(object sender, EventArgs e)
        {
            Table_Info.Text = tablename;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TimerInfo_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
            this.BorderStyle = BorderStyle.None;
            this.Height = 50;
            this.BackColor = Color.White;
            Employee_Name.ForeColor = Color.Black;
            Table_Info.ForeColor = Color.Black;

        }
    }
}
