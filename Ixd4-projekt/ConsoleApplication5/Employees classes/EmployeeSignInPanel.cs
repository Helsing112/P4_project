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
    public partial class EmployeeSignInPanel : UserControl
    {
        public EmployeeSignInPanel()
        {
            InitializeComponent();
        }
 

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_for_employee = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            EmployeesReader.PasswordCorrect += new EventHandler<EmployeeEventArgs>(OnPasswordCorrect);

            // 
            // Panel_for_employee
            // 
            this.Panel_for_employee.AutoSize = true;
            this.Panel_for_employee.Dock = System.Windows.Forms.DockStyle.Fill;
           
            this.Panel_for_employee.Name = "Panel_for_employee";
           
            this.Panel_for_employee.TabIndex = 0;
            this.Panel_for_employee.BorderStyle = BorderStyle.Fixed3D;
            // 
            // EmployeeSignInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_for_employee);
            this.Name = "EmployeeSignInPanel";
            this.ResumeLayout(false);
            this.PerformLayout();
              
        }
        
        private void OnPasswordCorrect(object sender, EmployeeEventArgs e)
        {
            EmployeeButton temp = new EmployeeButton(100, 100, e.employee);
            this.Panel_for_employee.Controls.Add(temp);
            temp.ClickEvent += new EventHandler<EmployeeEventArgs>(EmployeeSignedInCLickButton);
        }

        public EventHandler<EmployeeEventArgs> EmployeeSignedInClickEvent;
        protected virtual void EmployeeSignedInCLickButton(object sender, EmployeeEventArgs e)
        {
            if (this.EmployeeSignedInClickEvent != null)
            {
                EmployeeSignedInClickEvent(this, new EmployeeEventArgs() { employee = e.employee });
            }

        }

       

        private System.Windows.Forms.FlowLayoutPanel Panel_for_employee;
    }
}
