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
    public partial class Main_page : Standard_Window_Layout
    {

        private string Starting_lib_path;
        private string Path_of_product_library;
        private string Path_of_Employee_library;
        public List<Product> Clicked_products;
        public Size Size_of_table_panel { get; }
        public Main_page(string library_path)
        {
            Size_of_table_panel = new Size(1200, 800); //The size of the table panel, used as parameter for both the manager and the mainpage_panel
            Starting_lib_path = library_path;
            Path_of_product_library = library_path + "\\Product library";
            Path_of_Employee_library = library_path + "\\Product libraryEmployee Library\\";
            InitializeComponent(); // draws the main_page form

            Initialize_Field_Controls();


            Draw_startPage();
            Clicked_products = new List<Product>();
            
        }
        /// <summary>
        /// This method should contain all initializations of field controls that should
        /// </summary>
        private void Initialize_Field_Controls()
        {
            Initialize_Field_Controls_startPage();
            Initialize_Field_Controls_tablesPage();
            Initialize_Field_Controls_CreateReceipt();
        }//declare partial method



    }
}
