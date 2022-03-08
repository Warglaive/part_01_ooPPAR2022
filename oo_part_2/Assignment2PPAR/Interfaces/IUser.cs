namespace Assignment2.Interfaces
{
    public interface IUser
    {
        string Type { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        //students only
        string StudyProgram { get; set; }
        string Cohort { get; set; }
        string Class { get; set; }

        //lecturers
        string PhoneNumberWork { get; set; }
        //lecturers
        string LecturerAbbreviation { get; set; }

        string Nationality { get; set; }
        //lecturers
        DateTime DateStarted { get; set; }
    }
}
