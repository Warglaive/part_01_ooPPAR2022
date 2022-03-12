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
            Console.WriteLine("All users are saved in: " + fileDirectory);

            var serializer = new XmlSerializer(obj.GetType());
            var streamWriter = new StreamWriter(fileDirectory, true);
            // serializer.
            serializer.Serialize(streamWriter, obj);
            streamWriter.Close();
        }
    }
}
