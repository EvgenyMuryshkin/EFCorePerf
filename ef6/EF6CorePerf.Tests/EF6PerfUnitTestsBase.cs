using common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using transactions.sql;

namespace EF6PerfUnitTests
{
    public partial class EF6PerfUnitTestsBase
    {
        protected long batchId => EFPerfTestValues.batchId;
        protected txnTransactionsDBContext Context
        {
            get
            {
                return new TransactionsDbContextDesignFactory().CreateDbContext(Guid.Empty, EFPerfTestValues.ds);
            }
        }

        public List<HashSet<Guid>> suIds = new List<HashSet<Guid>>();
        public int Idx = 0;

        [TestInitialize]
        public void Setup()
        {
            var rnd = new Random();

            using (var ctx = Context)
            {
                var allIds = ctx.ShippingUnits.Select(i => i.ShippingUnitId).Distinct().ToList();
                foreach (var idx in Enumerable.Range(0, 100))
                {
                    var shippingUnitIds = allIds.Skip(2 * idx).Take(2).ToHashSet();
                    suIds.Add(shippingUnitIds);
                }
            }
        }
    }
}