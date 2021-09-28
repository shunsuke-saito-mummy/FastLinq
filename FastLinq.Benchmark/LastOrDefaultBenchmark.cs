using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class LastOrDefaultBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = NumbersArray.LastOrDefault(n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = Enumerable.LastOrDefault(NumbersArray, n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = NumbersList.LastOrDefault(n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveList()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = Enumerable.LastOrDefault(NumbersList, n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = NumbersDict.LastOrDefault(n => n.Value == target);
            }
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = Enumerable.LastOrDefault(NumbersDict, n => n.Value == target);
            }
        }
        
        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersArray.LastOrDefault();
        }

        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefault()
        {
            var _ = Enumerable.LastOrDefault(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveListSimpleFirstOrDefaultImproved()
        {
            var _ = NumbersList.LastOrDefault();
        }

        [Benchmark]
        public void PrimitiveListSimpleFistOrDefault()
        {
            var _ = Enumerable.LastOrDefault(NumbersList);
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersDict.LastOrDefault();
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefault()
        {
            var _ = Enumerable.LastOrDefault(NumbersDict);
        }
    }
}