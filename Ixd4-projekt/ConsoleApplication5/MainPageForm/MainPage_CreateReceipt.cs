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
        private Table_Info _activeTable;
        public Table_Info ActiveTable { get { return _activeTable; } private set { _activeTable = value; Timer_panel.UpdateTableName(ActiveTable); } }
        /// <summary>
        /// Clears all controls and adds the nessesary controls for this page
        /// </summary>
        private void Draw_CreateReceipt(Employee activeEmployee, Table_Info activeTable)
        {
            Controls.Clear();
            //Creates the receipt from table data
            ActiveTable = activeTable;
            Temp_Receipt.Table_receiptReciever(ActiveTable.TableReceipt);
            //active employee assignment (Property is in another file)
            ActiveEmployee = activeEmployee;

            Controls.Add(tree);
            Controls.Add(Temp_Receipt);
            Controls.Add(PayButton);
            Controls.Add(BackToFrontPageButton); //adds a back button from the tablesPage

            Controls.Add(Timer_panel);            
        }        
        //Initialize all fields
        private void Initialize_Field_Controls_CreateReceipt()
        {
            initialize_wheel(400);
            PayButtoninitialize(new System.Drawing.Point(12, 345), new System.Drawing.Size(139, 79));
            Initialize_Pay_window();
            Product_tree(new Point(300, 300), new Size(500,500));
            Receipt(new Point(800, 300), new Size(500, 500));
        }
        //Fields controls
        TreeViewerControl tree;
        TempReceipt Temp_Receipt;
        Timer Timer_for_wheel;
        Timer Timer_for_wheel_controller;
        NumberWheelForm Number_wheel;
        Button PayButton;
        Pay_windowForm Pay_window;


        #region Intialize methods
        private void Initialize_Pay_window()
        {
            Pay_window = new Pay_windowForm();
        }

      

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
        private void Receipt(Point location_input, Size size_input)
        {
            Timer_for_wheel_controller = new Timer();
            Timer_for_wheel_controller.Interval = 100;
            Timer_for_wheel_controller.Tick += Timer_for_wheel_controller_Tick;
            Timer_for_wheel = new Timer();
            Timer_for_wheel.Interval = 50;
            Timer_for_wheel.Tick += Timer_for_wheel_Tick;
            Temp_Receipt = new TempReceipt(size_input.Width, size_input.Height);
            Temp_Receipt.Location = location_input;
            Temp_Receipt.BorderStyle = BorderStyle.Fixed3D;
            Temp_Receipt.Name = "Receipt";
        }
        private void PayButtoninitialize(Point location_input, Size size_input)
        {
            PayButton = new Button();
            PayButton.Location = location_input;
            PayButton.Name = "Paybutton";
            PayButton.Size = size_input;
            PayButton.TabIndex = 0;
            PayButton.Text = "Pay";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += new System.EventHandler(PayButton_click);
        }



        #endregion
        #region Eventhandlers---------------------------------
        private void PayButton_click(object sender, EventArgs e)
        {

            Temp_Receipt.SaveReceiptToTableInfo(ActiveTable); //first we save the receipt to the active table
            Pay_window.Show_Pay_window(new ReceiptCompleteInfo(ActiveTable, ActiveEmployee));// then we show the pay window with the receipt

        }
        #region EventHandlers for product click and wheel to add to temp_receipt----------------------------------------------------
        private bool timer_has_ticked = false;
        private Product Product_to_add;
        private Point WheelSpawnPointForMouseDown;

        protected void MouseDownReciever(object sender, ProductEventArgs e)
        {
            WheelSpawnPointForMouseDown = (new Point(MousePosition.X - Number_wheel.Width / 2, MousePosition.Y - Number_wheel.Height / 2));
            Timer_for_wheel.Start();
            Product_to_add = e.product;
        }
        private void MouseUpReciever(object sender, ProductEventArgs e)
        {
            if (!timer_has_ticked)
            {
                Timer_for_wheel.Stop();
                Temp_Receipt.Add_products(e.product); //Adds products to receipt
            }

        }
        private void Timer_for_wheel_Tick(object sender, EventArgs e)
        {
            Timer_for_wheel.Stop();
            Number_wheel.Show_NumberWheel(WheelSpawnPointForMouseDown);

            timer_has_ticked = true;
            Timer_for_wheel_controller.Start();
        }

        private void Temp_wheel_On_Pie_Clicked(int number)
        {
            Temp_Receipt.Add_products(Product_to_add, number);
        }

        private void Timer_for_wheel_controller_Tick(object sender, EventArgs e)
        {
            timer_has_ticked = false;
            Timer_for_wheel_controller.Stop();
        }

        #endregion
        #endregion
    }

}


             