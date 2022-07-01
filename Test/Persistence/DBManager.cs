using Assignment2.Entities;
using Assignment2.Interfaces;
using System.Xml;
using System.Xml.Serialization;

namespace Test.Persistence
{
    public class DBManager : IDBManager
    {
        private string? fileDirectory;
        private Command command;
        public DBManager(string? fileDirectory)
        {
            this.fileDirectory = fileDirectory;
            command = new Command();
        }

        public void ExitApplication()
        {
            command.PrintLineOnConsole("See ya!");
            Environment.Exit(0);
        }

        public void SaveUsers(List<User> Users)
        {
            // Read a particular key from the config file 
            //var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            command.PrintLineOnConsole("All users are saved in: " + fileDirectory);

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
            //var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            command.PrintLineOnConsole("Reading file... : " + fileDirectory);

            var serializer = new XmlSerializer(typeof(List<User>));
            var streamReader = new StreamReader(fileDirectory, true);
            List<User> deserializedObject = (List<User>)serializer.Deserialize(streamReader);
            foreach (var user in deserializedObject)
            {
                command.PrintLineOnConsole($"Printing properties for user of type: {user.GetType().Name}");
                //PRINT Each object's property
                var properties = user.GetType().GetProperties().ToList();
                foreach (var property in properties)
                {
                    if (property.Name == "Id" || property.Name == "FirstName" || property.Name == "LastName")
                    {
                        command.PrintLineOnConsole($"Property: {property.Name} Value: {property.GetValue(user)}");

                    }
                }
            }
            streamReader.Dispose();
            streamReader.Close();
        }

        public void ShowUserDetailsById(int id)
        {
            //var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            command.PrintLineOnConsole("Reading file... : " + fileDirectory);

            var serializer = new XmlSerializer(typeof(List<User>));
            var streamReader = new StreamReader(fileDirectory, true);
            List<User> deserializedObject = (List<User>)serializer.Deserialize(streamReader);
            foreach (var user in deserializedObject.Where(x => x.Id.Equals(id)))
            {
                command.PrintLineOnConsole($"Printing properties for user of type: {user.GetType().Name}");
                //PRINT Each object's property
                var properties = user.GetType().GetProperties().ToList();
                foreach (var property in properties)
                {
                    command.PrintLineOnConsole($"Property: {property.Name} Value: {property.GetValue(user)}");
                }
            }
            streamReader.Dispose();
            streamReader.Close();
        }

        public IDBManager GetDBManager()
        {
            return this;
        }
    }
}
