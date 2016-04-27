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
    public partial class Standard_Label : Label
    {
        public Standard_Label()
        {
            InitializeComponent();
            Font = new Font("Segoe UI", 15F, FontStyle.Regular);
            ForeColor = Color.White;
        }
    }
}
