using Assignment2.Interfaces;
using System.Configuration;
using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public class XmlDBManager : IXmlDBManager
    {
        public void SaveObjectToXML(List<object> Users)
        {
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.WriteLine("All users are saved in: " + fileDirectory);

            //root
            XmlRootAttribute root = new XmlRootAttribute();
            root.ElementName = "Users";
            root.IsNullable = true;
            //namespace
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            //
            var streamWriter = new StreamWriter(fileDirectory, true);

            foreach (var user in Users)
            {
                var serializer = new XmlSerializer(user.GetType());
                serializer.Serialize(streamWriter, user, ns);
            }
            streamWriter.Dispose();
            streamWriter.Close();


        }
        public int ReadLastIdFromXML()
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
