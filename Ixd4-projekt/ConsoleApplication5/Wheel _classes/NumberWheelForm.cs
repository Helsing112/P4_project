using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ConsoleApplication5
{
    public partial class NumberWheelForm : Form
    {
        public static int Amount_From_wheel { get; set; }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public NumberWheelForm(Rectangle input_rect)
        {
            InitializeComponent(input_rect);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Rectangle input_rect)
        {
            this.SuspendLayout();
            this.ClientSize = input_rect.Size;
            NumberWheel wheel = new NumberWheel(new Rectangle(0, 0, input_rect.Width, input_rect.Height));
            wheel.OnPieClicked += PieClicked;
            Controls.Add(wheel);

            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(input_rect);
            this.Region = new Region(graphics);
            // 
            // NumberWheelForm
            // 
            this.MouseLeave += NumberWheelForm_MouseLeave;
            this.ShowInTaskbar = false;
            this.BackColor = Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ResumeLayout(false);
        }

        private void NumberWheelForm_MouseLeave(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Shows the wheel with a set of properties on the location input 
        /// </summary>
        public void Show_NumberWheel()
        {
            Show_NumberWheel(new Point(MousePosition.X - this.Width / 2, MousePosition.Y - this.Height / 2));
        }

        public void Show_NumberWheel(Point WheelPosistion)
        {
            this.Location = WheelPosistion;
            this.Show();
            this.TopMost = true;
            this.Focus();
            mouse_event(MOUSEEVENTF_LEFTUP, MousePosition.X, MousePosition.Y, 0, 0);

        }

        public delegate void Pie_clicked(int number);
        public event Pie_clicked On_Pie_Clicked; //Event to the click on one of the pies
        private void PieClicked(int number)
        {
            if(On_Pie_Clicked != null)
            {
                On_Pie_Clicked(number);
            }
            this.Hide();
        }
        

        #endregion

        public void Show_wheel()
        {
            int size = 400;
            NumberWheelForm temp_wheel = new NumberWheelForm(new Rectangle(0, 0, size, size));
            temp_wheel.Location = new Point(MousePosition.X - size/2, MousePosition.Y - size/2);
            temp_wheel.Show();
        }

    }
}
