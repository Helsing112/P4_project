using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplication5
{
    public partial class Main_page
    {
        /// <summary>
        /// Clears all controls and Draws the starting page of the main window 
        /// </summary>
        private void Draw_startPage()
        {
            Controls.Clear(); // clears any existing controls

            //Adds the start page controls
            Controls.Add(employee_sign_in_panel);
            Controls.Add(Admin_login_button);
            Controls.Add(CheckIn_Button);
            Controls.Add(Timer_panel);
            Controls.Add(Check_Out_button);


        }
        private void Initialize_Field_Controls_startPage()
        {
            //admin button
            Admin_login_Button(new System.Drawing.Point(12, 100), new System.Drawing.Size(139, 79));
            Check_Out_Button(new System.Drawing.Point(12, 300), new System.Drawing.Size(139, 79));
            //employee controls
            Employee_signedInPanel(new System.Drawing.Point(350, 100), new System.Drawing.Size(600, 200));
            Check_inButton(new System.Drawing.Point(12, 245), new System.Drawing.Size(139, 79));
            TimerPanel();
        }
        //Field of controls
        EmployeeSignInPanel employee_sign_in_panel;
        Button Admin_login_button;
        Button CheckIn_Button;
        TimerInfo Timer_panel;
        Button Check_Out_button;

        #region Draw_startpage methods------------------------------------------------
        public void Employee_signedInPanel(Point location_input, Size size_input)
        {
            employee_sign_in_panel = new EmployeeSignInPanel();
            employee_sign_in_panel.EmployeeSignedInClickEvent += new EventHandler<EmployeeEventArgs>(EmployesignedInEventClickButton);
            employee_sign_in_panel.Location = location_input;
            employee_sign_in_panel.Size = size_input;

            Controls.Add(employee_sign_in_panel);
          
        }
    
        public void TimerPanel()
        {
         Timer_panel = new TimerInfo();
         Timer_panel.Location = new System.Drawing.Point(1100, 0);
            Timer_panel.BorderStyle = BorderStyle.Fixed3D;
            Timer_panel.Size = new System.Drawing.Size(250, 100);
            Controls.Add(Timer_panel);

        }

        private void Admin_login_Button(Point location_input, Size size_input)
        {
            Admin_login_button = new Button();
            Admin_login_button.Location = location_input;
            Admin_login_button.Name = "Admin_login_button";
            Admin_login_button.Size = size_input;
            Admin_login_button.TabIndex = 0;
            Admin_login_button.Text = "Admin";
            Admin_login_button.UseVisualStyleBackColor = true;
            Admin_login_button.Click += new System.EventHandler(Admin_login_click);

            Controls.Add(Admin_login_button);
        }

        private void Check_Out_Button(Point location_input, Size size_input)
        {
            Check_Out_button = new Button();
            Check_Out_button.Location = location_input;
            Check_Out_button.Name = "Check_Out_button";
            Check_Out_button.Size = size_input;
            Check_Out_button.TabIndex = 0;
            Check_Out_button.Text = "Check out";
            Check_Out_button.UseVisualStyleBackColor = true;
            Check_Out_button.Click += new System.EventHandler(Check_Out_Button_click);

            Controls.Add(Check_Out_button);
        }

        public bool CheckOutGlobal = false;
        public void Check_Out_Button_click(object sender, EventArgs e)
        {
            CheckOutGlobal = true;                                              /*sender en bool afsted, og hvis bool er true når der trykkes på employee i panel bliver employeeipanel slettet*/
            EmployeeButton.MethodForCheckOut(CheckOutGlobal);

        }

        public void Check_inButton(Point location_input, Size size_input)
        {
          
            CheckIn_Button = new Button();
            CheckIn_Button.Location = location_input;
            CheckIn_Button.Name = "CheckInButton";
            CheckIn_Button.Size = size_input;
            CheckIn_Button.TabIndex = 0;
            CheckIn_Button.Text = "CheckIn";
            CheckIn_Button.UseVisualStyleBackColor = true;
            CheckIn_Button.Click += new System.EventHandler(CheckInButton_click);

            Controls.Add(CheckIn_Button);
        }
        #endregion

        #region Eventhandlers-----------------------------------------------------
        private void Admin_login_click(object sender, EventArgs e)
        {
            CheckOutGlobal = false;
            EmployeeButton.MethodForCheckOut(CheckOutGlobal);


            Admin_function_window admin_window = new Admin_function_window(Path_of_product_library, Size_of_table_panel);
            admin_window.ShowDialog();
        }
        private void CheckInButton_click(object sender, EventArgs e)
        {
            CheckOutGlobal = false;
            EmployeeButton.MethodForCheckOut(CheckOutGlobal);

            //try
            //{
                SignInOnJobWindow SignIn = new SignInOnJobWindow(Path_of_Employee_library);
                SignIn.ShowDialog();
            //}
            //catch (AccessViolationException)
            //{

            //    MessageBox.Show("det var ikke heldigt");
            //}
           

            

            
            
        }
        private void EmployesignedInEventClickButton(object sender, EmployeeEventArgs e)
        {

        
                Draw_tablesPage(e.employee);
            
        }
        #endregion

    }
}




