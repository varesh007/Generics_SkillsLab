using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_SkillsLab
{
    public class Jedi
    {
        private int Id;
        private string Name;
        public string NameId => $"{Name}: {Id}";

        public Jedi(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
