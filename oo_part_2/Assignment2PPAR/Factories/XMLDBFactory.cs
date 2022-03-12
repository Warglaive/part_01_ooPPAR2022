using Assignment2.Interfaces;
using System.Xml.Serialization;

namespace Assignment2.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        public void SaveObjectToXML(object? obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            TextWriter streamWriter = new StreamWriter(@"D:\part_01_oo-Warglaive\oo_part_2\Assignment2PPAR\Storage\Users.xml");
            serializer.Serialize(streamWriter, obj);
            streamWriter.Close();
        }
    }
}
