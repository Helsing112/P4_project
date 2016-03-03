using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication5
{
    class CreateLibrary
    {
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
