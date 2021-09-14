namespace Generics_SkillsLab
{
    public class CustomStack<T>
    {
        private T[] items;
        private int internalIndex = -1;

        public CustomStack() => items = new T[10];

        public int Count() => internalIndex + 1;

        public void Push(T v) => items[++internalIndex] = v;

        public T Pop() => items[internalIndex--];
    }
}
