using Assignment2.Interfaces;
using Microsoft.VisualBasic;
using System.Xml.Serialization;

namespace Assignment2.Entities
{
    public class Lecturer : User, ILecturer
    {
        private const string dateFormat = "dd-MM-yyyy";

        private string? phoneNumberWork;
        //calculated value
        private string? lecturerAbbreviation;
        private string? dateStarted;



        private Lecturer()
        {

        }


        public Lecturer(string firstName, string lastName, string email, string nationality, string phoneNumberWork, string dateStarted)
            : base(firstName, lastName, email, nationality)
        {
            this.phoneNumberWork = phoneNumberWork;
            this.lecturerAbbreviation = AssignLecturerAbbreviation(firstName, lastName);
            this.dateStarted = dateStarted;
        }


        private string? AssignLecturerAbbreviation(string firstName, string lastName)
        {
            var result = "Mr. " + firstName[0] + " " + lastName[0];
            return result;
        }
        [XmlElement(ElementName = "BusinessPhoneNumber")]
        public string PhoneNumberWork
        {
            get => phoneNumberWork;
            set => phoneNumberWork = value;
        }

        [XmlElement(ElementName = "Abbreviation")]
        public string LecturerAbbreviation
        {
            get => lecturerAbbreviation;
            set => lecturerAbbreviation = value;
        }
        [XmlElement(ElementName = "StartDate")]
        public string DateStarted
        {
            get
            {
                return dateStarted;
            }
            set
            {
                dateStarted = value;
            }
        }
    }
}
