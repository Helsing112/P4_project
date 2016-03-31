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
    public partial class OnJobWindow : Form
    {
        public OnJobWindow(string path)
        {
            InitializeComponent();
            Initializejobpeople(path);  
        }

        private void Initializejobpeople(string path)
        {
            EmployeesReader EmployeeControl = new EmployeesReader(500, 200, path);
            EmployeeControl.Location = new Point(0, 0  );
            EmployeeControl.BorderStyle = BorderStyle.Fixed3D;

            Controls.Add(EmployeeControl);
        }

        private void OnJobWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
