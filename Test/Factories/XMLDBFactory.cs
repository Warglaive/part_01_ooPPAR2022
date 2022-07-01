using Assignment2.Factories;
using Assignment2.Interfaces;
using System.Configuration;
using Test.Persistence;

namespace Test.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        private const string XMLDbType = "XML";
        public XMLDBFactory()
        {

        }

        public override IDBManager GetDBManager()
        {
            var fileDirectory = ConfigurationManager.AppSettings.Get(XMLDbType);
            return new DBManager(fileDirectory);
        }
    }
}
