using BenchmarkDotNet.Running;
using DetailResearchOfLinq.Benchmark;
using DetailResearchOfLinq.Benchmark.Sandbox;

namespace FastLinq.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[]
            {
                typeof(AggregateBenchmark),
                typeof(AllBenchmark),
                typeof(AnyBenchmark),
                typeof(ContainsBenchmark),
                typeof(CountBenchmark),
                typeof(FirstBenchmark),
                typeof(FirstOrDefaultBenchmark),
                typeof(LinqVsPureLogicBenchmark),
                typeof(SequenceEqualBenchmark),
            });
            switcher.Run(args);
        }
    }
}
