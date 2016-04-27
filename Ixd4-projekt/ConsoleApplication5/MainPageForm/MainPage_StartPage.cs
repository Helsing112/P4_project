﻿using System;
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
            Controls.Add(checkOutButton);

        }
        private void Initialize_Field_Controls_startPage()
        {
            //admin button
            Admin_login_Button(new Point(50, 100), new Size(200, 100));
            //employee controls
            Employee_signedInPanel(new Point(450, 100), new Size(600, 200));
            Check_inButton(new Point(50, 250), new Size(200, 100));
            CheckOutButtonAdd(new Point(50, 400), new Size(200, 100));

            InitilizeSignInOnJobWindow();

            TimerPanel();
        }



        //Field of controls
        SignInPanelControl employee_sign_in_panel;
        Button Admin_login_button;
        CheckInButton CheckIn_Button;
        TimerInfo Timer_panel;
        CheckOutButton checkOutButton;
        private SignInOnJobWindow SignIn;


        #region Draw_startpage methods------------------------------------------------
        private void InitilizeSignInOnJobWindow()
        {
            SignIn = new SignInOnJobWindow(Path_of_Employee_library);
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

        private void CheckoutButtonClick(object sender, EventArgs e)
        {
            // lol
        }

        
        private void EmployesignedInEventClickButton(object sender, EmployeeEventArgs e)
        {
            Draw_tablesPage(e.employee); //draws the next page
        }
        #endregion

    }
}




