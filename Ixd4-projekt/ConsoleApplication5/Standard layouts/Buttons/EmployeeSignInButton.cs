﻿using System;
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
    public partial class EmployeeSignInButton : Std_Button
    {
        public Employee employee { get; set; }
        public EmployeeSignInButton(Employee employee)
        {
            
            this.employee = employee;
            InitializeComponent(employee); 

        }
        
    }
}