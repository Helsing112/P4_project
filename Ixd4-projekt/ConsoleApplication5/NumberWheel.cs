using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class NumberWheel : UserControl
    {
        public NumberWheel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            Rectangle The_control_rect = new Rectangle(this.Location, this.Size);
            this.SuspendLayout();
            PieOnNumberWheel Pie_1 = new PieOnNumberWheel(The_control_rect, )
            // 
            // NumberWheel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NumberWheel";
            this.Size = new System.Drawing.Size(421, 358);
            this.ResumeLayout(false);

        }
    }
}
