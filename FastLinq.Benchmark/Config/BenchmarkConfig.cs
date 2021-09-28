using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;

namespace DetailResearchOfLinq.Benchmark
{
    public class BenchmarkConfig : ManualConfig
    {
        public const int DATA_SIZE = 1000;

        public const int TRY_COUNT = 100;
        
        public BenchmarkConfig()
        {
            AddExporter(HtmlExporter.Default);
            AddDiagnoser(MemoryDiagnoser.Default);
            AddJob(Job.Default);
        }
    }
}