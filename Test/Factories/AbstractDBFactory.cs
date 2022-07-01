using Assignment2.Interfaces;
using System.Configuration;
using Test.Factories;
using Test.Persistence;

namespace Assignment2.Factories
{
    public abstract class AbstractDBFactory
    {
        /// <summary>
        ///  Fields so we do not use hardcoded values
        /// </summary>
        private const string DBGetType = "DBType";
        private const string XMLDbType = "XML";

        public static DBManager CreateDbManager()
        {
            var DBType = ConfigurationManager.AppSettings.Get(DBGetType);
            if (DBType.Equals(XMLDbType))
            {
                //return XML factory
                var xmlDBFactory = new XMLDBFactory();
                return (DBManager)xmlDBFactory.GetDBManager();
            }

            //Another DB Type
            else if (true)
            {
                throw new NotSupportedException();
            }
        }
        public abstract IDBManager GetDBManager();
    }
}
