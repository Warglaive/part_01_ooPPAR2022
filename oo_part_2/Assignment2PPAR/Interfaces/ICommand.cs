namespace Assignment2.Interfaces
{
    public interface ICommand<T>
    {

        public delegate void Action<E>(E obj);
    }
}
