using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace transactions.sql
{
	public partial class txnTransactionsDBContext
	{
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne0 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne1 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne2 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne3 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne4 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne5 =>
			ShippingUnits
			.Include(c => c.Identity)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne6 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne7 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne8 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne9 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne10 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne11 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne12 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne13 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne14 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne15 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne16 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne17 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne18 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne19 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne20 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne21 =>
			ShippingUnits
		;
	} // end context
} // end ns
