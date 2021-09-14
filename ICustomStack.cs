namespace Generics_SkillsLab
{
    public interface ICustomStack<T>
    {
        public int Count();

        public void Push(T v);

        public T Pop();
    }
}
