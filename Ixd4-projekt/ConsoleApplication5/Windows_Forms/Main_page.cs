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

            TreeViewerControl tree = new TreeViewerControl(500, 500, Path_of_product_library);
            tree.Location = new Point(300,300);
            tree.BorderStyle = BorderStyle.Fixed3D;
            tree.Name = "tree";
            tree.MouseClicked += new EventHandler<ProductEventArgs>(ClickReciever);

            TempReceipt temp_receipt = new TempReceipt(500, 500);
            tree.MouseClicked += new EventHandler<ProductEventArgs>(temp_receipt.Clicked); //subscribe to mouse click
            temp_receipt.Location = new Point(800, 300);
            temp_receipt.BorderStyle = BorderStyle.Fixed3D;
            temp_receipt.Name = "Receipt";

            EmployeeSignInPanel employee_sign_in_panel = new EmployeeSignInPanel();
            employee_sign_in_panel.Location = new System.Drawing.Point(350, 0);
            employee_sign_in_panel.Size = new System.Drawing.Size(600, 200);
            Controls.Add(employee_sign_in_panel);


            Button CheckIn_Button = new Button();
            CheckIn_Button.Location = new System.Drawing.Point(12, 245);
            CheckIn_Button.Name = "CheckInButton";
            CheckIn_Button.Size = new System.Drawing.Size(139, 79);
            CheckIn_Button.TabIndex = 0;
            CheckIn_Button.Text = "CheckIn";
            CheckIn_Button.UseVisualStyleBackColor = true;
            CheckIn_Button.Click += new System.EventHandler(CheckInButton_click);

           
            Controls.Add(temp_receipt);
            Controls.Add(tree); 
            Controls.Add(Admin_login_button);
            Controls.Add(CheckIn_Button);

        }
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

        protected void ClickReciever(object sender, ProductEventArgs e)
        {

        }

       
    }
}
