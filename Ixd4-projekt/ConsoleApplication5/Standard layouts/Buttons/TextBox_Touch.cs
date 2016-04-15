using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConsoleApplication5
{
    /// <summary>
    /// Basic textbox layout, that includes the opening of the touch keyboard 
    /// </summary>
    public partial class TextBox_Touch : UserControl
    {
        public TextBox_Touch()
        {
            InitializeComponent();
            this.textBox1.Click += new System.EventHandler(this.textbox_Click);
            //this.textBox1.MouseLeave += new System.EventHandler(this.textbox_Focus);
        }
        // Opens the touch keyboard
        private void textbox_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Common Files\Microsoft Shared\ink\TabTip.exe");

        }
        // Kills the onscreen keyboard when mouse leaves the textbox 
        //private void textbox_Focus(object sender, EventArgs e)
        //{
        //    Process[] oskProcess = Process.GetProcessesByName("TabTip");
        //    foreach (Process process in oskProcess)
        //    {
        //        process.Kill();
        //    }
        //}

    }
}
