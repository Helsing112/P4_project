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
    /// <summary>
    /// Standard properties for windows. Sets the borderstyle and background color. 
    /// </summary>
    public partial class Standard_Window_Layout : Form
    {
        public Standard_Window_Layout()
        {

            InitializeComponent();
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#e8eae8");
            //this.BackColor = Color.FromArgb(100, 235, 235, 235);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResizeRedraw = true;
        }

        // Makes a border around the forms
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid, Color.Black, 1, ButtonBorderStyle.Solid);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }
    }
}
