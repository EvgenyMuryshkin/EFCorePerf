using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EF2Benchmark
{
    public partial class EF2CoreBenchmarkFullQuery : EF2CoreBenchmarkBase
    {
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
    }
}
