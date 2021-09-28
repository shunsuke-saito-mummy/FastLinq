using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class AnyBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var _ = NumbersArray.Any(i => i >= 1000);
            _ = NumbersArray.Any();
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var _ = Enumerable.Any(NumbersArray, i => i >= 1000);
            _ = Enumerable.Any(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            var _ = NumbersList.Any(i => i >= 1000);
            _ = NumbersList.Any();
        }

        [Benchmark]
        public void PrimitiveList()
        {
            var _ = Enumerable.Any(NumbersList, i => i >= 1000);
            _ = Enumerable.Any(NumbersList);
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            var _ = NumbersDict.Any(i => i.Value >= 1000);
            _ = NumbersDict.Any();
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            var _ = Enumerable.Any(NumbersDict, i => i.Value >= 1000);
            _ = Enumerable.Any(NumbersDict);
        }
    }
}