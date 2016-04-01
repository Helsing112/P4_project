using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ConsoleApplication5
{
    partial class Main_page
    {
        /// <summary>
        /// Clears all controls and adds the nessesary controls for this page
        /// </summary>
        private void Draw_ProductAdderPage(Employee activeEmployee, )
        {
            Controls.Clear();

            Controls.Add(tree);
            Controls.Add(temp_receipt);
        }
        //Initialize all fields
        private void Initialize_Field_Controls_ProductAdderPage()
        {
            initialize_wheel(400);
            Product_tree(new Point(300, 300), new Size(500,500));
            Receipt(new Point(800, 300), new Size(500, 500));
        }
        //Fields controls
        TreeViewerControl tree;
        TempReceipt temp_receipt;
        Timer Timer_for_wheel;
        Timer Timer_for_wheel_controller;
        NumberWheelForm Number_wheel;

        private void initialize_wheel(int Size_of_wheel)
        {
            Number_wheel = new NumberWheelForm(new Rectangle(0, 0, Size_of_wheel, Size_of_wheel));
            Number_wheel.On_Pie_Clicked += Temp_wheel_On_Pie_Clicked;
        }
        private void Product_tree(Point Location_input, Size size_input)
        {
            tree = new TreeViewerControl(size_input.Width, size_input.Height, Path_of_product_library);
            tree.Location = Location_input;
            tree.BorderStyle = BorderStyle.Fixed3D;
            tree.Name = "tree";
            tree.MouseDowned += MouseDownReciever;
            tree.MouseUpped += MouseUpReciever;
        }
        public void Receipt(Point location_input, Size size_input)
        {
            Timer_for_wheel_controller = new Timer();
            Timer_for_wheel_controller.Interval = 100;
            Timer_for_wheel_controller.Tick += Timer_for_wheel_controller_Tick;
            Timer_for_wheel = new Timer();
            Timer_for_wheel.Interval = 50;
            Timer_for_wheel.Tick += Timer_for_wheel_Tick;
            temp_receipt = new TempReceipt(size_input.Width, size_input.Height);
            temp_receipt.Location = location_input;
            temp_receipt.BorderStyle = BorderStyle.Fixed3D;
            temp_receipt.Name = "Receipt";
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
            Number_wheel.Show();
            Number_wheel.TopMost = true;
            Number_wheel.Focus();
            timer_has_ticked = true;
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
