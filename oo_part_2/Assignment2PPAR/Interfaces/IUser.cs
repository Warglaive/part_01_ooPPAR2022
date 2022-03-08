namespace Assignment2.Interfaces
{
    public interface IUser
    {
        string Type { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

        string Nationality { get; set; }
    }
}
