using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class FirstOrDefaultBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = NumbersArray.FirstOrDefault(n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = Enumerable.FirstOrDefault(NumbersArray, n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = NumbersList.FirstOrDefault(n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveList()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = Enumerable.FirstOrDefault(NumbersList, n => n == target);
            }
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = NumbersDict.FirstOrDefault(n => n.Value == target);
            }
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var target = RandomIndexes[i];
                var _ = Enumerable.FirstOrDefault(NumbersDict, n => n.Value == target);
            }
        }

        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersArray.FirstOrDefault();
        }

        [Benchmark]
        public void PrimitiveArraySimpleFirstOrDefault()
        {
            var _ = Enumerable.FirstOrDefault(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveListSimpleFirstOrDefaultImproved()
        {
            var _ = NumbersList.FirstOrDefault();
        }

        [Benchmark]
        public void PrimitiveListSimpleFistOrDefault()
        {
            var _ = Enumerable.FirstOrDefault(NumbersList);
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefaultImproved()
        {
            var _ = NumbersDict.FirstOrDefault();
        }

        [Benchmark]
        public void PrimitiveDictionarySimpleFirstOrDefault()
        {
            var _ = Enumerable.FirstOrDefault(NumbersDict);
        }
    }
}