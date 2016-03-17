using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public class Standard_Button_layout : System.Windows.Forms.Button
    {
        public Standard_Button_layout() : base()
        {

            ForeColor = System.Drawing.SystemColors.ControlText;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Segoe UI", 20F);
            Size = new System.Drawing.Size(400, 100);
            BackColor = System.Drawing.Color.Blue;
            

        }
    }
}
