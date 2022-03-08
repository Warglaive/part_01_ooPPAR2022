using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Lecturer : User, ILecturer
    {
        private string phoneNumberWork;
        private string lecturerAbbreviation;
        private DateTime dateStarted;

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
