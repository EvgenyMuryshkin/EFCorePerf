// autogenerated by ServerDbGenerator
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable IDE0017 // Object Initialization
#pragma warning disable IDE0028 // Collection Initialization
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
#pragma warning disable CS0612 // Type or member is obsolete
using crosscutting.sql;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using crosscutting.cqrs;
namespace transactions.sql
{
	using transactions.sql;
// generated class, do not modify, source here: file:///placeholder
public partial class txnTransactionsDBContext : EntityDbContext<txnTransactionsDBContext>
{
	// top-level queries with composites
	public IQueryable<txnInventoryItemDbEntity> InventoryItemsWithComposites =>
		InventoryItems
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
	public IQueryable<txnContainerDbEntity> ContainersWithComposites =>
		Containers
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
	public IQueryable<txnShippingUnitDbEntity> ShippingUnitsWithComposites =>
		ShippingUnits
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;

		public IQueryable<txnSUPathwayDistributionDbEntity> SUPathwayDistributionsWithComposites =>
		SUPathwayDistributions
			.Include(c => c.Items)
		;
	public IQueryable<txnShippingActivityDbEntity> ShippingActivitiesWithComposites =>
		ShippingActivities
			.Include(c => c.Types).ThenInclude(c => c.Items)
		;
	public IQueryable<txnTaskDbEntity> TasksWithComposites =>
		Tasks
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
	public IQueryable<txnConsignmentDbEntity> ConsignmentsWithComposites =>
		Consignments
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
	public IQueryable<txnRevisionCounterDbEntity> RevisionCountersWithComposites =>
		RevisionCounters
		;
	public IQueryable<txnCargoReportDbRecord> CargoReportsWithComposites =>
		CargoReports
		;
	public IQueryable<txnSAPFeedbackItemDbRecord> SAPFeedbackItemsWithComposites =>
		SAPFeedbackItems
		;
	public IQueryable<txnCargoRequestDbEntity> CargoRequestsWithComposites =>
		CargoRequests
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
	public IQueryable<txnWorkItemDbEntity> WorkItemsWithComposites =>
		WorkItems
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
	public IQueryable<txnWorkOrderDbEntity> WorkOrdersWithComposites =>
		WorkOrders
			.Include(c => c.EndReference).ThenInclude(c => c.Date)
			.Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.EndReference).ThenInclude(c => c.Text)
			.Include(c => c.Identity)
			.Include(c => c.Receipent).ThenInclude(c => c.Date)
			.Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.Receipent).ThenInclude(c => c.Text)
			.Include(c => c.References).ThenInclude(c => c.Date)
			.Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.References).ThenInclude(c => c.Text)
			.Include(c => c.StartReference).ThenInclude(c => c.Date)
			.Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)
			.Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)
			.Include(c => c.StartReference).ThenInclude(c => c.Text)
		;
}
}
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0028 // Collection Initialization
#pragma warning restore IDE0017 // Object Initialization
#pragma warning restore IDE1006 // Naming Styles
