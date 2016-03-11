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
        private Employee employeeinput { get; set; }
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
            EmployeeButton dynamicButton = new EmployeeButton(100,100, EMP);
            // Set Button properties

            // Add a Button Click Event handler
            dynamicButton.ClickEvent += new EventHandler<EmployeeEventArgs>(EmployeeButtonClick);
            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button
            EmployeeHolder.Controls.Add(dynamicButton);
        }

        public void EmployeeButtonClick(object sender, EmployeeEventArgs e)
        {
            employeeinput = e.employee;
            Controls.Clear();
           
            //LABEL TIL PASSWORD, DER SKRIVER EMPLOYEE'S NAVN.
            Label Create_Label = new Label();
                Create_Label.AutoSize = true;
                Create_Label.Location = new System.Drawing.Point(100, 1);
                Create_Label.Name = "label1";
                Create_Label.Size = new System.Drawing.Size(168, 20);
                Create_Label.TabIndex = 1;
                Create_Label.Text = e.employee.EmployeeName;
                Create_Label.Click += new System.EventHandler(this.Create_Label_Click);

                Controls.Add(Create_Label);

            //TEXTBOX DER INDEHOLDER PASSWORD FOR EMPLOYEE
            EmployeeButtonClickTextbox = new TextBox();
            EmployeeButtonClickTextbox.Location = new System.Drawing.Point(100, 30);
            EmployeeButtonClickTextbox.Name = "EmployeeIDtextBox";
            EmployeeButtonClickTextbox.Size = new System.Drawing.Size(100, 20);
            EmployeeButtonClickTextbox.TabIndex = 2;
            EmployeeButtonClickTextbox.TextChanged += new System.EventHandler(this.EmployeeButtonClickTextbox_TextChanged);

            Controls.Add(EmployeeButtonClickTextbox);


            Button Log_In = new Button();
            Log_In.Location = new System.Drawing.Point(100, 60);
            Log_In.Name = "Log In";
            Log_In.Size = new System.Drawing.Size(105, 49);
            Log_In.TabIndex = 11;
            Log_In.Text = "Log In";
            Log_In.UseVisualStyleBackColor = true;
            Log_In.Click += new System.EventHandler(this.Log_In_Click);

            Controls.Add(Log_In);

           
            //MessageBox.Show(e.employee.EmployeeID + e.employee.EmployeeName);


        }
        TextBox EmployeeButtonClickTextbox;

        public void Log_In_Click(object sender, EventArgs e)
        {

            if (employeeinput.EmployeePassword == EmployeeButtonClickTextbox.Text)
            {
                Controls.Clear();
                MessageBox.Show("Legit Password");
            }
            else {
                MessageBox.Show("Wrong Password");
            }


            
        }

        public void EmployeeButtonClickTextbox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Create_Label_Click(object sender, EventArgs e)
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
