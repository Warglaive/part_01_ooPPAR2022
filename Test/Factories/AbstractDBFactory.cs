using Assignment2.Entities;
using System.Configuration;

namespace Assignment2.Factories
{
    public abstract class AbstractDBFactory
    {
        /// <summary>
        ///  Fields so we do not use hardcoded values
        /// </summary>
        private const string XMLDbType = "XML";
        private const string DBGetType = "DBType";
        public static DBManager CreateDbManager()
        {
            var DBType = ConfigurationManager.AppSettings.Get(DBGetType);
            if (DBType.Equals("XML"))
            {
                var fileDirectory = ConfigurationManager.AppSettings.Get(XMLDbType);
                return new DBManager(fileDirectory);
            }
            else if (true)
            {
                throw new NotSupportedException();
            }
        }
    }
}
