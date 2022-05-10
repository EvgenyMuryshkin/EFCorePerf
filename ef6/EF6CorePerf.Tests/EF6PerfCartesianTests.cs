using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace EF6PerfUnitTests
{
    [TestClass]
    public partial class EF6PerfCartesianTests : EF6PerfUnitTestsBase
    {
        [TestMethod]
        public void SingleQuery()
        {
            using (var ctx = Context)
            {
				var query = ctx
					.ShippingUnits
                    .Include(c => c.References)
                ;

				foreach (var idx in Enumerable.Range(0, suIds.Count))
                {
                    var shippingUnitIds = suIds[idx];
                    var entities = query.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    if (entities.Count == 0)
                        throw new Exception();
                }
            }
		}

        [TestMethod]
        public void SplitQuery()
        {
            using (var ctx = Context)
            {
                var query = ctx
                    .ShippingUnits
                    .Include(c => c.References)
                    .AsSplitQuery()
                ;

                foreach (var idx in Enumerable.Range(0, suIds.Count))
                {
                    var shippingUnitIds = suIds[idx];
                    var entities = query.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                    if (entities.Count == 0)
                        throw new Exception();
                }
            }
        }
    }
}