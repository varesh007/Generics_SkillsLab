using System;

namespace Generics_SkillsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            StackString();
            Console.ReadLine();
        }

        private static void StackString()
        {
            var stack = new CustomStack<Jedi>();
            stack.Push(new Jedi(1, "Sparrow"));

            StackExtendedOP.DisplayAllInternsNameAndId(stack);
        }
    }
}
