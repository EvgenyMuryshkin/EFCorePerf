using common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using transactions.sql;

namespace EF6CorePerf
{
    public class EF6CorePerfTestsBase
    {
        protected long batchId => EFPerfTestValues.batchId;
        protected txnTransactionsDBContext Context
        {
            get
            {
                // connection string is defined in EFPerfTestValues.ds
                return new TransactionsDbContextDesignFactory().CreateDbContext(Guid.Empty, EFPerfTestValues.ds);
            }
        }
    }

    [TestClass]
    public class EF6CorePerfTests : EF6CorePerfTestsBase
    {
        [TestMethod]
        public void Default_Missing_ByShippingUnitId()
        {
            foreach (var i in Enumerable.Range(0, 100))
            {
                using (var ctx = Context)
                {
                    var shippingUnitIds = new HashSet<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
                    var entities = ctx.ShippingUnitsWithComposites.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    Assert.IsTrue(entities.Count == 0);
                }
            }
        }

        [TestMethod]
        public void Default_Existing_ByShippingUnitId()
        {
            var suIds = new List<Guid>();
            using (var ctx = Context)
            {
                suIds = ctx.ShippingUnits.Select(i => i.ShippingUnitId).Distinct().Take(200).ToList();
            }

            foreach (var i in Enumerable.Range(0, 100))
            {
                using (var ctx = Context)
                {
                    var shippingUnitIds = suIds.Skip(i * 2).Take(2).ToHashSet();
                    var entities = ctx.ShippingUnitsWithComposites.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    Assert.IsTrue(entities.Count != 0);
                }
            }
        }
    }

    [TestClass]
    public class EF6CorePerfTests_AsSplitQuery : EF6CorePerfTestsBase
    {
        [TestMethod]
        public void Missing_ByShippingUnitId()
        {
            foreach (var i in Enumerable.Range(0, 100))
            {
                using (var ctx = Context)
                {
                    var shippingUnitIds = new HashSet<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
                    var entities = ctx.ShippingUnitsWithCompositesAsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    Assert.IsTrue(entities.Count == 0);
                }
            }
        }

        [TestMethod]
        public void Existing_ByShippingUnitId()
        {
            var suIds = new List<Guid>();
            using (var ctx = Context)
            {
                suIds = ctx.ShippingUnits.Select(i => i.ShippingUnitId).Distinct().Take(200).ToList();
            }

            foreach (var i in Enumerable.Range(0, 100))
            {
                using (var ctx = Context)
                {
                    var shippingUnitIds = suIds.Skip(i * 2).Take(2).ToHashSet();
                    var entities = ctx.ShippingUnitsWithCompositesAsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    Assert.IsTrue(entities.Count != 0);
                }
            }
        }
    }

    [TestClass]
    public class EF6CorePerfTests_FPlusOptimized : EF6CorePerfTestsBase
    {
        [TestMethod]
        public void Missing_ByShippingUnitId()
        {
            foreach (var i in Enumerable.Range(0, 100))
            {
                using (var ctx = Context)
                {
                    var shippingUnitIds = new HashSet<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
                    var entities = ctx.ShippingUnitsWithCompositesOptimized.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    Assert.IsTrue(entities.Count == 0);
                }
            }
        }

        [TestMethod]
        public void Existing_ByShippingUnitId()
        {
            var suIds = new List<Guid>();
            using (var ctx = Context)
            {
                suIds = ctx.ShippingUnits.Select(i => i.ShippingUnitId).Distinct().Take(200).ToList();
            }

            foreach (var i in Enumerable.Range(0, 100))
            {
                using (var ctx = Context)
                {
                    var shippingUnitIds = suIds.Skip(i * 2).Take(2).ToHashSet();
                    var entities = ctx.ShippingUnitsWithCompositesOptimized.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    Assert.IsTrue(entities.Count != 0);
                }
            }
        }
    }
}