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
    public partial class NumberWheel : UserControl
    {
        public NumberWheel(Rectangle input_rectangle)
        {
            InitializeComponent(input_rectangle);
        }
        private void InitializeComponent(Rectangle input_rectangle)
        {
            int Part_to_devide_center = 3;
            int amount_of_pies = 8;
            //Main control:
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Size = input_rectangle.Size;
            this.BackColor = Color.Transparent;
            this.Name = "NumberWheel";
            //
            //Middle of the wheel
            //
            Point Center_of_control = new Point(this.Width / 2, this.Height / 2);
            Rectangle Center_rectangle = new Rectangle(0,0,(this.Width / Part_to_devide_center), this.Height / Part_to_devide_center);
            CenterOnNumberWheel Center_circle = new CenterOnNumberWheel(Center_rectangle);
            Center_circle.Name = "1";
            Center_circle.MouseUp += Middle_clicked;
            Center_circle.Location = new Point(Center_of_control.X - (this.Width / Part_to_devide_center) / 2, Center_of_control.Y - (this.Height / Part_to_devide_center) / 2);
            Center_circle.BackColor = Color.LightGoldenrodYellow;
            Controls.Add(Center_circle);
            //iterate over the amount of pies added and instantiating them
            this.SuspendLayout();
            List<PieOnNumberWheel> Pies = new List<PieOnNumberWheel>();
            for (int i=0; i < amount_of_pies; i++)
            {
                Pies.Add(new PieOnNumberWheel(input_rectangle, 0 + i * (360 / amount_of_pies)+22, (350 / amount_of_pies)));
            }

            int x = 2;
            foreach (PieOnNumberWheel item in Pies)
            {
                item.MouseUp += Pie_click;
                item.Text_To_Label = x.ToString();
                item.Name = x.ToString();
                item.BackColor = Color.Azure;                
                Controls.Add(item);
                item.BackColor = Color.LightGoldenrodYellow;
                
                x++;
            }

            // 
            // NumberWheel
            // 
            this.ResumeLayout(false);

        }

        private void Middle_clicked(object sender, MouseEventArgs e)
        {
            CenterOnNumberWheel temp_sender = (CenterOnNumberWheel)sender;
            On_Pie_click(int.Parse(temp_sender.Name));
        }

        public delegate void Pie_clicked(int number);
        public event Pie_clicked On_Pie_Clicked;
        private void Pie_click(object sender, EventArgs e)
        {
            PieOnNumberWheel temp_sender = (PieOnNumberWheel)sender;
            On_Pie_click(int.Parse(temp_sender.Name));
        }


        protected virtual void On_Pie_click(int number)
        {
            if(On_Pie_Clicked != null)
            {
                On_Pie_Clicked(number);
            }
        }
    }
}
