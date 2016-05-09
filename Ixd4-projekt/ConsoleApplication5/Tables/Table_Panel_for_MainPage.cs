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
    public class Table_Panel_for_MainPage : UserControl
    {
        /// <summary>
        /// Panel of all the tables. Reads from designated xml files
        /// </summary>
        /// <param name="size_of_panel">Size of the panel</param>
        public Table_Panel_for_MainPage()
        {
            InitializeComponent();
            Initialize_AllTables();
        }
        private void Initialize_AllTables()
        {
            List<Table_Control_MainPage> tablesList = XmlTableFileReader.Read_Tables_for_MainPage();
            foreach (Table_Control_MainPage item in tablesList)
            {
                this.Controls.Add(item);
                
                item.Click += TableClicked;
                item.MouseDown += Table_MouseDown;
                item.MouseUp += Table_MouseUp;
                item.MouseMove += Table_MouseMove;
            }
        }

        public event EventHandler<MouseEventArgs> OnTableMouseUp;
        public event EventHandler<MouseEventArgs> OnTableMouseDown;
        public event EventHandler<MouseEventArgs> OnTableMouseMove;

        private void Table_MouseMove(object sender, MouseEventArgs e)
        {
            OnTableMouseMove?.Invoke(sender, e);
        }

        private void Table_MouseUp(object sender, MouseEventArgs e)
        {
            OnTableMouseUp?.Invoke(sender, e);
        }

        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            OnTableMouseDown?.Invoke(sender, e);
        }

        public void removeProductsFromTableReceipt(string NameOfTable, List<ReceiptProduct> ProductsToRemove)
        {
            try
            {
                this.Controls.OfType<Table_Control_MainPage>().First(x => x.TableInfo.Table_name == NameOfTable).removeProducts(ProductsToRemove);

            }
            catch (InvalidOperationException) { }
        }
        public event EventHandler TableClick;
        private void TableClicked(object sender, EventArgs e)
        {
            if (TableClick != null)
            {
                TableClick(sender, e);
            }
        }

        
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Size = new Size(1200, 800);
            try
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.Path_of_resturant_plan);
            }
            catch (Exception)
            { //We dont want to crash the system, just because our picture is not there
            }
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        #endregion
        #region generated code
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
#endregion

    }
}
