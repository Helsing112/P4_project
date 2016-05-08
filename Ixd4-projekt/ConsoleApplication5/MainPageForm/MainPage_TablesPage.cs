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

        private void CombineTableOntableClick(object sender, EventArgs eventArgs)
        {
            if (_aTableIsSelected && (_SelectedCombineTable != sender))
            {
                Control Temp = (Control) sender;
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
                _SelectedCombineTable = (Control) sender;
                _aTableIsSelected = true;
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
    }
    
}
