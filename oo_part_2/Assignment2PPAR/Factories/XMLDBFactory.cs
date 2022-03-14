using Assignment2.Entities;
using Assignment2.Interfaces;
using System.Xml;

namespace Assignment2.Factories
{
    public class XMLDBFactory : AbstractDBFactory
    {
        public XMLDBFactory()
        {
        }

        public XmlDBManager CreateXMLDbManager()
        {
            return new XmlDBManager();
        }

        void CreateInitialXML()
        {
            var a = new XmlDocument();
        }
    }
}
