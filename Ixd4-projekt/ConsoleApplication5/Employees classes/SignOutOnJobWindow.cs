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
        Control Employeepanel;
        public SignOutOnJobWindow()
        {
            InitializeComponent();
            
        }
        public void show_window(SignInPanelControl PanelOfEmp)
        {
            FormerParent = PanelOfEmp.Employeepanel.Parent;
            Employeepanel = PanelOfEmp.Employeepanel;
            this.Controls.Add(PanelOfEmp.Employeepanel);

            this.ShowDialog();
        }

        private void quit_Close_Button1_Button_Click(object sender, EventArgs e)
        {
            Employeepanel.Parent = FormerParent;

            this.Close();
        }
    }
}
