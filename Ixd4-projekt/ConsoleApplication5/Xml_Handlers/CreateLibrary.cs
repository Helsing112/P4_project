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
    /// Class to create library directories, and genericly add XML files inheirited from "product" class.
    /// </summary>
    class CreateLibrary
    {
        /// <summary>
        /// Creates a file XML format from a generic class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Path"></param>
        /// <param name="Content"></param>
        public void Create_File<T>(string Path, T Content) where T : Product
        {
            XmlSerializer serial = new XmlSerializer(typeof(T));
            StreamWriter writer = new StreamWriter(Path + "\\" + Content.Name);
            serial.Serialize(writer, Content);
            writer.Close();
        }

        public void Create_Category(string Path)
        {
            Directory.CreateDirectory(Path);

        }





    }
}
