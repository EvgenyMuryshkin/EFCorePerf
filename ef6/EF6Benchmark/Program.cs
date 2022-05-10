using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using EF6BenchmarkTopPlusOne;

namespace EF6Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig.CreateMinimumViable();
            config.AddExporter(CsvMeasurementsExporter.Default);
            var summary = BenchmarkRunner.Run<EF6CoreBenchmarkDistilled>(config);
        }
    }
}
