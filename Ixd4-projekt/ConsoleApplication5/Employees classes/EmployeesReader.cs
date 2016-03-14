using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ConsoleApplication5
{
    public partial class EmployeesReader : UserControl
    {
        public EmployeesReader(int size_x, int size_y, string path)
        {
            InitializeComponent(size_x, size_y);
            FillEmployeeHodler(path);
        }

        private void FillEmployeeHodler(string path)
        {
            DirectoryInfo Employer = new DirectoryInfo(path);
               foreach (var item in Employer.GetFiles())
            {
                Employee Waiter =  XmlEmployeeReader.Read_Employee<Employee>(item.FullName);
                CreateEmployeeButton(Waiter);
            }
         

        }

        private void CreateEmployeeButton(Employee EMP)
        {
            // Create a Button object 
            Button dynamicButton = new Button();
            // Set Button properties
            dynamicButton.Height = 100;
            dynamicButton.Width = 100;
            dynamicButton.Text = EMP.EmployeeName;
            dynamicButton.Name = EMP.EmployeeName;
            // Add a Button Click Event handler
            dynamicButton.Click += new EventHandler(EmployeeButtonClick);
            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            EmployeeHolder.Controls.Add(dynamicButton);
        }

        private void EmployeeButtonClick(object sender, EventArgs e)
        {
            
        }





        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(int size_x, int size_y)
        {
            this.EmployeeHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // EmployeeHolder
            // 
            this.EmployeeHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeHolder.Location = new System.Drawing.Point(0, 0);
            this.EmployeeHolder.Name = "EmployeeHolder";
            this.EmployeeHolder.Width = size_x;
            this.EmployeeHolder.Height = size_y;
            this.EmployeeHolder.TabIndex = 0;
            // 
            // EmployeesReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeHolder);
            this.Width = size_x;
            this.Height = size_y;
            this.Name = "EmployeesReader";
            this.ResumeLayout(false);

        }

    }

}
