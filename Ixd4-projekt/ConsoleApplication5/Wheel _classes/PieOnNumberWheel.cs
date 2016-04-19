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
        public PieOnNumberWheel(Rectangle rektangle, int start_pos_angle, int Sweep_angle, float posx, float posy, int number_on_wheel)
        {
            _posx = posx;
            _posy = posy;
            _number = number_on_wheel + 2;
            InitializeComponent(rektangle,start_pos_angle, Sweep_angle);


            this.MouseEnter += PieOnNumberWheel_MouseEnter;
            this.MouseLeave += PieOnNumberWheel_MouseLeave;

        }
        private float _posx;
        private float _posy;
        private int _number;
        private void InitializeComponent(Rectangle rektangle, int start_pos_angle, int Sweep_angle)
        {
            this.Height = rektangle.Height;
            this.Width = rektangle.Width;
            this.SuspendLayout();
            GraphicsPath graphics = new GraphicsPath();                        

            // sets the properties of the numbers on the wheel
            string stringText = _number.ToString();
            FontFamily family = new FontFamily("Segoe UI");
            int fontStyle = (int)FontStyle.Bold;
            int emSize = 35;
            PointF origin = new PointF(_posx, _posy);
            StringFormat format = StringFormat.GenericDefault;
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            graphics.AddString(stringText, family, fontStyle, emSize, origin, format);
            graphics.CloseFigure();
            graphics.AddPie(rektangle.Location.X, rektangle.Location.Y, rektangle.Width, rektangle.Height, start_pos_angle, Sweep_angle); //standard method for drawing a pie
            graphics.CloseFigure();
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
