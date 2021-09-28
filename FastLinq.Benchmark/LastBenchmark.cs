using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class LastBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var _ = NumbersArray.Last();
            _ = NumbersArray.First(i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var _ = Enumerable.Last(NumbersArray);
            _ = Enumerable.Last(NumbersArray, i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            var _ = NumbersList.Last();
            _ = NumbersList.Last(i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveList()
        {
            var _ = Enumerable.Last(NumbersList);
            _ = Enumerable.Last(NumbersList, i => i >= 100);
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            var _ = NumbersDict.Last();
            _ = NumbersDict.Last(i => i.Value >= 100);
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            var _ = Enumerable.Last(NumbersDict, i => i.Value >= 100);
            _ = Enumerable.Last(NumbersDict, i => i.Value >= 100);
        }
        
        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersArray.Last();
        }

        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefault()
        {
            var _ = Enumerable.Last(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveListSimpleFirstOrDefaultImproved()
        {
            var _ = NumbersList.Last();
        }

        [Benchmark]
        public void PrimitiveListSimpleFistOrDefault()
        {
            var _ = Enumerable.Last(NumbersList);
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersDict.Last();
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefault()
        {
            var _ = Enumerable.Last(NumbersDict);
        }
    }
}