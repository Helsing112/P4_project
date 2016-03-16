using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ConsoleApplication5
{
    public partial class PieOnNumberWheel : UserControl
    {
        public PieOnNumberWheel(Rectangle rektangle, int start_pos_angle, int Sweep_angle)
        {
            InitializeComponent(rektangle,start_pos_angle, Sweep_angle);
        }
        private void InitializeComponent(Rectangle rektangle, int start_pos_angle, int Sweep_angle)
        {
            this.SuspendLayout();
            GraphicsPath graphics = new GraphicsPath(FillMode.Alternate);
            graphics.AddPie(rektangle, start_pos_angle, Sweep_angle);

            this.Region = new Region(graphics);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserControl1";
            this.ResumeLayout(false);
        }
    }
}
