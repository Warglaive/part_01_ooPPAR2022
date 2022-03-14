using Assignment2.Interfaces;
using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public class Student : User, IStudent
    {
        private string? studyProgram;
        private string? cohort;
        private string? studentClass;
        private Student()
        {

        }
        public Student(string firstName, string lastName, string email, string nationality, string studyProgram, string cohort, string studentClass)
            : base(firstName, lastName, email, nationality)
        {
            this.studyProgram = studyProgram;
            this.cohort = cohort;
            this.studentClass = studentClass;
        }

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
