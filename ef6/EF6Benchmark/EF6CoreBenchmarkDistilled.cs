using BenchmarkDotNet.Attributes;
using EF6Benchmark;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF6BenchmarkTopPlusOne
{
    public partial class EF6CoreBenchmarkDistilled : EF6CoreBenchmarkBase
    {
        [Benchmark]
        public void Distilled()
        {
            using (var ctx = Context)
            {
                var query = ctx
                    .ShippingUnits
                    .Include(c => c.References).ThenInclude(c => c.Date)
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

        [Benchmark]
        public void Distilled_AsSplitQuery()
        {
            using (var ctx = Context)
            {
                var query = ctx
                    .ShippingUnits
                    .Include(c => c.References).ThenInclude(c => c.Date)
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
