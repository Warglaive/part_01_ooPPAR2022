using Assignment2.Entities;
using System.Configuration;

namespace Test.Factories
{
    public class XMLDBFactory
    {
        private const string XMLDbType = "XML";
        public XMLDBFactory()
        {

        }
        public DBManager GetXMLDBManager()
        {
            var fileDirectory = ConfigurationManager.AppSettings.Get(XMLDbType);
            return new DBManager(fileDirectory);
        }
    }
}
