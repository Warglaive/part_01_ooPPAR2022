﻿using Assignment2.Entities;

namespace Assignment2.Interfaces
{
    public interface IXmlDBManager
    {
        void SaveObjectToXML(List<User> Users);
        User GetUserById(int id);
    }
}
