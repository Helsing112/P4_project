using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Printing;
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
            this.Padding = new Padding(0);
            this.Margin = new Padding(0);
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
            //EmployeeButton dynamicButton = new EmployeeButton(100,100, EMP);
            EmployeeSignInButton dynamicButton = new EmployeeSignInButton(EMP) {Textlabel = EMP.EmployeeName};
            dynamicButton.Refresh();
            // Set Button properties
            // Add a Button Click Event handler
            dynamicButton.Button_Click += EmployeeButtonClick;
            dynamicButton.Anchor = AnchorStyles.None;

            // Add Button to the Form. Placement of the Button
            // will be based on the Location and Size of button

            EmployeeHolder.Controls.Add(dynamicButton);
        }

        public void EmployeeButtonClick(object sender, EventArgs e)
        {
            
            EmployeeSignInButton temp = (EmployeeSignInButton)sender;
            employeeinput = temp.employee;
            Controls.Clear();

            Panel FirstBluePanel = new Panel
            {
                BackColor = Color.FromArgb(255, 26, 117, 186),
                Size = new Size(Parent.Width/3, Parent.Height/5),
                Anchor = AnchorStyles.None,
                Margin = new Padding(3)
            };


            Panel SecondBluePanel = new Panel
            {
                BackColor = Color.FromArgb(255, 26, 117, 186),
                Size = new Size(Parent.Width/3, Parent.Height/2),
                Anchor = AnchorStyles.None,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };


            Panel ThirdBluePanel = new Panel
            {
                BackColor = Color.FromArgb(255, 26, 117, 186),
                Size = new Size(Parent.Width/3, Parent.Height/2),
                Anchor = AnchorStyles.None,
                Padding = new Padding(0),
                Margin = new Padding(0)
            };

            // creates the tablelayout panel
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();

            tableLayoutPanel1.ColumnCount = 0;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanel1.Size = new System.Drawing.Size(this.Width, this.Height);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Padding = new Padding(0);

            // end of table layout panel

            //LABEL TIL PASSWORD, DER SKRIVER EMPLOYEE'S NAVN.
            Standard_Label Create_Label = new Standard_Label
            {
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Text = employeeinput.EmployeeName.ToUpper(),
                Name = "label1",
                TabIndex = 1,
                Anchor = AnchorStyles.None,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 30F, FontStyle.Regular)
            };

            Standard_Label passwordLabel = new Standard_Label
            {
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Text = "PASSWORD",
                Name = "label1",
                TabIndex = 1,
                Anchor = AnchorStyles.None,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 30F, FontStyle.Regular)
            };


            FirstBluePanel.Controls.Add(Create_Label);
            SecondBluePanel.Controls.Add(passwordLabel);

            //TEXTBOX DER INDEHOLDER PASSWORD FOR EMPLOYEE
            EmployeeButtonClickTextbox = new TextBox_Touch
            {
                Name = "EmployeeIDtextBox",
                Size = new System.Drawing.Size(ThirdBluePanel.Width, ThirdBluePanel.Height),
                Font = new Font("Segoe UI", 30F, FontStyle.Regular),
                TabIndex = 2,
                textBox1 =
                {
                    Anchor = AnchorStyles.None,
                    Width = ThirdBluePanel.Width - 100,
                    Font = new Font("Segoe UI", 50F, FontStyle.Regular),
                    Location = new Point(50, 0),
                    PasswordChar = '*',
                    TextAlign = HorizontalAlignment.Center
                }
            };

            EmployeeButtonClickTextbox.textBox1.TextChanged += new EventHandler(Log_In_Click);

            ThirdBluePanel.Controls.Add(EmployeeButtonClickTextbox);

            Controls.Add(tableLayoutPanel1);
            tableLayoutPanel1.Controls.Add(FirstBluePanel, 0, 0);
            tableLayoutPanel1.Controls.Add(SecondBluePanel, 0, 1);
            tableLayoutPanel1.Controls.Add(ThirdBluePanel, 0, 2);



        }
        public Quit_Close_Button quit_button; 

        TextBox_Touch EmployeeButtonClickTextbox;

        public void Log_In_Click(object sender, EventArgs e)
        {
            
            if (employeeinput.EmployeePassword == EmployeeButtonClickTextbox.textBox1.Text)
            {
                OnPasswordCorrect(sender, e);     
            }
        }

        public static EventHandler<EmployeeEventArgs> PasswordCorrect;

        protected virtual void OnPasswordCorrect(object sender, EventArgs e)
        {

            if (PasswordCorrect != null)
            {
                PasswordCorrect(this, new EmployeeEventArgs() { employee = employeeinput });

            }

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
            this.EmployeeHolder.Padding = new Padding(5);
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
