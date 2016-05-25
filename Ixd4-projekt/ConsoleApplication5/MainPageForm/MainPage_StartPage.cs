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


        #endregion

        #region Eventhandlers-----------------------------------------------------
        private void Admin_login_click(object sender, EventArgs e)
        {
            Admin_function_window admin_window = new Admin_function_window(Path_of_product_library, Size_of_table_panel);
            admin_window.AdminControl.quit_Close_Button2.Button_Click += Quit_Program_Button_Click;
            admin_window.AdminControl.UpdateButton.Button_Click += UpdateButton_Button_Click; 
            admin_window.ShowDialog();
         
        }

        private void UpdateButton_Button_Click(object sender, EventArgs e)
        {
            Initialize_Field_Controls_CreateReceipt();
            Initialize_Field_Controls_tablesPage();
        }

        private void Quit_Program_Button_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to close the program? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();

            }
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




