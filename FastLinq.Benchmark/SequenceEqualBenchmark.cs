using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class SequenceEqualBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            var _ = NumbersArray.SequenceEqual(NumbersArray);
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            var _ = Enumerable.SequenceEqual(NumbersArray, NumbersArray);
        }
    }
}