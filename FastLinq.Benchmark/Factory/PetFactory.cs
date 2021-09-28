using System.Linq;
using DetailResearchOfLinq.Data;

namespace DetailResearchOfLinq.Utility
{
    public static class PetFactory
    {
        public static Pet[] CreatePetArray(int count) => Enumerable.Range(0, count)
            .Select(i => new Pet {Name = $"Pet_{i}", Owner = new Person {Name = $"Person_{(i % 3)}"}})
            .ToArray();
    }
}