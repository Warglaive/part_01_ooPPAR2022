using Assignment2.Entities;
using Assignment2.Interfaces;
using System.Configuration;

namespace Assignment2.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        public DBManager CreateXMLDbManager()
        {
            //use AppConfig 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            return new DBManager(fileDirectory);
            //get users.xml loc
        }
    }
}
