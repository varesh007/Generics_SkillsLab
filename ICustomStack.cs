namespace Generics_SkillsLab
{
    public interface IReadOnlyCustomStack<out T>
    {
        public int Count();

        public T Pop();
    }


    public interface ICustomStack<T> : IReadOnlyCustomStack<T>
    {
        public void Push(T v);
    }
}
