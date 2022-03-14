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
        public void ExitApplication()
        {
            Console.WriteLine("See ya!");
            Environment.Exit(0);
        }

        public void SaveObjectToXML(List<User> Users)
        {
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
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
        public void ShowUsersOverview()
        {
            //Get last stored user's id, if none -> return 0;
            //use deserializer to make a class from XML
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.WriteLine("Reading file... : " + fileDirectory);

            var serializer = new XmlSerializer(typeof(List<User>));
            var streamReader = new StreamReader(fileDirectory, true);
            List<User> deserializedObject = (List<User>)serializer.Deserialize(streamReader);
            foreach (var item in deserializedObject)
            {
                //PRINT Each object's property
                var properties = item.GetType().GetProperties().ToList();
                foreach (var property in properties)
                {
                    //object obj = property.GetValue(item, null);

                    Console.WriteLine($"Property: {property.Name} Value: {property.GetValue(item)}");
                }
            }
            streamReader.Close();
        }



        public User ShowUserDetailsById(int id)
        {
            /* //Get last stored user's id, if none -> return 0;
             //use deserializer to make a class from XML
             // Read a particular key from the config file 
             var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
             Console.WriteLine("Reading file: " + fileDirectory);

             var serializer = new XmlSerializer(typeof(User));
             var streamReader = new StreamReader(fileDirectory, true);
             var deserializedObject = serializer.Deserialize(streamReader);
             streamReader.Close();
             return 0;*/
            return null;
        }


    }
}
