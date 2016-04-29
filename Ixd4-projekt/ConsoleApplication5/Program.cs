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
           

            Application.Run(new MainPage());


        }
    }
}
