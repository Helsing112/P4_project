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
    public partial class Numpad_button : Std_Button
    {
        public decimal Button_Amount { get; set; }
        public Numpad_button()
        {
            InitializeComponent();
        }
    }
}
