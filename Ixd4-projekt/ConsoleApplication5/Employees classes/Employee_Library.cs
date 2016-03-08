using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication5
{
    public class Employee_Library
    {          
            public void Create_File_And_directory<T>(string Path, T Content) where T : Employee
            {
                 Directory.CreateDirectory(Path);
                 XmlSerializer serial = new XmlSerializer(typeof(T));
                StreamWriter writer = new StreamWriter(Path + "\\" + Content.EmployeeName);
                serial.Serialize(writer, Content);
                writer.Close();
            }

        }
    }

