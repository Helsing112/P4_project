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
    public partial class CenterOnNumberWheel : UserControl
    {
        private Color prev_color { get;  set; }

        public CenterOnNumberWheel(Rectangle input_rect)
        {
            InitializeComponent(input_rect);
        }


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Rectangle input_rect)
        {
            this.Size = input_rect.Size;
            GraphicsPath graphics = new GraphicsPath(FillMode.Alternate);
            graphics.AddEllipse(input_rect);
            PointF center = new PointF(input_rect.Width / 2, input_rect.Height / 2);

            string stringText = "1";
            FontFamily family = new FontFamily("Segoe UI");
            int fontStyle = (int)FontStyle.Bold;
            int emSize = 35;
            StringFormat format = StringFormat.GenericDefault;
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            this.BackColor = Color.DarkCyan;
            graphics.AddString(stringText, family, fontStyle, emSize, center, format);
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.MouseLeave += CenterOnNumberWheel_MouseLeave;
            this.MouseEnter += CenterOnNumberWheel_MouseEnter;
            this.Region = new Region(graphics);

            

        }

        private void CenterOnNumberWheel_MouseEnter(object sender, EventArgs e)
        {
            prev_color = this.BackColor;
            this.BackColor = Color.Yellow;
        }

        private void CenterOnNumberWheel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = prev_color;
        }


        #endregion
    }
}
