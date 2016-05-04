using System;
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

    public partial class EmployeeButton : Std_Button
    {
        public Employee employee { get; set; }

        public EmployeeButton()
        {
            InitializeComponent();
        }
        public EmployeeButton(int size_x, int size_y, Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            this.Button_Click += EmployeeButton_Button_Click;
            label1.Text = employee.EmployeeName;
            this.Textlabel = employee.EmployeeName;
        }

        private void EmployeeButton_Button_Click(object sender, EventArgs e)
        {
            EmployeeButtonClick(sender, e);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pictureBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Size = new System.Drawing.Size(188, 97);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConsoleApplication5.Properties.Resources.knap2;
            this.pictureBox1.Size = new System.Drawing.Size(188, 97);
            // 
            // EmployeeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.Name = "EmployeeButton";
            this.Size = new System.Drawing.Size(188, 97);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pictureBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public EventHandler<EmployeeEventArgs> ClickEvent;

        protected virtual void EmployeeButtonClick(object sender, EventArgs e)
        {
            if (this.ClickEvent != null)
            {
                ClickEvent(this, new EmployeeEventArgs() { employee = employee });
            }
        }

        #endregion

    }
}
