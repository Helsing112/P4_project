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
    public partial class Message_box : Form
    {
        public Message_box()
        {
        }
        private void InitializeComponent(string input_string, int tick_mode)
        {
            string image_location = @"..\..\..\..\Library\Picture For Message Box\";

            //
            //test label
            //
            Label Test_label = new System.Windows.Forms.Label();
            Test_label.AutoSize = true;
            Test_label.Text = "A";

            int label_size = 0;
            int picture_size = 50;
            int Total_height = 50;

            this.label1 = new System.Windows.Forms.Label(); //need to be instantiated before it can be used in textrendere

            label_size = TextRenderer.MeasureText(input_string, label1.Font).Width;
           


            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(picture_size, Total_height);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = false;           
            this.label1.Location = new System.Drawing.Point(picture_size, 0);
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(label_size, Total_height);
            this.label1.TabIndex = 1;
            this.label1.Text = input_string;


            //IF else to set tick mode
            if (tick_mode == 1)
            {
                image_location += "tick_green.png"; //if tick is green
                pictureBox1.Image = Image.FromFile(image_location);
                this.BackColor = Color.LightGreen;
                this.Controls.Add(pictureBox1);
            }
            else
            {
                if(tick_mode == -1)
                {
                    image_location += "tick_red.png"; //if tick is green
                    pictureBox1.Image = Image.FromFile(image_location);
                    this.BackColor = Color.PaleVioletRed;
                    this.Controls.Add(pictureBox1);
                }
                else { }
            }
            // 
            // Message_Box_standard
            //    
            
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 0);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(picture_size*2+label_size,Total_height);
            this.Controls.Add(label1);            
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message_box_standard";
            this.Text = "Message_box_standard";
            this.ResumeLayout(false);
            //Timer
            Timer timer = new Timer();
            timer.Interval = 2500 + input_string.Length * 50;
            timer.Start();
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();
            this.Dispose();
        }
        /// <summary>
        /// Message to user. Tick mode 1 == green, -1 == red, 0 == neutral
        /// </summary>
        /// <param name="input_string"></param>
        /// <param name="tick_mode"></param>
        public static void Message(string input_string, int tick_mode)
        {
            Message_box temp_box = new Message_box();
            temp_box.InitializeComponent(input_string, tick_mode);
            temp_box.Show();
        }
        public static void Message(string input_string)
        {
            Message(input_string, 1);
        }


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
