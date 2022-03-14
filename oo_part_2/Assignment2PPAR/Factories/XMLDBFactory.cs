using Assignment2.Entities;
using Assignment2.Interfaces;
using System.Configuration;

namespace Assignment2.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        public XmlDBManager CreateXMLDbManager()
        {
            //use AppConfig 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            return new XmlDBManager(fileDirectory);
        }
    }
}
