namespace Generics_SkillsLab
{
    public class Jedi : IInterns
    {
        private int Id;
        public string Name;

        public string NameId => $"Jedi - {Name}: {Id}";
        public int Age { get; set; }

        public Jedi(int id, string name)
        {
            Name = name;
            Id = id;
            System.Console.WriteLine($"Jedi is being created With a name: {Name}!");
        }
    }

    public class SkillsLab : IInterns
    {
        private int Id;
        public string Name;

        public string NameId => $"SkillsLab - {Name}: {Id}";
        public int Age { get; set; }

        public int EmployeeId { get; set; }

        public SkillsLab(int id, string name)
        {
            Name = name;
            Id = id;
            System.Console.WriteLine($"SkillsLab is being created With a name: {Name}!");
        }
    }
}
