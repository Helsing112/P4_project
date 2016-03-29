using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplication5
{
    public class Table_button //used to save the relevant data of the buttons
    {
        public string Table_Text { get; set; }
        public Point Location { get; set; }
        public Size size { get; set; }
    }
    public abstract class Table_Control : Button //the superclass of the buttons. Should ONLY contain the general aestethics
    {
        public override Color BackColor
        {
            get
            {
                return Color.Yellow;
            }
            set { }
        }
    }
    public class Table_Control_Manager : Table_Control //The table_control for the maneger window.
    {
        public void delete_control()
        {
            this.Parent = null;
        }

    }
    public class Table_Control_MainPage : Table_Control //The table_control for the Main window.
    {

    }
}
