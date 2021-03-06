﻿using System;
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
    

        public string TextFromComment { get; private set; }

        public Table_Info ActiveTable { get { return _activeTable; } private set { _activeTable = value; CreateReceipt.timerInfo1.UpdateTableName(ActiveTable); } }
 
        private void Initialize_Field_Controls_CreateReceipt()
        {
            CreateReceipt = new CreateReceipt();
            CreateReceipt.Location = new Point(0, 0);

            CreateReceipt.ProductNavigator.MouseUpped += MouseUpReciever;
            CreateReceipt.ProductNavigator.MouseDowned += MouseDownReciever;

            initialize_wheel(400);

            CreateReceipt.Pay_Button.Button_Click += PayButton_click;
            CreateReceipt.Button_PrintBill.Button_Click += Button_PrintBill_Button_Click;
            CreateReceipt.back_Button1.Button_Click += BackToTablesPage_click;
            CreateReceipt.Button_Comment.Button_Click += Button_Comment_CLick;
            CreateReceipt.Button_Done.Button_Click += Button_Done_Button_Click;

            PayButtoninitialize(new System.Drawing.Point(12, 700), new System.Drawing.Size(139, 79));
            Initialize_Pay_window();
            Product_trees(new Point(700, 100), new Size(400, 700));
            BackToTablesPage_button();

        }

        private void Button_Done_Button_Click(object sender, EventArgs e)
        {
            CreateReceipt.tempReceipt1.SaveReceiptToTable(ActiveTable);
            Printer.Print_ToKitchen(ActiveTable, ActiveEmployee, "HP Universal Printing PS");  /*Give name to the printer that prints kitchen info*/        
            if (ActiveTable.TableReceipt.Count != 0)
            {
                Messages.ConfirmSendToKitchen();
            }

            Draw_tablesPage(ActiveEmployee);
        }

        private void Button_Comment_CLick(object sender, EventArgs e)
        {
            CommentToReceiptWindow CommentWindow = new CommentToReceiptWindow(_activeTable.TableComment);
           

            CommentWindow.ShowDialog();
            

            if (CommentWindow.Text == null)
            {
                TextFromComment = null;
            }
            else
            {
                TextFromComment = CommentWindow.Text;
            }

            _activeTable.TableComment = CommentWindow.Text;

        }

        private void Button_PrintBill_Button_Click(object sender, EventArgs e)
        {
            CreateReceipt.tempReceipt1.SaveReceiptToTable(ActiveTable);
            //PrintToKitchen.MethodThatPrints(ActiveTable.Table_name, ActiveEmployee.EmployeeName, ActiveTable.TableReceipt, TextFromComment, "Microsoft XPS Document Writer");  /*Give name to the printer that prints kitchen info*/
        }

        private void Draw_CreateReceipt(Employee activeEmployee, Table_Info activeTable)
        {
            ActiveEmployee = activeEmployee;
            ActiveTable = activeTable;

            Controls.Clear();
            CreateReceipt.tempReceipt1.Table_receiptReciever(ActiveTable.TableReceipt);
            CreateReceipt.Label_TableName.Text = "TABLE: " + ActiveTable.Table_name;
            CreateReceipt.timerInfo1.UpdateTableName(activeTable);
            CreateReceipt.timerInfo1.UpdateEmployeename(activeEmployee);
            Controls.Add(CreateReceipt);
            
        }
        CreateReceipt CreateReceipt;
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
            if (ActiveTable.Table_name == "ONE TIME PAYMENT" && ActiveTable is OneTimePaymentTable_info)
            {
                HandleOneTimePaymentBackClick();
            }
            else
            {
                CreateReceipt.tempReceipt1.SaveReceiptToTable(ActiveTable);
                CreateReceipt.resetProductViewers();
                ActiveTable = null;
                Draw_tablesPage(ActiveEmployee);
            }

        }

        private void HandleOneTimePaymentBackClick()
        {
            CreateReceipt.tempReceipt1.SaveReceiptToTable(ActiveTable);
            if (ActiveTable.TableReceipt.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to exit this one time payment. The receipt will reset.", "",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CreateReceipt.resetProductViewers();
                    ActiveTable = null;
                    Draw_tablesPage(ActiveEmployee);
                }
            }
            else
            {
                CreateReceipt.resetProductViewers();
                ActiveTable = null;
                Draw_tablesPage(ActiveEmployee);
            }
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
            ActiveTable.RemoveProducts(e.BoughtProducts);
            CreateReceipt.tempReceipt1.Table_receiptReciever(ActiveTable.TableReceipt);
        }
        #endregion
        #endregion
    }

}


             