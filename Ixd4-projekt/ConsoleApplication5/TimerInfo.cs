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
                NameTextBox.Text = "";
            }
            else
            {
                NameTextBox.Text = (name.EmployeeName);
            }
          
        }
        public void UpdateTableName(Table_Info table)
        {
            if (table.Table_name== null)
            {
                NameTextBox.Text = "";
            }
            else
            {
                TableInfo.Text = (table.Table_name);
            }

            
        }
        public void DeleteNameAndTablesFromTimer()
        {
            TableInfo.Text = "";
            NameTextBox.Text = "";
        }

        public string tablename { get; set; }
        public string employeename { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            TimerText.Text = string.Format("{0}",DateTime.Now.TimeOfDay);
            // if (DateTime.Now.Second < 10)
            //{
            //    Timer.Text = string.Format("{0}:{1}.{2}", DateTime.Now.Hour, DateTime.Now.Minute, 0+DateTime.Now.Second);
            //}
            //else
            //{
            //    Timer.Text = string.Format("{0}:{1}.{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //}
        }

       
        private void TableInfo_Click(object sender, EventArgs e)
        {
            TableInfo.Text = tablename;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TimerInfo_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }
    }
}
