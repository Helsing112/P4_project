﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class SignInOnJobWindow : Standard_Window_Layout
    {
        public SignInOnJobWindow(string path)
        {
            this.Padding = new Padding(0);
            InitializeComponent();
            Initializejobpeople(path);
            Path = path;
        
        }
        
        private string Path { get; set; }

        private void Initializejobpeople(string path)
        {
            //this.Controls.Clear();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            this.Padding = new Padding(0);

            int x = this.Width - 50;
            int y = this.Height - 400;
            Point locationOfEmployeeButtons = new Point(25, 200);
            

            employeeControl = new EmployeesReader(x, y ,path ) {Location = locationOfEmployeeButtons} ;
            EmployeesReader.PasswordCorrect += new EventHandler<EmployeeEventArgs>(Close_window);
            Controls.Add(employeeControl);
            

            // Quit button is made for the page, placed in right corner
            quitButton = new Quit_Close_Button {Size = new Size(200, 80)};
            quitButton.Location = new Point(this.Width - (quitButton.Width+30), this.Height - (quitButton.Height+30));
            quitButton.Padding = new Padding(0);
            quitButton.Button_Click += new EventHandler(QuitButtonClick);
            Controls.Add(quitButton);

        }

        private EmployeesReader employeeControl;
        private Quit_Close_Button quitButton;
        private void Close_window(object sender, EmployeeEventArgs e)
        {
            Hide();
            Controls.Clear();
            InitializeComponent();
            Initializejobpeople(Path);

        }

        private void QuitButtonClick(object sender, EventArgs e)
        {
            Hide();
            Controls.Clear();
            InitializeComponent();
            Initializejobpeople(Path);
        }
    }
}
