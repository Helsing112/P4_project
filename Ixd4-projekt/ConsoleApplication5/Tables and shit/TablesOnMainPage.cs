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
    public partial class TablesOnMainPage : UserControl
    {
        public TablesOnMainPage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TablesOnMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TablesOnMainPage";
            this.Size = new System.Drawing.Size(293, 273);
            this.ResumeLayout(false);
            this.BorderStyle = BorderStyle.Fixed3D;

        }



    }
}
