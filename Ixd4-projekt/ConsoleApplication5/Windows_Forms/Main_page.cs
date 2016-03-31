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
            Table_Panel();
           
            employe_sign_inPanel();
            Check_inButton();
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

            Controls.Add(Admin_login_button);
        }
        public void Products_and_receipt()
        {
            //tree
            tree = new TreeViewerControl(500, 500, Path_of_product_library);
            tree.Location = new Point(300, 300);
            tree.BorderStyle = BorderStyle.Fixed3D;
            tree.Name = "tree";
            tree.MouseDowned += MouseDownReciever;
            tree.MouseUpped += MouseUpReciever;

            Controls.Add(tree);
            //temp receipt
            Timer_for_wheel_controller = new Timer();
            Timer_for_wheel_controller.Interval = 100;
            Timer_for_wheel_controller.Tick += Timer_for_wheel_controller_Tick;
            Timer_for_wheel = new Timer();
            Timer_for_wheel.Interval = 50;
            Timer_for_wheel.Tick += Timer_for_wheel_Tick;
            temp_receipt = new TempReceipt(400, 400); /*Har ændret størrelsen så jeg kan se total*/
            temp_receipt.Location = new Point(800, 300);
            temp_receipt.BorderStyle = BorderStyle.Fixed3D;
            temp_receipt.Name = "Receipt";          
            Controls.Add(temp_receipt);
        }

            public void employe_sign_inPanel() {

            EmployeeSignInPanel employee_sign_in_panel = new EmployeeSignInPanel();
            employee_sign_in_panel.EmployeeSignedInClickEvent += new EventHandler<EmployeeEventArgs>(EmployesignedInEventClickButton);
            employee_sign_in_panel.Location = new System.Drawing.Point(350, 0);
            employee_sign_in_panel.Size = new System.Drawing.Size(600, 200);

            Controls.Add(employee_sign_in_panel);
        }

        public void Table_Panel()
        {
            TablesOnFrontpage Tables_On_Frontpage = new TablesOnFrontpage();
            Tables_On_Frontpage.Location = new System.Drawing.Point(350, 200);
            Tables_On_Frontpage.Size = new System.Drawing.Size(600, 200);

            Controls.Add(Tables_On_Frontpage);
        }


        public void Check_inButton()
        {
            Button CheckIn_Button = new Button();
            CheckIn_Button.Location = new System.Drawing.Point(12, 245);
            CheckIn_Button.Name = "CheckInButton";
            CheckIn_Button.Size = new System.Drawing.Size(139, 79);
            CheckIn_Button.TabIndex = 0;
            CheckIn_Button.Text = "CheckIn";
            CheckIn_Button.UseVisualStyleBackColor = true;
            CheckIn_Button.Click += new System.EventHandler(CheckInButton_click);

            Controls.Add(CheckIn_Button);
        }
        public void CheckInButton_click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SignInOnJobWindow>().Count() == 1)
                Application.OpenForms.OfType<SignInOnJobWindow>().First().BringToFront();

            else {

                SignInOnJobWindow SignIn = new SignInOnJobWindow(Path_of_Employee_library);
                SignIn.ShowDialog();
                SignIn.TopMost = true;
            }
        }
        private void EmployesignedInEventClickButton(object sender, EmployeeEventArgs e)
        {
            this.Controls.Clear();
            Products_and_receipt();

            Label Create_Label = new Label();
            Create_Label.AutoSize = true;
            Create_Label.Location = new System.Drawing.Point(0, 0);
            Create_Label.Name = "label1";
            Create_Label.Size = new System.Drawing.Size(168, 200);
            Create_Label.TabIndex = 1;
            Create_Label.Text = e.employee.EmployeeName;
            Create_Label.Font = new Font(Create_Label.Font.FontFamily, 100);
            

            Controls.Add(Create_Label);
            BackToFrontPage();
            PayButton();
        }
        public void BackToFrontPage()
        {
            Button BackToFrontPage = new Button();
            BackToFrontPage.Location = new System.Drawing.Point(12, 245);
            BackToFrontPage.Name = "CheckInButton";
            BackToFrontPage.Size = new System.Drawing.Size(139, 79);
            BackToFrontPage.TabIndex = 0;
            BackToFrontPage.Text = "CheckOut";
            BackToFrontPage.UseVisualStyleBackColor = true;
            BackToFrontPage.Click += new System.EventHandler(BackToFrontPage_click);

            Controls.Add(BackToFrontPage);
        } 

        public void BackToFrontPage_click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR 404, zhit aint working");
            //Controls.Clear();
            //lel(library_path);

        }
        public void PayButton()
        {
            Button PayButton = new Button();
            PayButton.Location = new System.Drawing.Point(12, 345);
            PayButton.Name = "Paybutton";
            PayButton.Size = new System.Drawing.Size(139, 79);
            PayButton.TabIndex = 0;
            PayButton.Text = "PayDatZhitUp";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += new System.EventHandler(PayButton_click);


            Controls.Add(PayButton);
        }

        //Paywindow Pay_window = null;

        public void PayButton_click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<Paywindow>().Count() == 1)
            {
                Application.OpenForms.OfType<Paywindow>().First().BringToFront();
            }
            else
            {
                List<ProductWithAmount> ListOfContent = temp_receipt.GetReceiptContent();
                Paywindow Pay_window = new Paywindow(ListOfContent);
                Pay_window.ShowDialog();
                Pay_window.TopMost = true;
            }       
        }    
     
        TreeViewerControl tree;
        TempReceipt temp_receipt;
        Timer Timer_for_wheel;
        Timer Timer_for_wheel_controller;

        private void Admin_login_click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Admin_function_window>().Count() == 1)
            {
                Application.OpenForms.OfType<Admin_function_window>().First().BringToFront();
            }
            else {

                Admin_function_window admin_window = new Admin_function_window(Path_of_product_library);
                admin_window.ShowDialog();
                admin_window.TopMost = true;
            }
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
