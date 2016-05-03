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
            this._panelForEmployee = new FlowLayoutPanel();
            this.SuspendLayout();
            EmployeesReader.PasswordCorrect += new EventHandler<EmployeeEventArgs>(OnPasswordCorrect);

            // 
            // Panel_for_employee
            //            
            this._panelForEmployee.Name = "_panelForEmployee";           
            this._panelForEmployee.TabIndex = 0;
            this._panelForEmployee.Size = this.Size;      
            // 
            // EmployeeSignInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._panelForEmployee);
            this.Name = "EmployeeSignInPanel";
            this.ResumeLayout(false);
            this.PerformLayout();              
        }
        
        private void OnPasswordCorrect(object sender, EmployeeEventArgs e)
        {

          
                if (_panelForEmployee.Controls.OfType<EmployeeButton>().ToList().Exists(x => x.employee.EmployeeID == e.employee.EmployeeID))
            {
                Messages.EmployeeAlreadySignedIn();

            }
            else
            {
                EmployeeButton temp = new EmployeeButton(100, 250, e.employee);
                this._panelForEmployee.Controls.Add(temp);
                temp.ClickEvent += new EventHandler<EmployeeEventArgs>(EmployeeSignedInCLickButton);


                Messages.EmployeeConfirmedLogin();
            }

        }

        public event EventHandler<EmployeeEventArgs> EmployeeSignedInClickEvent;


       


        public virtual void EmployeeSignedInCLickButton(object sender, EmployeeEventArgs e)     /*har lavet den public*/
        {
          

         
            {
                if (this.EmployeeSignedInClickEvent != null)
                {
                    EmployeeSignedInClickEvent(sender, new EmployeeEventArgs() { employee = e.employee });
                }
            }
           
        }

        public FlowLayoutPanel _panelForEmployee;
    }
}
