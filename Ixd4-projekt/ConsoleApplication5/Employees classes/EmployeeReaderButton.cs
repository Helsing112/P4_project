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
    public partial class EmployeeReaderButton : UserControl
    {
        private Employee Employee_input { get; set; }
        public EmployeeReaderButton(int size_x, int size_y, Employee employee)
        {
            Employee_input = employee;
            InitializeComponent(size_x, size_y, employee);

        }

        private void EmployeeNameLabel_Click(object sender, EventArgs e)
        {
            OnMouseClicked(Employee_input);
            
        }

        private void InitializeComponent(int size_x, int size_y, Employee employee)
        {
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(0, 0);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Insert Name";
            this.EmployeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmployeeNameLabel.Click += new EventHandler(this.EmployeeNameLabel_Click);
            // 
            // EmployeeReaderButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeNameLabel);
            this.Name = "EmployeeReaderButton";
            this.ResumeLayout(false);
            this.Width = size_x;
            this.Height = size_y;
        }

        public EventHandler<EmployeeEventArgs> Clicked;

        protected virtual void OnMouseClicked(Employee employee)
        {
            if (Clicked != null)
            {
                Clicked(this, new EmployeeEventArgs() { employee = employee });
            
            }


        }

       

    }
}
