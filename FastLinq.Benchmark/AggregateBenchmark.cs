using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class AggregateBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var accumulate = NumbersArray.Aggregate(0, (total, elem) => total += elem, total => total);
            accumulate = NumbersArray.Aggregate(0, (total, elem) => total += elem);
            accumulate = NumbersArray.Aggregate((total, elem) => total += elem);
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var accumulate = Enumerable.Aggregate(NumbersArray, 0, (total, elem) => total += elem, total => total);
            accumulate = Enumerable.Aggregate(NumbersArray, 0, (total, elem) => total += elem);
            accumulate = Enumerable.Aggregate(NumbersArray, (total, elem) => total += elem);
        }

        [Benchmark]
        public void PrimitiveListImproved()
        {
            var accumulate = NumbersList.Aggregate(0, (total, elem) => total += elem, total => total);
            accumulate = NumbersList.Aggregate(0, (total, elem) => total += elem);
            accumulate = NumbersList.Aggregate((total, elem) => total += elem);
        }

        [Benchmark]
        public void PrimitiveList()
        {
            var accumulate = Enumerable.Aggregate(NumbersList, 0, (total, elem) => total += elem, total => total);
            accumulate = Enumerable.Aggregate(NumbersList, 0, (total, elem) => total += elem);
            accumulate = Enumerable.Aggregate(NumbersList, (total, elem) => total += elem);
        }

        [Benchmark]
        public void PrimitiveDictionaryImproved()
        {
            var accumulate = NumbersDict.Aggregate(0, (total, pair) => total += pair.Value, total => total);
            accumulate = NumbersDict.Aggregate(0, ((total, pair) => total += pair.Value));
            var newAccumulate = NumbersDict.Aggregate((total, pair) => total = pair);
        }

        [Benchmark]
        public void PrimitiveDictionary()
        {
            var accumulate = Enumerable.Aggregate(NumbersDict, 0, (total, pair) => total += pair.Value, total => total);
            accumulate = Enumerable.Aggregate(NumbersDict, 0, (total, pair) => total += pair.Value);
            var newAccumulate = Enumerable.Aggregate(NumbersDict, (total, pair) => total = pair);
        }
    }
}