using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;



namespace ConsoleApplication5
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            //CategoryNew Other = new CategoryNew() { Name = "Other"};
            //CategoryNew Drinks = new CategoryNew() { Name = "Drinks" };
            //XmlCreateLibrary.Create_File_TEST(Properties.Resources.LocationOfProductLib + Properties.Resources.OtherLibFile, Other);
            //XmlCreateLibrary.Create_File_TEST(Properties.Resources.LocationOfProductLib + Properties.Resources.DrinkLibFile, Drinks);

            Application.Run(new MainPage(@"..\..\..\..\Library"));


        }
    }
}
