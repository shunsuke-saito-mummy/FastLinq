using System.Collections.Generic;

namespace DetailResearchOfLinq.Data
{
    public sealed class Person
    {
        public string Name;

        public List<Pet> Pets = new List<Pet>();

        public override string ToString()
        {
            return Name;
        }
    }
}