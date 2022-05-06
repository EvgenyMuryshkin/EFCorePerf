using BenchmarkDotNet.Attributes;
using common;
using System;
using System.Collections.Generic;
using System.Linq;
using transactions.sql;

namespace EF2Benchmark
{
    public partial class EF2CoreBenchmark
    {
        long batchId => EFPerfTestValues.batchId;
        txnTransactionsDBContext Context
        {
            get
            {
                return new TransactionsDbContextDesignFactory().CreateDbContext(Guid.Empty, EFPerfTestValues.ds);
            }
        }

        const int interations = 1;

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
        /*
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
        */
    }
}
