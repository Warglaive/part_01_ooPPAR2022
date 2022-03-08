using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Lecturer : User, ILecturer
    {
        public string phoneNumberWork;
        public string lecturerAbbreviation;
        public DateTime dateStarted;

        public string PhoneNumberWork
        {
            get => phoneNumberWork;
            set => phoneNumberWork = value;
        }

        public string LecturerAbbreviation
        {
            get => lecturerAbbreviation;
            set => lecturerAbbreviation = value;
        }
        public DateTime DateStarted
        {
            get => DateStarted;
            set => DateStarted = value;
        }
    }
}
