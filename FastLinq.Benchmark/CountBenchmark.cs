using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class CountBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var count = NumbersArray.Count(j => j % 2 == 0);
        }

        [Benchmark]
        public void PrimitiveArraySimpleCountImproved()
        {
            var _ = NumbersArray.Count();
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var count = Enumerable.Count(NumbersArray, j => j % 2 == 0);
        }

        [Benchmark]
        public void PrimitiveArraySimpleCount()
        {
            var _ = Enumerable.Count(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            var count = NumbersList.Count(j => j % 2 == 0);
        }

        [Benchmark]
        public void PrimitiveListSimpleCountImproved()
        {
            var _ = NumbersList.Count();
        }

        [Benchmark]
        public void PrimitiveList()
        {
            var count = Enumerable.Count(NumbersList, j => j % 2 == 0);
        }

        [Benchmark]
        public void PrimitiveListSimpleCount()
        {
            var _ = Enumerable.Count(NumbersList);
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            var count = NumbersDict.Count(j => j.Value % 2 == 0);
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleCountImproved()
        {
            var _ = NumbersDict.Count();
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            var count = Enumerable.Count(NumbersDict, j => j.Value % 2 == 0);
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleCount()
        {
            var _ = Enumerable.Count(NumbersDict);
        }
    }
}