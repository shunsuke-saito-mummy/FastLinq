using System.Linq;
using DetailResearchOfLinq.Data;

namespace DetailResearchOfLinq.Utility
{
    public static class PersonFactory
    {
        public static Person[] CreatePersonArray(int count) => Enumerable.Range(0, count)
            .Select(i => new Person {Name = $"Person_{i}"})
            .ToArray();
    }
}