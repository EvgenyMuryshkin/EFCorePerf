using BenchmarkDotNet.Attributes;
using System;
using System.Linq;
namespace EF2BenchmarkTopPlusOne
{
	public partial class EF2CoreBenchmarkTopPlusOne
	{
		[Benchmark]
		public void ShippingUnitsTopPlusOne0()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne0.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne1()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne1.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne2()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne2.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne3()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne3.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne4()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne4.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne5()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne5.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne6()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne6.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne7()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne7.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne8()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne8.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne9()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne9.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne10()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne10.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne11()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne11.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne12()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne12.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne13()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne13.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne14()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne14.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne15()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne15.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne16()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne16.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne17()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne17.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne18()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne18.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne19()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne19.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne20()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne20.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[Benchmark]
		public void ShippingUnitsTopPlusOne21()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne21.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
	} // end benchmark
} // end ns
