using BenchmarkDotNet.Attributes;
using common;
using System;
using System.Collections.Generic;
using System.Linq;
using transactions.sql;

namespace EF6Benchmark
{
    public class EF6CoreBenchmarkBase
    {
        protected long batchId => EFPerfTestValues.batchId;
        protected txnTransactionsDBContext Context
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
    }
}
