using System;
using System.IO;

namespace Standard.Utils
{
    public class XmlUtilities
    {
        public T DeserializeXmlDocument<T>(string xmlFilePath)
        {
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (var fs = new FileStream(xmlFilePath, FileMode.Open))
            using (var reader = new StreamReader(fs))
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
        }
    }
}
