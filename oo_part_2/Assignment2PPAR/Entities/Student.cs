using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Student : User, IUser, IStudent
    {
        //students
        public string studyProgram;
        //students
        public string cohort;
        //students
        public string studentClass;

        public string StudyProgram
        {
            get => studyProgram;
            set => studyProgram = value;
        }
        public string Cohort
        {
            get => cohort;
            set => cohort = value;
        }
        public string StudentClass
        {
            get => studentClass;
            set => studentClass = value;
        }
    }
}
