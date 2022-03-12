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
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("xmlFileLoc");
            Console.WriteLine("The value of xmlFileLoc: " + fileDirectory);




            var serializer = new XmlSerializer(obj.GetType());
            var streamWriter = new StreamWriter(fileDirectory);
            serializer.Serialize(streamWriter, obj);
            streamWriter.Close();
        }
    }
}
