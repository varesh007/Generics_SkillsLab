using System;
using System.Collections.Generic;

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
            ICustomStack<Jedi> stack = new CustomStack<Jedi>();

            stack.Push(new Jedi(1, "Sparrow"));
            StackExtendedOP.DisplayAllInternsNameAndId(stack);
        }
    }
}