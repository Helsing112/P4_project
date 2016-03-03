using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication5
{
    /// <summary>
    /// Console menu class.
    /// </summary>
    class Admin_Menu
    {
        
        private const ConsoleColor HeadlineColor = ConsoleColor.Cyan;
        private const ConsoleColor ItemColor = ConsoleColor.Black;
        private const ConsoleColor SelectedItemColor = ConsoleColor.Magenta;
        
        Boolean run = false;
        private int selected_item = 0;
        public void Start()
        {
            run = true;
            string path = @"..\..\..\..\Library";
            do
            {
                Console.Clear();
                Print_menu(path);
                GatherInput(ref path);
            } while (run);
        }

        private void Print_menu(string path)
        {
            Console.WriteLine("ADMIN Menu");
            int i=0;

            DirectoryInfo mapper = new DirectoryInfo(path);
            foreach (var item in mapper.GetDirectories())
            {
                if (i == selected_item)
                {
                    Console.BackgroundColor = SelectedItemColor;
                    Console.WriteLine(item);
                    Console.BackgroundColor = ItemColor;
                }
                else
                {
                    Console.WriteLine(item);
                }
                i++;
            }
        }


        private void GatherInput(ref string path)
        {

            ConsoleKeyInfo input = Console.ReadKey();
            DirectoryInfo mapper = new DirectoryInfo(path);
            DirectoryInfo[] sub_mapper = mapper.GetDirectories();
            int amount_sub_directory = sub_mapper.Count();

            switch (input.Key)
            {
                case ConsoleKey.Backspace: //falltrough
                case ConsoleKey.Escape:
                    run = false;
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp(amount_sub_directory);
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown(amount_sub_directory);
                    break;
                case ConsoleKey.Enter:
                    path = sub_mapper[selected_item].FullName;
                    break;
                default:
                    break;
            }
        }
        
        private void MoveUp(int max_amount)
        {
            selected_item = (selected_item - 1) % max_amount;
        }

        private void MoveDown(int max_amount)
        {
            selected_item = (selected_item + 1) % max_amount;
        }
    }

}