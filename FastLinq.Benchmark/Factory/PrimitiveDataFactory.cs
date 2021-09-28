using System.Linq;

namespace DetailResearchOfLinq.Utility
{
    public static class PrimitiveDataFactory
    {
        public static int[] CreateNumberSequenceByArray(int size) => Enumerable.Range(0, size).ToArray();
    }
}