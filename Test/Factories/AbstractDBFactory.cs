using Assignment2.Entities;
using Assignment2.Interfaces;
using System.Configuration;

namespace Assignment2.Factories
{
    public abstract class AbstractDBFactory
    {
        public static DBManager CreateDbManager()
        {
            var DBType = ConfigurationManager.AppSettings.Get("DBType");
            if (DBType.Equals("XML"))
            {
                var fileDirectory = ConfigurationManager.AppSettings.Get("XML");
                return new DBManager(fileDirectory);
            }
            else if (true)
            {
                throw new NotSupportedException();
            }
        }
    }
}
