namespace Assignment2.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string? message) : base(message)
        {
        }
    }
}
