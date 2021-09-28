using System;

namespace DetailResearchOfLinq.Data
{
    public class ComparableUser : IComparable<ComparableUser>
    {
        public readonly ulong Id;

        public readonly string Name;

        public readonly int Age;

        public ComparableUser(ulong id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }


        public int CompareTo(ComparableUser other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            if (Id == other.Id)
            {
                return 0;
            }

            // 自分のIdが比較対象より小さければ前に並べる
            if (Id < other.Id)
            {
                return -1;
            }

            // 自分のIdが比較対象より大きければ後ろに並べる
            if (Id > other.Id)
            {
                return 1;
            }
            
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            return Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}