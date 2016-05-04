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
    public partial class SignOutOnJobWindow : Standard_Window_Layout
    {
        Control FormerParent;
        private Point FormerLocation;
        Control Employeepanel;
        public SignOutOnJobWindow()
        {
            InitializeComponent();
            
        }
        public void show_window(EmployeeSignInPanel PanelOfEmp)
        {
            this.Size = new Size(PanelOfEmp.Width + quit_Close_Button1.Width + 20, PanelOfEmp.Height + standard_Label1.Height+ 10);
            
            FormerParent = PanelOfEmp.Parent;
            Employeepanel = PanelOfEmp;
            FormerLocation = new Point(PanelOfEmp.Location.X, PanelOfEmp.Location.Y);
            
            PanelOfEmp.Location = new Point(4,standard_Label1.Height + 5);

            this.Controls.Add(PanelOfEmp);

            this.ShowDialog();
        }

        private void quit_Close_Button1_Button_Click(object sender, EventArgs e)
        {
            Employeepanel.Location = FormerLocation;
            Employeepanel.Parent = FormerParent;

            this.Close();
        }
    }
}
