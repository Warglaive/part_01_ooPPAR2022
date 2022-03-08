using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public abstract class User : IUser
    {
        //add fields according to properties
        public string type;
        public string firstName;
        public string lastName;
        public string email;
        /*        //students
                public string studyProgram;
                //students
                public string cohort;
                //students
                public string studentClass;
                //lecturers
                public string phoneNumberWork;*/
        //lecturers
        /*        public string lecturerAbbreviation;
        */
        public string nationality;
        //lecturers
        /*        public DateTime dateStarted;
        */
        public string Type
        {
            //may not work, test it
            get => type; set => type = value;
        }
        public string FirstName
        {
            get => firstName; set => firstName = value;
        }
        public string LastName
        {

            get => lastName; set => lastName = value;
        }
        public string Email
        {
            get => email; set => email = value;
        }
        /* public string StudyProgram
         {
             get => studyProgram; set => studyProgram = value;
         }
         public string Cohort
         {
             get => cohort; set => cohort = value;
         }
         public string StudentClass
         {
             get => studentClass; set => studentClass = value;
         }*/
        /* public string PhoneNumberWork
         {
             get => phoneNumberWork; set => phoneNumberWork = value;
         }
         public string LecturerAbbreviation
         {
             get => lecturerAbbreviation; set => lecturerAbbreviation = value;
         }*/
        public string Nationality
        {
            get => nationality; set => nationality = value;
        }
        /* public DateTime DateStarted
         {
             get => dateStarted; set => dateStarted = value;
         }*/
    }
}
