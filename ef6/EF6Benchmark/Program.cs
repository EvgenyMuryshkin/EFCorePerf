using BenchmarkDotNet.Analysers;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using common;
using System;
using System.Collections.Generic;
using System.Linq;
using transactions.sql;

namespace EF6Benchmark
{
    public class EF6CoreBenchmark
    {
        long batchId => EFPerfTestValues.batchId;
        txnTransactionsDBContext Context
        {
            get
            {
                return new TransactionsDbContextDesignFactory().CreateDbContext(Guid.Empty, EFPerfTestValues.ds);
            }
        }

        const int interations = 5;

        [ParamsSource(nameof(ValuesForIdx))]
        public int Idx;
        public IEnumerable<int> ValuesForIdx => Enumerable.Range(0, interations);

        public List<HashSet<Guid>> suIds = new List<HashSet<Guid>>();

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random();

            using (var ctx = Context)
            {
                var allIds = ctx.ShippingUnits.Select(i => i.ShippingUnitId).Distinct().ToList();
                var testIds = Enumerable.Range(0, interations * 2).Select(_ => allIds[rnd.Next(allIds.Count)]);

                foreach (var id in Enumerable.Range(0, interations))
                {
                    var shippingUnitIds = testIds.Skip(id * 2).Take(2).ToHashSet();
                    suIds.Add(shippingUnitIds);
                }
            }
        }

        [Benchmark]
        public void Default_Existing_ByShippingUnitId()
        {
            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }
        }

        [Benchmark]
        public void Default_Missing_ByShippingUnitId()
        {
            using (var ctx = Context)
            {
                var shippingUnitIds = new HashSet<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
                var entities = ctx.ShippingUnitsWithComposites.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count != 0)
                    throw new Exception();
            }
        }

        [Benchmark]
        public void AsSplitQuery_Existing_ByShippingUnitId()
        {
            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithCompositesAsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0)
                    throw new Exception();
            }
        }

        [Benchmark]
        public void AsSplitQuery_Missing_ByShippingUnitId()
        {
            using (var ctx = Context)
            {
                var shippingUnitIds = new HashSet<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
                var entities = ctx.ShippingUnitsWithCompositesAsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count != 0)
                    throw new Exception();
            }
        }

        [Benchmark]
        public void EFPlusOptimized_Existing_ByShippingUnitId()
        {
            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithCompositesOptimized.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0)
                    throw new Exception();
            }
        }

        [Benchmark]
        public void EFPlusOptimized_Missing_ByShippingUnitId()
        {
            using (var ctx = Context)
            {
                var shippingUnitIds = new HashSet<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
                var entities = ctx.ShippingUnitsWithCompositesOptimized.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count != 0)
                    throw new Exception();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig.CreateMinimumViable();
            config.AddExporter(CsvMeasurementsExporter.Default);
            var summary = BenchmarkRunner.Run<EF6CoreBenchmark>(config);
        }
    }
}
