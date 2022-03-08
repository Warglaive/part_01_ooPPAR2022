using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Student : User, IStudent
    {
        public string studyProgram;
        public string cohort;
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
