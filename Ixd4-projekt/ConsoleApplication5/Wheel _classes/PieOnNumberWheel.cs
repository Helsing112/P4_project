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

namespace ConsoleApplication5
{
    public partial class PieOnNumberWheel : UserControl
    {
        private Color prev_color { get; set; }
        public string Text_To_Label { get; set; }
        public PieOnNumberWheel(Rectangle rektangle, int start_pos_angle, int Sweep_angle)
        {
            InitializeComponent(rektangle,start_pos_angle, Sweep_angle);
        }
        private void InitializeComponent(Rectangle rektangle, int start_pos_angle, int Sweep_angle)
        {
            this.Height = rektangle.Height;
            this.Width = rektangle.Width;
            this.SuspendLayout();
            GraphicsPath graphics = new GraphicsPath(FillMode.Alternate);
            graphics.AddPie(rektangle.Location.X, rektangle.Location.Y,rektangle.Width, rektangle.Height, start_pos_angle, Sweep_angle);
            //
            //Label properties
            //
            Label Text_label = new Label();
            Text_label.AutoSize = false;
            Text_label.Text = Text_To_Label;
            Text_label.Region = new Region(graphics);
            Text_label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(Text_label);
            //
            //main control props
            //            
            this.MouseEnter += PieOnNumberWheel_MouseEnter;
            this.MouseLeave += PieOnNumberWheel_MouseLeave;
            this.Region = new Region(graphics);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "UserControl1";
            this.ResumeLayout(false);
        }

        private void PieOnNumberWheel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = prev_color;
        }

        private void PieOnNumberWheel_MouseEnter(object sender, EventArgs e)
        {
            prev_color = this.BackColor;
            this.BackColor = Color.Yellow;
        }
    }
}
