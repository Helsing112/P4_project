using System;
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
        private Rectangle PrimScreen = Screen.PrimaryScreen.Bounds;
        private Table_Info _activeTable;
        public Table_Info ActiveTable { get { return _activeTable; } private set { _activeTable = value; /*Timer_panel.TableNumber = value; Timer_panel.Update2();*/} }
        /// <summary>
        /// Clears all controls and adds the nessesary controls for this page
        /// </summary>
        //private void Draw_CreateReceipt(Employee activeEmployee, Table_Info activeTable)
        //{
        //    this.Padding = new Padding();
        //    Controls.Clear();
        //    //Creates the receipt from table data
        //    ActiveTable = activeTable;
        //    CreateReceipt.tempReceipt1.Table_receiptReciever(ActiveTable.TableReceipt);
        //    //active employee assignment (Property is in another file)
        //    ActiveEmployee = activeEmployee;

        //    //Controls.Add(treeFood);
        //    //Controls.Add(treeDrinks);

        //    Controls.Add(Temp_Receipt);
        //    Controls.Add(PayButton);
        //    Controls.Add(BackToTablesPage); //adds a back button from the tablesPage

        //    Controls.Add(Timer_panel);            
        //}        

        ////Initialize all fields
        //private void Initialize_Field_Controls_CreateReceipt()
        //{
        //    initialize_wheel(400);
        //    PayButtoninitialize(new System.Drawing.Point(12, 700), new System.Drawing.Size(139, 79));
        //    Initialize_Pay_window();
        //    Product_trees(new Point(700, 100), new Size(400,700));
        //    Receipt(new Point(50, 100), new Size(600, 500));
        //    BackToTablesPage_button();
        //}
        private void Initialize_Field_Controls_CreateReceipt()
        {
            CreateReceipt = new TEST();
            CreateReceipt.Location = new Point(0, 0);
            CreateReceipt.ProductView_Foods.MouseUpped += MouseUpReciever;
            CreateReceipt.ProductView_Foods.MouseDowned += MouseDownReciever;
            CreateReceipt.ProductView_Drinks.MouseUpped += MouseUpReciever;
            CreateReceipt.ProductView_Drinks.MouseDowned += MouseDownReciever;

            initialize_wheel(400);

            CreateReceipt.Pay_Button.Button_Click += PayButton_click;
            CreateReceipt.Button_BackToTable.Button_Click += BackToTablesPage_click;

            PayButtoninitialize(new System.Drawing.Point(12, 700), new System.Drawing.Size(139, 79));
            Initialize_Pay_window();
            Product_trees(new Point(700, 100), new Size(400, 700));
            BackToTablesPage_button();

        }
        private void Draw_CreateReceipt(Employee activeEmployee, Table_Info activeTable)
        {
            ActiveEmployee = activeEmployee;
            ActiveTable = activeTable;

            Controls.Clear();
            CreateReceipt.tempReceipt1.Table_receiptReciever(ActiveTable.TableReceipt);
            Controls.Add(CreateReceipt);
            CreateReceipt.Size = Screen.PrimaryScreen.Bounds.Size;
            Console.WriteLine(CreateReceipt.Size);


             
        }
        TEST CreateReceipt;
        //Fields controls
        SuperClassProductViewer treeFood;
        SuperClassProductViewer treeDrinks;
        Timer Timer_for_wheel;
        Timer Timer_for_wheel_controller;
        NumberWheelForm Number_wheel;
        Pay_Button PayButton;
        Pay_windowForm Pay_window;
        Back_Button BackToTablesPage;


        #region Intialize methods-------------------------------------------------------
        public void BackToTablesPage_button()
        {
            BackToTablesPage = new Back_Button();
            BackToTablesPage.Size = new Size(139,79);

            BackToTablesPage.Location = new Point(this.Width - BackToTablesPage.Width, Screen.PrimaryScreen.Bounds.Height - BackToTablesPage.Height);
            BackToTablesPage.Padding = new Padding(10);
            BackToTablesPage.Name = "CheckInButton";
            BackToTablesPage.TabIndex = 0;
            BackToTablesPage.Textlabel = "Back";
            BackToTablesPage.Button_Click += new System.EventHandler(BackToTablesPage_click);
        }

        private void Initialize_Pay_window()
        {
            Pay_window = new Pay_windowForm();
            Pay_window.ProductsPaid += Pay_window_ProductsPaid;
        }

        private void initialize_wheel(int Size_of_wheel)
        {
            Number_wheel = new NumberWheelForm(new Rectangle(0, 0, Size_of_wheel, Size_of_wheel));
            Number_wheel.On_Pie_Clicked += Temp_wheel_On_Pie_Clicked;
            Timer_for_wheel_controller = new Timer();
            Timer_for_wheel_controller.Interval = 100;
            Timer_for_wheel_controller.Tick += Timer_for_wheel_controller_Tick;
            Timer_for_wheel = new Timer();
            Timer_for_wheel.Interval = 50;
            Timer_for_wheel.Tick += Timer_for_wheel_Tick;
        }

        private void Product_trees(Point Location_input, Size size_input)
        {
            treeFood = new SuperClassProductViewer();
            treeFood.Size = size_input;
            treeFood.Location = Location_input;
            treeFood.MouseDowned += MouseDownReciever;
            treeFood.MouseUpped += MouseUpReciever;
            treeFood.initializeFlowOfProducts(Properties.Resources.LocationOfProductLib + Properties.Resources.FoodLibFile);

            treeDrinks = new SuperClassProductViewer();
            treeDrinks.Size = size_input;
            treeDrinks.Location = new Point(Location_input.X + treeDrinks.Width+20, Location_input.Y);
            treeDrinks.MouseDowned += MouseDownReciever;
            treeDrinks.MouseUpped += MouseUpReciever;
            treeDrinks.initializeFlowOfProducts(Properties.Resources.LocationOfProductLib + Properties.Resources.DrinkLibFile);
        }

        private void PayButtoninitialize(Point location_input, Size size_input)
        {
            PayButton = new Pay_Button();
            PayButton.Padding = new Padding(10);

            PayButton.Location = location_input;
            PayButton.Name = "Paybutton";
            PayButton.Size = size_input;
            PayButton.TabIndex = 0;
            PayButton.Textlabel = "Pay";
            PayButton.Button_Click += new System.EventHandler(PayButton_click);
        }
        #endregion

        #region Eventhandlers---------------------------------
        private void BackToTablesPage_click(object sender, EventArgs e)
        {
            CreateReceipt.tempReceipt1.SaveReceiptToTable(ActiveTable);
            ActiveTable = null;
            Draw_tablesPage(ActiveEmployee);
        }

        private void PayButton_click(object sender, EventArgs e)
        {
            CreateReceipt.tempReceipt1.SaveReceiptToTable(ActiveTable); //first we save the receipt to the active table
            Pay_window.Show_Pay_window(ActiveEmployee, ActiveTable);// then we show the pay window with the receipt
        }
        #region EventHandlers for product click and wheel to add to CreateReceipt.tempReceipt1----------------------------------------------------
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
                CreateReceipt.tempReceipt1.Add_products(e.product); //Adds products to receipt
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
            CreateReceipt.tempReceipt1.Add_products(Product_to_add, number);
        }

        private void Timer_for_wheel_controller_Tick(object sender, EventArgs e)
        {
            timer_has_ticked = false;
            Timer_for_wheel_controller.Stop();
        }
        private void Pay_window_ProductsPaid(object sender, PayEventArgs e)
        {
            tables_panel.removeProductsFromTableReceipt(e.ActiveTable.Table_name, e.BoughtProducts);
            CreateReceipt.tempReceipt1.Table_receiptReciever(ActiveTable.TableReceipt);
        }
        #endregion
        #endregion
    }

}


             