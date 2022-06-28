using Assignment2.Entities;

namespace Assignment2.Interfaces
{
    interface AbstractDBFactory
    {
        DBManager CreateXMLDbManager();
    }
}
