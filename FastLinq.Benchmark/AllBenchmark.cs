using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class AllBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var _ = NumbersArray.All(i => i <= 1000);
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var _ = Enumerable.All(NumbersArray, i => i <= 1000);
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            var _ = NumbersList.All(i => i <= 1000);
        }

        [Benchmark]
        public void PrimitiveList()
        {
            var _ = Enumerable.All(NumbersList, i => i <= 1000);
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            var _ = NumbersDict.All(i => i.Value <= 1000);
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            var _ = Enumerable.All(NumbersDict, i => i.Value <= 1000);
        }
    }
}