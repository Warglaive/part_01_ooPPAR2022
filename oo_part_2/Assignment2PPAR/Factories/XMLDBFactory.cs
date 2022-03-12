using Assignment2.Interfaces;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml.Serialization;

namespace Assignment2.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        public void SaveObjectToXML(object? obj)
        {
            string sAttr;
            // Read a particular key from the config file 
            sAttr = ConfigurationManager.AppSettings.Get("xmlFileLoc");
            Console.WriteLine("The value of xmlFileLoc: " + sAttr);




            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            TextWriter streamWriter = new StreamWriter(sAttr);
            serializer.Serialize(streamWriter, obj);
            streamWriter.Close();
        }
    }
}
