using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace EF2PerfUnitTests
{
	[TestClass]
	public partial class EF2PerfUnitTests
	{
		[TestMethod]
		public void ShippingUnitsWithComposites0()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites0.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites1()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites1.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites2()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites2.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites3()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites3.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites4()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites4.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites5()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites5.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites6()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites6.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites7()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites7.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites8()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites8.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites9()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites9.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites10()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites10.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites11()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites11.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites12()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites12.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites13()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites13.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites14()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites14.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites15()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites15.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites16()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites16.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites17()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites17.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites18()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites18.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites19()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites19.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites20()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites20.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites21()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites21.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites22()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites22.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites23()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites23.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites24()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites24.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites25()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites25.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites26()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites26.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites27()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites27.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites28()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites28.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites29()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites29.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites30()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites30.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites31()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites31.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites32()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites32.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites33()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites33.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites34()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites34.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites35()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites35.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites36()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites36.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites37()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites37.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites38()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites38.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites39()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites39.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites40()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites40.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites41()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites41.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites42()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites42.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites43()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites43.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites44()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites44.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites45()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites45.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites46()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites46.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites47()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites47.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites48()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites48.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites49()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites49.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites50()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites50.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites51()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites51.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites52()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites52.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites53()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites53.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites54()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites54.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites55()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites55.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites56()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites56.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites57()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites57.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites58()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites58.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites59()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites59.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites60()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites60.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
		[TestMethod]
		public void ShippingUnitsWithComposites61()
		{

            using (var ctx = Context)
            {
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites61.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }

		}
	} // end benchmark
} // end ns
