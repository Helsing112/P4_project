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

    public partial class EmployeeButton : UserControl
    {
        public Employee employee { get; set; }

        public EmployeeButton(int size_x, int size_y, Employee employee)
        {
            this.employee = employee;
            InitializeComponent(size_x, size_y, employee);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int size_x, int size_y, Employee employee)
        {
            this.Label_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Text
            // 
            this.Label_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Text.Location = new System.Drawing.Point(0, 0);
            this.Label_Text.Name = "Label_Text";
            this.Label_Text.TabIndex = 0;
            this.Label_Text.Text = employee.EmployeeName;
            this.Label_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Text.Click += new EventHandler(EmployeeButtonClick);
            this.Label_Text.BorderStyle = BorderStyle.Fixed3D;
            // 
            // EmployeeButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Text);
            this.Name = "EmployeeButton";
            this.Size = new System.Drawing.Size(size_x, size_y);
            this.ResumeLayout(false);

        }

        public EventHandler<EmployeeEventArgs> ClickEvent;

        protected virtual void EmployeeButtonClick(object sender, EventArgs e)
        {
            if (this.ClickEvent != null)
            {
                ClickEvent(this, new EmployeeEventArgs() { employee = employee });
            }

        }

        #endregion

        private System.Windows.Forms.Label Label_Text;
    }
}
