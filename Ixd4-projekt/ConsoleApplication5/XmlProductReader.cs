using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication5
{
    public class XmlProductReader
    {
        public XmlProductReader()
        {
        }

        public T Read_product<T>(string path) where T : Product
        {
            T TT;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader reader = new StreamReader(path);

            TT = (T)serializer.Deserialize(reader);
            reader.Close();

            return TT; 
        }
    }
}
