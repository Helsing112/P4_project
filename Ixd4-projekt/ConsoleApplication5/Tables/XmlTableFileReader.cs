using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public class XmlTableFileReader
    {
        /// <summary>
        /// Reads a table file from XML. And returns a List of table_control instances
        /// If no file has been found returns a empty list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Table_Control_Manager> Read_File() 
        {
            List<Table_button> Tables_list = new List<Table_button>();
            
            StreamReader reader;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table_button>));
            List<Table_Control_Manager> Table_button_list = new List<Table_Control_Manager>();

            //; //makes sure that the directory exists
            try { reader = new StreamReader(Properties.Settings.Default.Path_of_Table_list_file + Properties.Settings.Default.Table_file_name);  }
            catch (FileNotFoundException) //If the file is not found, we assume that no table are saved therfore returning a empty list
            {
                return Table_button_list;
            }
            catch (DirectoryNotFoundException)//If the Directory is not found, we assume that no table are saved therefore returning a empty list 
            {
                return Table_button_list;
            }

            Tables_list = (List<Table_button>)serializer.Deserialize(reader);
            reader.Close();

            // make buttons from table list
            foreach (Table_button item in Tables_list)
            {
                Table_Control_Manager temp_but = new Table_Control_Manager();
                temp_but.Text = item.Table_Text;
                temp_but.Size = item.size;
                temp_but.Location = item.Location;
                Table_button_list.Add(temp_but);              
            }

            return Table_button_list;
        }
    }
}
