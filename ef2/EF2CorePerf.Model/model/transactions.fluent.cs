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
// generated class, do not modify, source here: file:///placeholder
public partial class txnTransactionsDBContext : EntityDbContext<txnTransactionsDBContext>
{
	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.HasDefaultSchema(SchemaName);
		builder.Entity<txnEntitySummaryDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnSpatialGeometryDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnSpatialGeographyDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnSpatialDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnAuthIdentityDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnEntityReferenceDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnGeoLocationReferenceDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnTextReferenceDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnDateReferenceDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnReferenceDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnSUPathwayDistributionItemDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.Property(e => e.State).HasDefaultValue(txnSUPathwayDistributionState.Undefined);
		});
		builder.Entity<txnShippingActivityItemDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.Property(e => e.State).HasDefaultValue(txnShippingActivityMetricState.Undefined);
		});
		builder.Entity<txnShippingActivityTypeDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.Property(e => e.Type).HasDefaultValue(txnShippingActivityMetricType.Undefined);
		});
		builder.Entity<txnCargoReportDbRecord>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.ShippingUnitId);
			b.HasIndex(e => e.ConsignmentId);
			b.HasIndex(e => e.NoAutoUpdate);
			b.HasIndex(e => e.InTransit);
		});
		builder.Entity<txnSAPFeedbackItemDbRecord>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnEntitySummaryReferenceDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnSUPathwayDistributionDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnShippingActivityDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
		});
		builder.Entity<txnRevisionCounterDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.Property(e => e.CounterType).HasDefaultValue(txnRevisionCounterType.Undefined);
		});
		builder.Entity<txnInventoryItemDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.InventoryItemId);
			b.Property(e => e.Event).HasDefaultValue(txnInventoryItemEventType.Undefined);
		});
		builder.Entity<txnContainerDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.ContainerId);
			b.Property(e => e.Event).HasDefaultValue(txnContainerEventType.Undefined);
		});
		builder.Entity<txnShippingUnitDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.ShippingUnitId);
			b.Property(e => e.Event).HasDefaultValue(txnShippingUnitEventType.Undefined);
		});
		builder.Entity<txnTaskDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.TaskId);
			b.Property(e => e.Event).HasDefaultValue(txnTaskEventType.Undefined);
		});
		builder.Entity<txnConsignmentDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.ConsignmentId);
			b.Property(e => e.Event).HasDefaultValue(txnConsignmentEventType.Undefined);
		});
		builder.Entity<txnCargoRequestDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.CargoRequestId);
			b.Property(e => e.Event).HasDefaultValue(txnCargoRequestEventType.Undefined);
		});
		builder.Entity<txnWorkItemDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.WorkItemId);
			b.Property(e => e.Event).HasDefaultValue(txnWorkItemEventType.Undefined);
		});
		builder.Entity<txnWorkOrderDbEntity>(b => {
			b.HasKey(e => e.Id);
			b.HasIndex(e => e.Id).IsUnique();
			b.HasIndex(e => e.WorkOrderId);
			b.Property(e => e.Event).HasDefaultValue(txnWorkOrderEventType.Undefined);
		});
		PostModelCreating(builder);
	}
}
}
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0028 // Collection Initialization
#pragma warning restore IDE0017 // Object Initialization
#pragma warning restore IDE1006 // Naming Styles
