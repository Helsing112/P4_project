using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ConsoleApplication5
{
    public partial class Main_page : Form
    {

        private string Starting_lib_path;
        private string Path_of_product_library;
        private string Path_of_Employee_library;
        public List<Product> Clicked_products;
        public Main_page(string library_path)
        {
            Starting_lib_path = library_path;
            Path_of_product_library = library_path + "\\Product library";
            Path_of_Employee_library = library_path + "\\Product libraryEmployee Library\\";
            InitializeComponent();

            Admin_login();

            Clicked_products = new List<Product>();
        }

        private void Admin_login()
        {
            Controls.Clear();

            Button Admin_login_button = new Button();
            Admin_login_button.Location = new System.Drawing.Point(12, 12);
            Admin_login_button.Name = "Admin_login_button";
            Admin_login_button.Size = new System.Drawing.Size(139, 79);
            Admin_login_button.TabIndex = 0;
            Admin_login_button.Text = "Admin";
            Admin_login_button.UseVisualStyleBackColor = true;
            Admin_login_button.Click += new System.EventHandler(Admin_login_click);

            Tree = new TreeViewerControl(500, 500, Path_of_product_library);
            Tree.Location = new Point(300, 300);
            Tree.BorderStyle = BorderStyle.Fixed3D;
            Tree.Name = "tree";
            Tree.MouseDowned += MouseDownReciever;
            Tree.MouseUpped += MouseUpReciever;


            Timer_for_wheel_controller = new Timer();
            Timer_for_wheel_controller.Interval = 100;
            Timer_for_wheel_controller.Tick += Timer_for_wheel_controller_Tick;
            Timer_for_wheel = new Timer();
            Timer_for_wheel.Interval = 500;
            Timer_for_wheel.Tick += Timer_for_wheel_Tick;
            temp_receipt = new TempReceipt(500, 500);
            temp_receipt.Location = new Point(800, 300);
            temp_receipt.BorderStyle = BorderStyle.Fixed3D;
            temp_receipt.Name = "Receipt";


            Button CheckIn_Button = new Button();
            CheckIn_Button.Location = new System.Drawing.Point(12, 245);
            CheckIn_Button.Name = "CheckInButton";
            CheckIn_Button.Size = new System.Drawing.Size(139, 79);
            CheckIn_Button.TabIndex = 0;
            CheckIn_Button.Text = "CheckIn";
            CheckIn_Button.UseVisualStyleBackColor = true;
            CheckIn_Button.Click += new System.EventHandler(CheckInButton_click);

            Controls.Add(temp_receipt);
            Controls.Add(Tree);
            Controls.Add(Admin_login_button);
            Controls.Add(CheckIn_Button);

        }

        TreeViewerControl Tree;
        TempReceipt temp_receipt;
        Timer Timer_for_wheel;
        Timer Timer_for_wheel_controller;

        private void Admin_login_click(object sender, EventArgs e)
        {
            Admin_function_window admin_window = new Admin_function_window(Path_of_product_library);
            admin_window.Show();
        }


        private void CheckInButton_click(object sender, EventArgs e)
        {
            SignInOnJobWindow SignIn = new SignInOnJobWindow(Path_of_Employee_library);
            SignIn.Show();
        }

        #region EventHandlers for product click and wheel to add to temp_receipt----------------------------------------------------
        private bool timer_has_ticked = false;
        private Product Product_to_add;

        protected void MouseDownReciever(object sender, ProductEventArgs e)
        {
            Timer_for_wheel.Start();
            Product_to_add = e.product;
        }
        private void MouseUpReciever(object sender, ProductEventArgs e)
        {
            if (!timer_has_ticked)
            {
                Timer_for_wheel.Stop();
                temp_receipt.Add_products(e.product);
            }

        }
        private void Timer_for_wheel_Tick(object sender, EventArgs e)
        {
            Timer_for_wheel.Stop();
            timer_has_ticked = true;
            int Size_of_wheel = 400;
            NumberWheelForm temp_wheel = new NumberWheelForm(new Rectangle(0, 0, Size_of_wheel, Size_of_wheel));
            temp_wheel.On_Pie_Clicked += Temp_wheel_On_Pie_Clicked;
            Timer_for_wheel_controller.Start();
        }

        private void Temp_wheel_On_Pie_Clicked(int number)
        {
            temp_receipt.Add_products(Product_to_add, number);
        }

        private void Timer_for_wheel_controller_Tick(object sender, EventArgs e)
        {
            timer_has_ticked = false;
            Timer_for_wheel_controller.Stop();
        }

        #endregion


    }
}
