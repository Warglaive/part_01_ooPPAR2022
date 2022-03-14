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
            foreach (var user in deserializedObject)
            {
                Console.WriteLine($"Printing properties for user of type: {user.GetType().Name}");
                //PRINT Each object's property
                var properties = user.GetType().GetProperties().ToList();
                foreach (var property in properties)
                {
                    //object obj = property.GetValue(item, null);

                    Console.WriteLine($"Property: {property.Name} Value: {property.GetValue(user)}");
                }
            }
            streamReader.Dispose();
            streamReader.Close();
        }



        public void ShowUserDetailsById(int id)
        {
            //Get last stored user's id, if none -> return 0;
            //use deserializer to make a class from XML
            // Read a particular key from the config file 
            var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.WriteLine("Reading file: " + fileDirectory);

            var serializer = new XmlSerializer(typeof(User));
            var streamReader = new StreamReader(fileDirectory, true);
            List<User> deserializedObject = (List<User>)serializer.Deserialize(streamReader);
            var user = deserializedObject.Where(x => x.Id.Equals(id)).First();

            Console.WriteLine($"{user.FirstName} {user.LastName}");
        }
    }
}
