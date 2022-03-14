using Assignment2.Entities;

namespace Assignment2.Interfaces
{
    public interface IXmlDBManager
    {
        void SaveObjectToXML(List<User> Users);
        void ShowUserDetailsById(int id);
        void ShowUsersOverview();
        void ExitApplication();
    }
}
