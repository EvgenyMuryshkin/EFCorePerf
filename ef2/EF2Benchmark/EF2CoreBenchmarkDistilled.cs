using BenchmarkDotNet.Attributes;
using EF2Benchmark;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EF2BenchmarkTopPlusOne
{
    public partial class EF2CoreBenchmarkDistilled : EF2CoreBenchmarkBase
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
    }
}
