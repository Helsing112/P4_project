using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ConsoleApplication5
{
    public partial class PieOnNumberWheel : UserControl
    {
        private Color PrevColor { get; set; }
        public string TextToLabel { get; set; }
        public PieOnNumberWheel(Rectangle rektangle, int startPosAngle, int sweepAngle, float posX, float posY, int numberOnWheel)
        {
            _posx = posX;
            _posy = posY;
            _number = numberOnWheel + 2;
            InitializeComponent(rektangle,startPosAngle, sweepAngle);


            this.MouseEnter += PieOnNumberWheel_MouseEnter;
            this.MouseLeave += PieOnNumberWheel_MouseLeave;

        }
        private readonly float _posx;
        private readonly float _posy;
        private readonly int _number;
        private void InitializeComponent(Rectangle rektangle, int startPosAngle, int sweepAngle)
        {
            this.Height = rektangle.Height;
            this.Width = rektangle.Width;
            this.SuspendLayout();
            GraphicsPath graphics = new GraphicsPath(FillMode.Alternate);

            // sets the properties of the numbers on the wheel
            string stringText = _number.ToString();
            this.BackColor = Color.FromArgb(100, 26, 117, 190);

            FontFamily family = new FontFamily("Segoe UI");
            const int fontStyle = (int)FontStyle.Bold;
            const int emSize = 35;
            PointF origin = new PointF(_posx, _posy);
            StringFormat format = StringFormat.GenericDefault;
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            graphics.AddString(stringText, family, fontStyle, emSize, origin, format);
            // numbers have been drawn
            
            graphics.AddPie(rektangle.Location.X, rektangle.Location.Y, rektangle.Width, rektangle.Height, startPosAngle, sweepAngle); //standard method for drawing a pie

            this.Region = new Region(graphics);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "UserControl1";
            this.ResumeLayout(false);
        }

        private void PieOnNumberWheel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = PrevColor;
        }

        private void PieOnNumberWheel_MouseEnter(object sender, EventArgs e)
        {
            PrevColor = this.BackColor;
            this.BackColor = Color.FromArgb(255, 26, 117, 190);
        }
    }
}
