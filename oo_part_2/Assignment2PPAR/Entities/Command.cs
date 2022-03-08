using Assignment2.Interfaces;

namespace Assignment2.Entities
{
    public class Command<T> : ICommand<T>
    {
        //Description property
        public delegate void Action<E>(E obj);
    }
}
