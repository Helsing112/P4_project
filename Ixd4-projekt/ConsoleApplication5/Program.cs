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
            Admin_Menu menu = new Admin_Menu();
            menu.Start();

            Console.WriteLine("Hejsa bøsser");

            Console.WriteLine("");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Admin_visual(@"C:\Users\User\OneDrive\I-D\project\ixd\Library"));
        }
    }
}
