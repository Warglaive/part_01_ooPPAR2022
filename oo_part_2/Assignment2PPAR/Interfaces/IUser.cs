﻿namespace Assignment2.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }

        string Nationality { get; set; }
    }
}
