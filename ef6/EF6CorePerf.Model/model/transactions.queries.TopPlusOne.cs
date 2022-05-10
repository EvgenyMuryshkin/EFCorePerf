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
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne0AsSplitQuery => ShippingUnitsTopPlusOne0.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne1 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne1AsSplitQuery => ShippingUnitsTopPlusOne1.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne2 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne2AsSplitQuery => ShippingUnitsTopPlusOne2.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne3 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne3AsSplitQuery => ShippingUnitsTopPlusOne3.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne4 =>
			ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne4AsSplitQuery => ShippingUnitsTopPlusOne4.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne5 =>
			ShippingUnits
			.Include(c => c.Identity)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne5AsSplitQuery => ShippingUnitsTopPlusOne5.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne6 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne6AsSplitQuery => ShippingUnitsTopPlusOne6.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne7 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne7AsSplitQuery => ShippingUnitsTopPlusOne7.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne8 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne8AsSplitQuery => ShippingUnitsTopPlusOne8.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne9 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne9AsSplitQuery => ShippingUnitsTopPlusOne9.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne10 =>
			ShippingUnits
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne10AsSplitQuery => ShippingUnitsTopPlusOne10.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne11 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne11AsSplitQuery => ShippingUnitsTopPlusOne11.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne12 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne12AsSplitQuery => ShippingUnitsTopPlusOne12.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne13 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne13AsSplitQuery => ShippingUnitsTopPlusOne13.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne14 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne14AsSplitQuery => ShippingUnitsTopPlusOne14.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne15 =>
			ShippingUnits
			.Include(c => c.References).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne15AsSplitQuery => ShippingUnitsTopPlusOne15.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne16 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne16AsSplitQuery => ShippingUnitsTopPlusOne16.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne17 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne17AsSplitQuery => ShippingUnitsTopPlusOne17.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne18 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne18AsSplitQuery => ShippingUnitsTopPlusOne18.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne19 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne19AsSplitQuery => ShippingUnitsTopPlusOne19.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne20 =>
			ShippingUnits
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne20AsSplitQuery => ShippingUnitsTopPlusOne20.AsSplitQuery();
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne21 =>
			ShippingUnits
		;
		public IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne21AsSplitQuery => ShippingUnitsTopPlusOne21.AsSplitQuery();
	} // end context
} // end ns
