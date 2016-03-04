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
        /// <summary>
        /// Reads a product file from XML. And returns a product instance
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
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
