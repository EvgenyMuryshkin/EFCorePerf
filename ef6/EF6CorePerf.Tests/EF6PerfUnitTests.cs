using common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using transactions.sql;

namespace EF6PerfUnitTests
{
    public partial class EF6PerfUnitTests
    {
        long batchId => EFPerfTestValues.batchId;
        txnTransactionsDBContext Context
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

                var shippingUnitIds = allIds.Take(2).ToHashSet();
                suIds.Add(shippingUnitIds);
            }
        }

    }
}