using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    
    public partial class MainPage
    {

        private Employee _employee;
        public Employee ActiveEmployee { get { return _employee; } private set { _employee = value; TablePage.timerInfo1.UpdateEmployeename(ActiveEmployee); } }
        /// <summary>
        /// Clears controls and Draws the page with the table panel
        /// </summary>
        /// <param name="Active_employee">The employee that is active</param>
        //private void Draw_tablesPage(Employee Active_employee)
        //{
        //    Controls.Clear();
        //    ActiveEmployee = Active_employee;

        //    Controls.Add(tables_panel);
        //    Controls.Add(BackToFrontPageButton);
        //}

        //private void Initialize_Field_Controls_tablesPage()
        //{
        //    BackToFrontPage_button(new System.Drawing.Point(12, 245), new System.Drawing.Size(139, 79));
        //    Tables_panel(new Point(200, 20), Size_of_table_panel);
        //}

        //_________________________________________TEST________________________________________
        private void Draw_tablesPage(Employee Active_employee)
        {
            Controls.Clear();
            ActiveEmployee = Active_employee;

            Controls.Add(TablePage);
        }
        private void Initialize_Field_Controls_tablesPage()
        {
            TablePage = new TablesPage();
            TablePage.Size = this.Size;

            TablePage.back_Button1.Button_Click += BackToFrontPage_click;
            TablePage.table_Panel_for_MainPage1.TableClick += OnTableClick;
            TablePage.Button_CombineTables.Button_Click += Button_CombineTables_Button_Click;

            TablePage.Button_OneTimePayment.Button_Click += Button_OneTimePayment_Button_Click;
            TablePage.Button_MoveContent.Button_Click += Button_MoveContent_Button_Click;
            TablePage.Button_MoveTable.Button_Click += ButtonMoveTableOnButtonClick;
        }



        TablesPage TablePage;
        //_________________________________________TESTEND_____________________________________



        #region Eventhandlers-----------------------------

        #region Eventhandler for combine table click.

        private bool _IsCombineTableActive;
        private Control _SelectedCombineTable;
        private bool _aTableIsSelected;
        private Color PrevColorOfText;
        private void Button_CombineTables_Button_Click(object sender, EventArgs e)
        {
            if (_IsCombineTableActive)
            {
                DeactivateCombineTables();
            }
            else
            {
                ActivateCombineTables();
            }
        }

        private void DeactivateCombineTables()
        {
            TablePage.table_Panel_for_MainPage1.TableClick += OnTableClick;
            TablePage.table_Panel_for_MainPage1.TableClick -= CombineTableOntableClick;

            TablePage.Button_CombineTables.label1.ForeColor = PrevColorOfText;

            _IsCombineTableActive = false;
        }

        private void ActivateCombineTables()
        {
            TablePage.table_Panel_for_MainPage1.TableClick -= OnTableClick;
            TablePage.table_Panel_for_MainPage1.TableClick += CombineTableOntableClick;

            PrevColorOfText = TablePage.Button_CombineTables.label1.ForeColor;
            TablePage.Button_CombineTables.label1.ForeColor = Color.Black;

            _IsCombineTableActive = true;
        }


        #region Eventhandlers-----------------------------

        #region Move Tables Methods

        private bool _IsMoveTableActive;
        private Color _buttonMoveTalbePrevColor;

        private void ButtonMoveTableOnButtonClick(object sender, EventArgs eventArgs)
        {
            if (_IsMoveTableActive)
            {
                DeactivateMoveTable();
            }
            else
            {
                ActiveMoveTAble();
            }
        }

        private void ActiveMoveTAble()
        {
            _IsMoveTableActive = true;
            _buttonMoveTalbePrevColor = TablePage.Button_MoveTable.label1.ForeColor;
            TablePage.Button_MoveTable.label1.ForeColor = Color.Black;

            TablePage.table_Panel_for_MainPage1.TableClick -= OnTableClick;
            TablePage.table_Panel_for_MainPage1.OnTableMouseDown += Table_MouseDown;
            TablePage.table_Panel_for_MainPage1.OnTableMouseUp += Table_MouseUp;
            TablePage.table_Panel_for_MainPage1.OnTableMouseMove += Table_MouseMove;
        }

        private void DeactivateMoveTable()
        {
            _IsMoveTableActive = false;
            TablePage.Button_MoveTable.label1.ForeColor = _buttonMoveTalbePrevColor;

            TablePage.table_Panel_for_MainPage1.TableClick += OnTableClick;
            TablePage.table_Panel_for_MainPage1.OnTableMouseDown -= Table_MouseDown;
            TablePage.table_Panel_for_MainPage1.OnTableMouseUp -= Table_MouseUp;
            TablePage.table_Panel_for_MainPage1.OnTableMouseMove -= Table_MouseMove;

        }

        private void CombineTableOntableClick(object sender, EventArgs eventArgs)
        {
            if (_aTableIsSelected && (_SelectedCombineTable != sender))
            {
                Control Temp = (Control)sender;
                //Handle what way the control should enlarge
                if (Math.Abs(_SelectedCombineTable.Location.X - Temp.Location.X) >
                    Math.Abs(_SelectedCombineTable.Location.Y - Temp.Location.Y))
                {
                    _SelectedCombineTable.Width += Temp.Width;
                }
                else
                {
                    _SelectedCombineTable.Height += Temp.Height;
                }
                Temp.Parent = null;
                _aTableIsSelected = false;
            }
            else
            {
                _SelectedCombineTable = (Control)sender;
                _aTableIsSelected = true;
            }
        }

        #endregion
        #region Event handlers for drag & drop and click of table

        private Control _activeControl;
        private Point _previousLocation;
        private void Table_MouseMove(object sender, MouseEventArgs e)
        {
            if (_activeControl == null || _activeControl != sender)
            {
                return;
            }
            Point location = _activeControl.Location;

            location.Offset(e.Location.X - _previousLocation.X, e.Location.Y - _previousLocation.Y);
            _activeControl.Location = location;
        }

        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            _activeControl = null;
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            _activeControl = sender as Control;
            _previousLocation = e.Location;
        }
        #endregion

        #endregion

        #region MoveContent Methods And eventhandlers

        private bool _MoveContentIsActive;
        private Color _moveContentPrevForeColor;
        private Table_Info _MoveContentTable_InfoHolder;
        private bool _IsTableSelected;
        private void Button_MoveContent_Button_Click(object sender, EventArgs e)
        {
            if (_MoveContentIsActive)
            {
                DeactivateMoveContent();
            }
            else
            {
                ActivateContent();
            }
        }

        private void DeactivateMoveContent()
        {
            _MoveContentIsActive = false;

            TablePage.Button_MoveContent.label1.ForeColor = _moveContentPrevForeColor;

            TablePage.table_Panel_for_MainPage1.TableClick += OnTableClick;
            TablePage.table_Panel_for_MainPage1.TableClick -= MoveContentTableClickHandler;

            _MoveContentTable_InfoHolder = null;
            _IsTableSelected = false;

        }

        private void ActivateContent()
        {
            _MoveContentIsActive = true;
            _moveContentPrevForeColor = TablePage.Button_MoveContent.label1.ForeColor;
            TablePage.Button_MoveContent.label1.ForeColor = Color.Black;

            TablePage.table_Panel_for_MainPage1.TableClick -= OnTableClick;
            TablePage.table_Panel_for_MainPage1.TableClick += MoveContentTableClickHandler;


        }

        private void MoveContentTableClickHandler(object sender, EventArgs e)
        {
            Table_Control_MainPage Temp_Table = (Table_Control_MainPage)sender;
            if (_IsTableSelected)
        { 
                if (Temp_Table.TableInfo.TableReceipt.Count == 0)
            {
                    foreach (ReceiptProduct item in _MoveContentTable_InfoHolder.TableReceipt)
                {
                        Temp_Table.TableInfo.AddReceiptProducts(item);
                    }
                    _MoveContentTable_InfoHolder.ClearAllProductsFromReciept();

                    DeactivateMoveContent();
                    Messages.ConfirmMovedTable(Temp_Table.TableInfo);
                }
                else
                {
                    Messages.MoveToTableIsAlreadyOccupedError();
                }

                }
            else
            {
                if (Temp_Table.TableInfo.TableReceipt.Count == 0)
                {
                    Messages.TableHasNoReceiptError();
            }
            else
            {
                    _MoveContentTable_InfoHolder = Temp_Table.TableInfo;
                    _IsTableSelected = true;
                }
            }


        }

        #endregion


        private void Button_OneTimePayment_Button_Click(object sender, EventArgs e)
        {
            Draw_CreateReceipt(ActiveEmployee, new OneTimePaymentTable_info());
        }

        public void BackToFrontPage_click(object sender, EventArgs e)
        {
            Draw_startPage(); //returns to the start page
        }


        private void OnTableClick(object sender, EventArgs e)
        {
            Table_Control_MainPage temp_control = (Table_Control_MainPage)sender;
            Draw_CreateReceipt(ActiveEmployee, temp_control.TableInfo);
           
        }
        #endregion
        #endregion
    }
    
}
