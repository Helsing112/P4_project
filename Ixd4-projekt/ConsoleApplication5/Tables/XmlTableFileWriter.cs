using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace ConsoleApplication5
{
    /// <summary>
    /// Class to create library directories, and genericly add XML files inheirited from List<Table_Button> class.
    /// </summary>
    class XmlTableFileWriter
    {
        #region Writer methods for tables.
        /// <summary>
        /// Creates a XML File and the directory of a table button LIST
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Properties.Settings.Default.Path_of_Table_list_file"></param>
        /// <param name="Content"></param>
        public void Create_File_and_directory<T>(T Content) where T : List<Table_Control_Manager>
        {
            Directory.CreateDirectory(Properties.Settings.Default.Path_of_Table_list_file);
            XmlSerializer serial = new XmlSerializer(typeof(List<Table_button_Xml_data>));
            StreamWriter writer = new StreamWriter(Properties.Settings.Default.Path_of_Table_list_file + Properties.Settings.Default.Table_file_name);

            List<Table_button_Xml_data> button_list = new List<Table_button_Xml_data>();
            foreach (Table_Control_Manager item in Content) //Creating Table button from Table control. To store only relevant data.
            {
                Table_button_Xml_data temp_table = new Table_button_Xml_data();
                temp_table.Table_Text = item.Text;
                temp_table.Size = item.Size;
                temp_table.Location = item.Location;
                button_list.Add(temp_table);
            }

            serial.Serialize(writer, button_list); //Creates the XML file with the List of Table_buttons
            writer.Close();
        }
        public void Create_directory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void Save<T>(T List_of_tables) where T : List<Table_Control_Manager>
        {
            XmlTableFileWriter temp_writer = new XmlTableFileWriter();
            temp_writer.Create_File_and_directory(List_of_tables);
        }
        public static void Save(System.Windows.Forms.Control.ControlCollection input_control) //Overload to recieve a control Container
        {
            List<Table_Control_Manager> list = new List<Table_Control_Manager>();
            foreach (var item in input_control)
            {
                list.Add((Table_Control_Manager)item);
            }
            Save(list);
        }
        #endregion

        #region Writer methods for Table Types.
        public void Create_File_and_directory_table_type<T>(T Content) where T : Table_Button_Type_Xml_data
        {
            string directory = Properties.Settings.Default.Path_of_table_type_lib+"\\";
            Directory.CreateDirectory(directory);
            XmlSerializer serial = new XmlSerializer(typeof(T));
            StreamWriter writer = new StreamWriter(directory+Content.Name+".xml");

            serial.Serialize(writer, Content); 
            writer.Close();
            Messages.TableTypeSaveConfirmation();
        }
        public static void Save_Button_Type(Table_Control_Manager Type_to_save)
        {
            XmlTableFileWriter writer = new XmlTableFileWriter();
            Table_Button_Type_Xml_data Xml_Button = new Table_Button_Type_Xml_data();
            Xml_Button.Name = Type_to_save.Name;
            Xml_Button.Region = Type_to_save.Region;
            Xml_Button.Size = Type_to_save.Size;

            writer.Create_File_and_directory_table_type(Xml_Button);
        }
        #endregion
    }
}
