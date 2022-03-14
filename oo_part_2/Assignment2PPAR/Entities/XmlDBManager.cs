using Assignment2.Interfaces;
using System.Configuration;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public class XmlDBManager : IXmlDBManager
    {
        public void SaveObjectToXML(List<User> Users)
        {
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.WriteLine("All users are saved in: " + fileDirectory);

            //root
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Users";
            root.IsNullable = true;
            //namespace
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] {
              XmlQualifiedName.Empty});


            var serializer = new XmlSerializer(typeof(List<User>));
            using (TextWriter writer = new StreamWriter(fileDirectory))
            {
                serializer.Serialize(writer, Users);
            }
        }

        public User GetUserById(int id)
        {
            //Get last stored user's id, if none -> return 0;
            //use deserializer to make a class from XML
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.WriteLine("Reading file: " + fileDirectory);

            var serializer = new XmlSerializer(typeof(User));
            var streamReader = new StreamReader(fileDirectory, true);
            var deserializedObject = serializer.Deserialize(streamReader);
            streamReader.Close();
            return 0;
        }
    }
}
