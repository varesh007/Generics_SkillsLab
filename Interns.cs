namespace Generics_SkillsLab
{
    public class Jedi : IInterns
    {
        private int Id;
        private string Name;
        public string NameId => $"Jedi - {Name}: {Id}";

        public Jedi(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }

    public class SkillsLab : IInterns
    {
        private int Id;
        private string Name;
        public string NameId => $"SkillsLab - {Name}: {Id}";

        public SkillsLab(int id, string name)
        {
            Name = name;
            Id = id;
        }
    }
}
