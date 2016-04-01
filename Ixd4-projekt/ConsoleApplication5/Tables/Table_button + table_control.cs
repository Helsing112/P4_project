using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace ConsoleApplication5
{
    public class Table_Info
    {

    }
    public class Table_button_Xml_data //used to save the relevant data of the buttons
    {
        public string Table_Text { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Table_Button_Type_Xml_data TableType { get; set; }
    }
    public class Table_Button_Type_Xml_data //Used to save the relevant data of the button types
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public Region Region { get; set; }
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
    public class Table_Control_Manager : Table_Control //The table_control for the manager window.
    {
        public void delete_control()
        {
            this.Parent = null;            
        }
        public Table_Control_Manager CloneForAddConfirm()
        {
            Table_Control_Manager temp_control = new Table_Control_Manager();
            temp_control.Size = this.Size;
            temp_control.Text = this.Text;
            return temp_control;
        }


    }
    public class Table_Control_MainPage : Table_Control //The table_control for the Main window.
    {
        Table_Info table_info;
        public Table_Control_MainPage()
        {

        }
    }
}
