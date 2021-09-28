using System.Linq;
using BenchmarkDotNet.Attributes;

namespace DetailResearchOfLinq.Benchmark
{
    [Config(typeof(BenchmarkConfig))]
    public class ContainsBenchmark : BaseBenchmark
    {
        [Benchmark]
        public void PrimitiveArrayImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var _ = NumbersArray.Contains(RandomIndexes[i], null);
            }
        }

        [Benchmark]
        public void UserArrayImproved()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var _ = UsersArray.Contains(TargetUser, null);
            }
        }

        [Benchmark]
        public void PrimitiveArray()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var _ = Enumerable.Contains(NumbersArray, RandomIndexes[i], null);
            }
        }

        [Benchmark]
        public void UserArray()
        {
            for (var i = 0; i < BenchmarkConfig.TRY_COUNT; i++)
            {
                var _ = Enumerable.Contains(UsersArray, TargetUser, null);
            }
        }
    }
}