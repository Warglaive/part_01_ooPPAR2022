using Assignment2.Entities;
using Assignment2.Interfaces;

namespace Assignment2.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        public XmlDBManager CreateXMLDbManager()
        {
            return new XmlDBManager();
        }
    }
}
