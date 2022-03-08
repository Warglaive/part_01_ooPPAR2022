using Assignment2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Entities
{
    public abstract class User : IUser
    {
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string StudyProgram { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cohort { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Class { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumberWork { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LecturerAbbreviation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nationality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateStarted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
