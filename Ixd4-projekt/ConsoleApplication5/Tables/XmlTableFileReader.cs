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
        public static List<Table_Control_MainPage> Read_Tables_for_MainPage()
        {
            List<Table_button_Xml_data> Tables_list = new List<Table_button_Xml_data>();

            StreamReader reader;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table_button_Xml_data>));
            List<Table_Control_MainPage> Table_button_list = new List<Table_Control_MainPage>();

            //makes sure that the directory exists
            try { reader = new StreamReader(Properties.Settings.Default.Path_of_Table_list_file + Properties.Settings.Default.Table_file_name); }
            catch (FileNotFoundException) //If the file is not found, we assume that no table are saved therfore returning a empty list
            {
                return Table_button_list;
            }
            catch (DirectoryNotFoundException)//If the Directory is not found, we assume that no table are saved therefore returning a empty list 
            {
                return Table_button_list;
            }

            Tables_list = (List<Table_button_Xml_data>)serializer.Deserialize(reader);
            reader.Close();

            // make buttons from table list
            foreach (Table_button_Xml_data item in Tables_list)
            {
                Table_Control_MainPage temp_but = new Table_Control_MainPage(item.Table_Text);
                temp_but.Size = item.Size;
                temp_but.Location = item.Location;
                Table_button_list.Add(temp_but);
            }

            return Table_button_list;
        }

        /// <summary>
        /// Reads a table file from XML. And returns a List of table_control instances
        /// If no file has been found returns a empty list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<Table_Control_Manager> Read_File_For_Manager() 
        {
            List<Table_button_Xml_data> Tables_list = new List<Table_button_Xml_data>();
            
            StreamReader reader;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Table_button_Xml_data>));
            List<Table_Control_Manager> Table_button_list = new List<Table_Control_Manager>();

            //makes sure that the directory exists
            try { reader = new StreamReader(Properties.Settings.Default.Path_of_Table_list_file + Properties.Settings.Default.Table_file_name);  }
            catch (FileNotFoundException) //If the file is not found, we assume that no table are saved therfore returning a empty list
            {
                return Table_button_list;
            }
            catch (DirectoryNotFoundException)//If the Directory is not found, we assume that no table are saved therefore returning a empty list 
            {
                return Table_button_list;
            }

            Tables_list = (List<Table_button_Xml_data>)serializer.Deserialize(reader);
            reader.Close();

            // make buttons from table list
            foreach (Table_button_Xml_data item in Tables_list)
            {
                Table_Control_Manager temp_but = new Table_Control_Manager();
                temp_but.Text = item.Table_Text;
                temp_but.Size = item.Size;
                temp_but.Location = item.Location;
                Table_button_list.Add(temp_but);              
            }

            return Table_button_list;
        }
        /// <summary>
        /// Reads XML files for the Table Types
        /// </summary>
        /// <returns>Returns a List of controls representing the types</returns>
        public static List<Table_Control_Manager> Read_TableType_files()
        {
            List<Table_Control_Manager> List = new List<Table_Control_Manager>();

            XmlSerializer serializer = new XmlSerializer(typeof(Table_Button_Type_Xml_data));
            StreamReader reader;

            //try { reader = new StreamReader(Properties.Settings.Default.Path_of_table_type_lib); }
            //catch (DirectoryNotFoundException)//If the Directory is not found, we assume that no table types are saved therefore returning a empty list 
            //{
            //    return List;
            //}
            DirectoryInfo Directory = new DirectoryInfo(Properties.Settings.Default.Path_of_table_type_lib);
            int foreachruns = 0;
            foreach (var item in Directory.GetFiles("*.xml")) //foreach file in the directory ending with .xml
            {
                try { reader = new StreamReader(item.FullName); }
                catch (FileNotFoundException) //If the file is not found, we assume that no table are saved therfore returning a empty list
                {
                    return List;
                }

                Table_Button_Type_Xml_data temp_xmlData = (Table_Button_Type_Xml_data)serializer.Deserialize(reader);//reading file and creating a Table_control_manager from the data.
                Table_Control_Manager temp_control = new Table_Control_Manager();
                temp_control.Name = temp_xmlData.Name;
                temp_control.Region = temp_xmlData.Region;
                temp_control.Size = temp_xmlData.Size;
                List.Add(temp_control);
                reader.Close();
                foreachruns++;
            }
            return List;
        }
    }
}
