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
    public partial class Custom_FlowLayOutPanel : FlowLayoutPanel
    {
        const int PADDING = 3;
        public Size MaxSize { get; set; }
        public Point StartLocation { get; set; }
        public Size ControlsTotalSize { get; private set; }



        public Custom_FlowLayOutPanel()
        {
            InitializeComponent();
            this.BackColor = Color.Blue;

        }
        // SKAL FJERNES
        private void Custom_FlowLayOutPanel_ParentChanged(object sender, System.EventArgs e)
        {
            //MaxSize = this.Size;
            //StartLocation = this.Location;

            //this.Width = 5;
            //CorrectXLocation();
        }

        private void Custom_FlowLayOutPanel_ControlRemoved(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            
        }
        public void InitializeSize()
        {
            MaxSize = this.Size;
            StartLocation = this.Location;

            this.Width = 5;
            CorrectXLocation();
        }

        private void Custom_FlowLayOutPanel_ControlAdded(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            e.Control.Padding = new Padding(PADDING);
            e.Control.Margin = new Padding(0);

            ADDControltotalSize(e.Control.Size);
        }

        // We assume that all controls are the same size  <-------------
        private void ADDControltotalSize(Size value)
        {
            if(Width < value.Width) // if we add an very wide control. Or the first control.
            {
                Width = value.Width + 2;
                CorrectXLocation();
            }
            int tempHeight = ControlsTotalSize.Height + value.Height + 1;

            if(MaxSize.Height < tempHeight)
            {
                this.Width += value.Width;
                CorrectXLocation();
                ControlsTotalSize = new Size(ControlsTotalSize.Width, 0);
            }
            else
            {                
                ControlsTotalSize = new Size(ControlsTotalSize.Width, tempHeight);
            }
        }
        private void CorrectXLocation()
        {
            this.Location = new Point((MaxSize.Width/2) - (this.Width / 2), 0);
        }
    }
}
