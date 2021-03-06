using Assignment2.Entities;

namespace Assignment2.Interfaces
{
    public interface IDBManager
    {
        IDBManager GetDBManager();
        void SaveUsers(List<User> Users);
        void ShowUserDetailsById(int id);
        void ShowUsersOverview();
        void ExitApplication();
    }
}
