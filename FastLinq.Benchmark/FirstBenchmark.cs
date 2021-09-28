using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class FirstBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var _ = NumbersArray.First();
            _ = NumbersArray.First(i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var _ = Enumerable.First(NumbersArray);
            _ = Enumerable.First(NumbersArray, i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            var _ = NumbersList.First();
            _ = NumbersList.First(i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveList()
        {
            var _ = Enumerable.First(NumbersList);
            _ = Enumerable.First(NumbersList, i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            var _ = NumbersDict.First();
            _ = NumbersDict.First(i => i.Value >= 100);
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            var _ = Enumerable.First(NumbersDict, i => i.Value >= 100);
            _ = Enumerable.First(NumbersDict, i => i.Value >= 100);
        }
        
        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersArray.First();
        }

        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefault()
        {
            var _ = Enumerable.First(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveListSimpleFirstOrDefaultImproved()
        {
            var _ = NumbersList.First();
        }

        [Benchmark]
        public void PrimitiveListSimpleFistOrDefault()
        {
            var _ = Enumerable.First(NumbersList);
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersDict.First();
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefault()
        {
            var _ = Enumerable.First(NumbersDict);
        }
    }
}