using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplication5
{
    partial class MainPage
    {

        private void Draw_startPage()
        {
            Controls.Clear();
            Controls.Add(startPage);
        }

        private void Initialize_Field_Controls_startPage()
        {
            startPage = new StartPage();
            InitilizeSignInOnJobWindow();
            startPage.Size = this.Size;
            startPage.checkInButton1.Button_Click += CheckInButton_click;
            startPage.checkOutButton1.Button_Click += CheckoutButtonClick;
            startPage.adminStartButton1.Button_Click += Admin_login_click;
            startPage.employeeSignInPanel1.EmployeeSignedInClickEvent += EmployesignedInEventClickButton;
            
            InitilizeSignOutOnJobWindow();
            TimerPanel();
        }
        StartPage startPage;



        //Field of controls
        SignInPanelControl employee_sign_in_panel;
        Button Admin_login_button;
        CheckInButton CheckIn_Button;
        TimerInfo Timer_panel;
        CheckOutButton checkOutButton;
        private SignInOnJobWindow SignIn;
        private SignOutOnJobWindow SignOut;


        #region Draw_startpage methods------------------------------------------------
        private void InitilizeSignInOnJobWindow()
        {
            SignIn = new SignInOnJobWindow(Path_of_Employee_library);
            
        }

        private void InitilizeSignOutOnJobWindow()
        {
            SignOut = new SignOutOnJobWindow();
        }

        
        public void Employee_signedInPanel(Point location_input, Size size_input)
        {
            employee_sign_in_panel = new SignInPanelControl();
            employee_sign_in_panel.Employeepanel.EmployeeSignedInClickEvent += new EventHandler<EmployeeEventArgs>(EmployesignedInEventClickButton);
            employee_sign_in_panel.Location = location_input;
            employee_sign_in_panel.Size = size_input;

            Controls.Add(employee_sign_in_panel);

        }

        public void CheckOutButtonAdd(Point location, Size size)
        {
            checkOutButton = new CheckOutButton
            {
                Location = location,
                Size = size
            };
            checkOutButton.Button_Click += new System.EventHandler(CheckoutButtonClick);

        }
    
        public void TimerPanel()
        {
            Timer_panel = new TimerInfo
            {
                Location = new Point(1100, 0),
                BorderStyle = BorderStyle.Fixed3D,
                Size = new Size(250, 100),
                Dock = DockStyle.Top,
            };
            Controls.Add(Timer_panel);

        }

        private void Admin_login_Button(Point location_input, Size size_input)
        {
            Admin_login_button = new Button
            {
                Location = location_input,
                Name = "Admin_login_button",
                Size = size_input,
                TabIndex = 0,
                Text = "Admin",
                UseVisualStyleBackColor = true
            };
            Admin_login_button.Click += new System.EventHandler(Admin_login_click);

            Controls.Add(Admin_login_button);
        }
        public void Check_inButton(Point location_input, Size size_input)
        {

            CheckIn_Button = new CheckInButton
            {
                Location = location_input,
                Name = "CheckInButton",
                Size = size_input,
                TabIndex = 0,
            };
            CheckIn_Button.Button_Click += new System.EventHandler(CheckInButton_click);

            Controls.Add(CheckIn_Button);
        }
        #endregion

        #region Eventhandlers-----------------------------------------------------
        private void Admin_login_click(object sender, EventArgs e)
        {
            Admin_function_window admin_window = new Admin_function_window(Path_of_product_library, Size_of_table_panel);
            admin_window.ShowDialog();
        }
        private void CheckInButton_click(object sender, EventArgs e)
        {
            
            SignIn.ShowDialog();
            //EmployeeLoginTest test = new EmployeeLoginTest(Path_of_Employee_library);
            //test.ShowDialog();
        }




        public void CheckoutButtonClick(object sender, EventArgs e)
        {
            SignOut.show_window(startPage.employeeSignInPanel1);
        }

        
        private void EmployesignedInEventClickButton(object sender, EmployeeEventArgs e)
        {

            Control temp = (Control)sender;
            if(temp.Parent.Parent.Parent.Parent is MainPage)
            {
            Draw_tablesPage(e.employee); //draws the next page
            }
            if(temp.Parent.Parent.Parent is SignOutOnJobWindow)
            {
               if (MessageBox.Show($"Are you sure you want to check {e.employee.EmployeeName} out?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                    temp.Dispose();

                }
            }


        }
        #endregion

    }
}




