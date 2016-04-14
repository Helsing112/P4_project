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

            // Sunes test kode til tal på hjulet
            using (StringFormat string_format = new StringFormat())
            {
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;

                float label_x = (input_rectangle.Left + input_rectangle.Right) / 2f;
                float label_y = (input_rectangle.Top + input_rectangle.Bottom) / 2f;

                float label_radius = (input_rectangle.Width + input_rectangle.Height) / 2f * 0.33f;
                Graphics g = this.CreateGraphics();
                Brush lol = new SolidBrush(Color.Black);
                for (int index = 0; index < amount_of_pies; index++)
                {
                    float sweep_angle_label = (350f / amount_of_pies);
                    float start_angle_label = 0 + index * (360 / amount_of_pies) + 22;

                    double label_angle = Math.PI * (start_angle_label + sweep_angle_label / 2f) / 180f;
                    float single_label_x = label_x + (float)(label_radius * Math.Cos(label_angle));
                    float single_label_y = label_y + (float)(label_radius * Math.Sin(label_angle));

                    g.DrawString("lol", DefaultFont, lol, single_label_x, single_label_y, string_format);
                    start_angle_label += sweep_angle_label;
                }

            }
            // test kode slut

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
