using System;

namespace Generics_SkillsLab
{
    class StackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(IReadOnlyCustomStack<IInterns> stack)
        {
            while (stack.Count() > 0)
            {
                var item = stack.Pop();
                Console.WriteLine(item.NameId);
            }
        }
    }
}