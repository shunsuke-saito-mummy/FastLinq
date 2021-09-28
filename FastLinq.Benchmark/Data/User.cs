namespace DetailResearchOfLinq.Data
{
    public sealed class User
    {
        public readonly ulong Id;

        public readonly string Name;

        public readonly int Age;

        public User(ulong id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"(Id: {Id}, Name: {Name}, Age: {Age})";
        }
    }
}
