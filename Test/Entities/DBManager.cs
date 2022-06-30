﻿using Assignment2.Interfaces;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public class DBManager : IDBManager
    {
        private string? fileDirectory;
        private Command command;
        public DBManager(string? fileDirectory)
        {
            this.fileDirectory = fileDirectory;
            this.command = new Command();
        }

        public void ExitApplication()
        {
            this.command.printMessageAction("See ya!");
            Environment.Exit(0);
        }

        public void SaveUsers(List<User> Users)
        {
            // Read a particular key from the config file 
            //var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            this.command.printMessageAction("All users are saved in: " + fileDirectory);

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
            this.command.printMessageAction("Reading file... : " + fileDirectory);

            var serializer = new XmlSerializer(typeof(List<User>));
            var streamReader = new StreamReader(fileDirectory, true);
            List<User> deserializedObject = (List<User>)serializer.Deserialize(streamReader);
            foreach (var user in deserializedObject)
            {
                this.command.printMessageAction($"Printing properties for user of type: {user.GetType().Name}");
                //PRINT Each object's property
                var properties = user.GetType().GetProperties().ToList();
                foreach (var property in properties)
                {
                    if (property.Name == "Id" || property.Name == "FirstName" || property.Name == "LastName")
                    {
                        this.command.printMessageAction($"Property: {property.Name} Value: {property.GetValue(user)}");

                    }
                }
            }
            streamReader.Dispose();
            streamReader.Close();
        }

        public void ShowUserDetailsById(int id)
        {
            //var fileDirectory = ConfigurationManager.AppSettings.Get("XmlDB");
            this.command.printMessageAction("Reading file... : " + fileDirectory);

            var serializer = new XmlSerializer(typeof(List<User>));
            var streamReader = new StreamReader(fileDirectory, true);
            List<User> deserializedObject = (List<User>)serializer.Deserialize(streamReader);
            foreach (var user in deserializedObject.Where(x => x.Id.Equals(id)))
            {
                this.command.printMessageAction($"Printing properties for user of type: {user.GetType().Name}");
                //PRINT Each object's property
                var properties = user.GetType().GetProperties().ToList();
                foreach (var property in properties)
                {
                    this.command.printMessageAction($"Property: {property.Name} Value: {property.GetValue(user)}");
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
