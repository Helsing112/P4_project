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
    }
}
