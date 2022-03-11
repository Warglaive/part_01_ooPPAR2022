﻿using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Lecturer : User, ILecturer
    {
        private const string dateTimeFormat = "dd-MM-yyyy";

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
            this.lecturerAbbreviation = "mr.";/*AssignLecturerAbbreviation(firstName, lastName);*/
            this.dateStarted = dateStarted;
        }

        private string? AssignLecturerAbbreviation(string firstName, string lastName)
        {
            //TODO
            throw new NotImplementedException();
        }

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
