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
        public NumberWheel(Rectangle inputRectangle)
        {
            InitializeComponent(inputRectangle);
        }
        private void InitializeComponent(Rectangle inputRectangle)
        {
            const int partToDevideCenter = 3;
            const int amountOfPies = 8;
            //Main control:
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Size = inputRectangle.Size;
            this.BackColor = Color.Transparent;
            this.Name = "NumberWheel";
            //
            //Middle of the wheel
            //
            Point centerOfControl = new Point(this.Width / 2, this.Height / 2);
            Rectangle centerRectangle = new Rectangle(0,0,(this.Width / partToDevideCenter), this.Height / partToDevideCenter);
            CenterOnNumberWheel centerCircle = new CenterOnNumberWheel(centerRectangle) {Name = "1"};
            centerCircle.MouseUp += Middle_clicked;
            centerCircle.Location = new Point(centerOfControl.X - (this.Width / partToDevideCenter) / 2, centerOfControl.Y - (this.Height / partToDevideCenter) / 2);
            centerCircle.BackColor = Color.LightGoldenrodYellow;
            Controls.Add(centerCircle);
            //iterate over the amount of pies added and instantiating them
            this.SuspendLayout();
            List<PieOnNumberWheel> pies = new List<PieOnNumberWheel>();

            // calculations regarding location of numbers
            float labelX = (inputRectangle.Left + inputRectangle.Right) / 2f;
            float labelY = (inputRectangle.Top + inputRectangle.Bottom) / 2f;
            float labelRadius = ((inputRectangle.Width + inputRectangle.Height) / 2f) * 0.33f;

            // Adds the pies of the wheel
            for (int i=0; i < amountOfPies; i++)
            {
                // calculates location for numbers on wheel
                const float sweepAngleLabel = (350f / amountOfPies);
                float startAngleLabel = 0 + i * (360 / amountOfPies) + 22;
                double labelAngle = Math.PI * (startAngleLabel + sweepAngleLabel / 2f) / 180f;
                float singleLabelX = labelX + (float)(labelRadius * Math.Cos(labelAngle));
                float singleLabelY = labelY + (float)(labelRadius * Math.Sin(labelAngle));
                startAngleLabel += sweepAngleLabel;
                // end of calculation

                pies.Add(new PieOnNumberWheel(inputRectangle, 0 + i * (360 / amountOfPies) + 22, (350 / amountOfPies), singleLabelX, singleLabelY, i));
            }

            int x = 2;
            foreach (PieOnNumberWheel item in pies)
            {
                item.MouseUp += Pie_click;
                item.TextToLabel = x.ToString();
                item.Name = x.ToString();
                item.BackColor = Color.Azure;                
                Controls.Add(item);
                item.BackColor = Color.LightGoldenrodYellow;                
                x++;
            }
            this.ResumeLayout(false);
        }

        private void Middle_clicked(object sender, MouseEventArgs e)
        {
            CenterOnNumberWheel tempSender = (CenterOnNumberWheel)sender;
            On_Pie_click(int.Parse(tempSender.Name));
        }

        public delegate void PieClicked(int number);
        public event PieClicked OnPieClicked;
        private void Pie_click(object sender, EventArgs e)
        {
            PieOnNumberWheel tempSender = (PieOnNumberWheel)sender;
            On_Pie_click(int.Parse(tempSender.Name));
        }

        protected virtual void On_Pie_click(int number)
        {
            OnPieClicked?.Invoke(number);
        }
    }
}
