using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace EF6PerfUnitTests
{
	[TestClass]
	public partial class EF6PerfTopPlusOneUnitTests
	{
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne0AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne0AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne1AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne1AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne2AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne2AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne3AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne3AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne4AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne4AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne5AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne5AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne6AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne6AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne7AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne7AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne8AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne8AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne9AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne9AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne10AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne10AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne11AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne11AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne12AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne12AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne13AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne13AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne14AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne14AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne15AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne15AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne16AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne16AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne17AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne17AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne18AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne18AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne19AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne19AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne20AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne20AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
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
		[TestMethod]
		public void ShippingUnitsTopPlusOne21AsSplitQuery()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne21AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
	} // end benchmark
} // end ns
