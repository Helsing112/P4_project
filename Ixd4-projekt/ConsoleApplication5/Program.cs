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
            
            //Admin_Menu menu = new Admin_Menu();
            //menu.Start();

            Console.WriteLine("Hejsa bøsser");

            Console.WriteLine("");

            XmlProductReader reader = new XmlProductReader();

            reader.Read_product<Product>(@"..\..\..\..\Library\Burger\Big_burger");
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Admin_visual(@"..\..\..\..\Library"));

            //CreateLibrary creator = new CreateLibrary();

            //Product lille_cola = new Product();
            //lille_cola.Name = "Lille Cola";

            //Product stor_cola = new Product();
            //stor_cola.Name = "stor cola";



            //Product Cola = new Product();
            //Cola.Name = "Over_cola";
            //Cola.Add_to_Varrianter_list("Lille cola", 10);
            //Cola.Add_to_Varrianter_list("stor Cola", 20);

            //creator.Create_File<Product>(@"C:\Users\User\OneDrive\I-D\project\ixd\Library", Cola);


            Console.ReadKey();




        }
    }
}
