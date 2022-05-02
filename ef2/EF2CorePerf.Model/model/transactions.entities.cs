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
[Table("EntitySummaries")]
public class txnEntitySummaryDbEntity : IDbEntity, ISummaryDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	string _Basic = "";
	public string Basic { get => _Basic ?? ""; set => _Basic = value; }
	string _Extended = "";
	public string Extended { get => _Extended ?? ""; set => _Extended = value; }
	string _Detailed = "";
	public string Detailed { get => _Detailed ?? ""; set => _Detailed = value; }
	// Navigation properties
	// Back relationship for txnEntitySummaryReference.Summary
	[InverseProperty(nameof(txnEntitySummaryReferenceDbEntity.Summary))]
	public List<txnEntitySummaryReferenceDbEntity> EntitySummaryReferences_Summary { get; set; } = new List<txnEntitySummaryReferenceDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("SpatialGeometries")]
public class txnSpatialGeometryDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public decimal L { get; set; } = 0;
	public decimal B { get; set; } = 0;
	public decimal H { get; set; } = 0;
	// Navigation properties
	// Back relationship for txnSpatial.Geometry
	[InverseProperty(nameof(txnSpatialDbEntity.Geometry))]
	public List<txnSpatialDbEntity> Spatials_Geometry { get; set; } = new List<txnSpatialDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("SpatialGeographies")]
public class txnSpatialGeographyDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public DateTime Timestamp { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public double Latitude { get; set; } = 0;
	public double Longitude { get; set; } = 0;
	public double Elevation { get; set; } = 0;
	// Navigation properties
	// Back reference for txnSpatial.GeographyIds
	public Guid? SpatialId { get; set; }
	[ForeignKey("SpatialId")]
	public txnSpatialDbEntity Spatial { get; set; }
	public int IndexInSpatial { get; set; }
}
// generated class, do not modify, source here: file:///placeholder
[Table("Spatials")]
public class txnSpatialDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();

	// Reference to txnSpatialGeometry
	public Guid GeometryId { get; set; }
	[ForeignKey("GeometryId")]
	public txnSpatialGeometryDbEntity Geometry { get; set; }


	// Relationship to txnSpatialGeography, Coposite
	public List<txnSpatialGeographyDbEntity> Geographies { get; set; } = new List<txnSpatialGeographyDbEntity>();

	// Navigation properties
	// Back relationship for txnGeoLocationReference.Spatial
	[InverseProperty(nameof(txnGeoLocationReferenceDbEntity.Spatial))]
	public List<txnGeoLocationReferenceDbEntity> GeoLocationReferences_Spatial { get; set; } = new List<txnGeoLocationReferenceDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("AuthIdentities")]
public class txnAuthIdentityDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	string _IdentityJson = "";
	public string IdentityJson { get => _IdentityJson ?? ""; set => _IdentityJson = value; }
	// Navigation properties
	// Back relationship for txnInventoryItem.Identity
	[InverseProperty(nameof(txnInventoryItemDbEntity.Identity))]
	public List<txnInventoryItemDbEntity> InventoryItems_Identity { get; set; } = new List<txnInventoryItemDbEntity>();
	// Back relationship for txnContainer.Identity
	[InverseProperty(nameof(txnContainerDbEntity.Identity))]
	public List<txnContainerDbEntity> Containers_Identity { get; set; } = new List<txnContainerDbEntity>();
	// Back relationship for txnShippingUnit.Identity
	[InverseProperty(nameof(txnShippingUnitDbEntity.Identity))]
	public List<txnShippingUnitDbEntity> ShippingUnits_Identity { get; set; } = new List<txnShippingUnitDbEntity>();
	// Back relationship for txnTask.Identity
	[InverseProperty(nameof(txnTaskDbEntity.Identity))]
	public List<txnTaskDbEntity> Tasks_Identity { get; set; } = new List<txnTaskDbEntity>();
	// Back relationship for txnConsignment.Identity
	[InverseProperty(nameof(txnConsignmentDbEntity.Identity))]
	public List<txnConsignmentDbEntity> Consignments_Identity { get; set; } = new List<txnConsignmentDbEntity>();
	// Back relationship for txnCargoRequest.Identity
	[InverseProperty(nameof(txnCargoRequestDbEntity.Identity))]
	public List<txnCargoRequestDbEntity> CargoRequests_Identity { get; set; } = new List<txnCargoRequestDbEntity>();
	// Back relationship for txnWorkItem.Identity
	[InverseProperty(nameof(txnWorkItemDbEntity.Identity))]
	public List<txnWorkItemDbEntity> WorkItems_Identity { get; set; } = new List<txnWorkItemDbEntity>();
	// Back relationship for txnWorkOrder.Identity
	[InverseProperty(nameof(txnWorkOrderDbEntity.Identity))]
	public List<txnWorkOrderDbEntity> WorkOrders_Identity { get; set; } = new List<txnWorkOrderDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("EntityReferences")]
public class txnEntityReferenceDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	string _EntityType = "";
	public string EntityType { get => _EntityType ?? ""; set => _EntityType = value; }
	public Guid EntityId { get; set; } = Guid.Empty;
	public long Revision { get; set; } = 0;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("GeoLocationReferences")]
public class txnGeoLocationReferenceDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();

	// Reference to txnSpatial
	public Guid SpatialId { get; set; }
	[ForeignKey("SpatialId")]
	public txnSpatialDbEntity Spatial { get; set; }

	public bool GeoMismatch { get; set; } = false;
	// Navigation properties
	// Back relationship for txnReference.Location
	[InverseProperty(nameof(txnReferenceDbEntity.Location))]
	public List<txnReferenceDbEntity> References_Location { get; set; } = new List<txnReferenceDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("TextReferences")]
public class txnTextReferenceDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	string _Text = "";
	public string Text { get => _Text ?? ""; set => _Text = value; }
	// Navigation properties
	// Back relationship for txnReference.Text
	[InverseProperty(nameof(txnReferenceDbEntity.Text))]
	public List<txnReferenceDbEntity> References_Text { get; set; } = new List<txnReferenceDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("DateReferences")]
public class txnDateReferenceDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public DateTime Date { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	// Navigation properties
	// Back relationship for txnReference.Date
	[InverseProperty(nameof(txnReferenceDbEntity.Date))]
	public List<txnReferenceDbEntity> References_Date { get; set; } = new List<txnReferenceDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("References")]
public class txnReferenceDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();

	// Reference to txnEntitySummaryReference
	public Guid? EntityId { get; set; }
	[ForeignKey("EntityId")]
	public txnEntitySummaryReferenceDbEntity Entity { get; set; }


	// Reference to txnGeoLocationReference
	public Guid? LocationId { get; set; }
	[ForeignKey("LocationId")]
	public txnGeoLocationReferenceDbEntity Location { get; set; }


	// Reference to txnTextReference
	public Guid? TextId { get; set; }
	[ForeignKey("TextId")]
	public txnTextReferenceDbEntity Text { get; set; }


	// Reference to txnDateReference
	public Guid? DateId { get; set; }
	[ForeignKey("DateId")]
	public txnDateReferenceDbEntity Date { get; set; }

	// Navigation properties
	// Back relationship for txnInventoryItem.StartReference
	[InverseProperty(nameof(txnInventoryItemDbEntity.StartReference))]
	public List<txnInventoryItemDbEntity> InventoryItems_StartReference { get; set; } = new List<txnInventoryItemDbEntity>();
	// Back relationship for txnInventoryItem.EndReference
	[InverseProperty(nameof(txnInventoryItemDbEntity.EndReference))]
	public List<txnInventoryItemDbEntity> InventoryItems_EndReference { get; set; } = new List<txnInventoryItemDbEntity>();
	// Back relationship for txnInventoryItem.Receipent
	[InverseProperty(nameof(txnInventoryItemDbEntity.Receipent))]
	public List<txnInventoryItemDbEntity> InventoryItems_Receipent { get; set; } = new List<txnInventoryItemDbEntity>();
	// Back reference for txnInventoryItem.ReferenceIds
	public Guid? InventoryItemId { get; set; }
	[ForeignKey("InventoryItemId")]
	public txnInventoryItemDbEntity InventoryItem { get; set; }
	public int IndexInInventoryItem { get; set; }
	// Back relationship for txnContainer.StartReference
	[InverseProperty(nameof(txnContainerDbEntity.StartReference))]
	public List<txnContainerDbEntity> Containers_StartReference { get; set; } = new List<txnContainerDbEntity>();
	// Back relationship for txnContainer.EndReference
	[InverseProperty(nameof(txnContainerDbEntity.EndReference))]
	public List<txnContainerDbEntity> Containers_EndReference { get; set; } = new List<txnContainerDbEntity>();
	// Back relationship for txnContainer.Receipent
	[InverseProperty(nameof(txnContainerDbEntity.Receipent))]
	public List<txnContainerDbEntity> Containers_Receipent { get; set; } = new List<txnContainerDbEntity>();
	// Back reference for txnContainer.ReferenceIds
	public Guid? ContainerId { get; set; }
	[ForeignKey("ContainerId")]
	public txnContainerDbEntity Container { get; set; }
	public int IndexInContainer { get; set; }
	// Back relationship for txnShippingUnit.StartReference
	[InverseProperty(nameof(txnShippingUnitDbEntity.StartReference))]
	public List<txnShippingUnitDbEntity> ShippingUnits_StartReference { get; set; } = new List<txnShippingUnitDbEntity>();
	// Back relationship for txnShippingUnit.EndReference
	[InverseProperty(nameof(txnShippingUnitDbEntity.EndReference))]
	public List<txnShippingUnitDbEntity> ShippingUnits_EndReference { get; set; } = new List<txnShippingUnitDbEntity>();
	// Back relationship for txnShippingUnit.Receipent
	[InverseProperty(nameof(txnShippingUnitDbEntity.Receipent))]
	public List<txnShippingUnitDbEntity> ShippingUnits_Receipent { get; set; } = new List<txnShippingUnitDbEntity>();
	// Back reference for txnShippingUnit.ReferenceIds
	public Guid? ShippingUnitId { get; set; }
	[ForeignKey("ShippingUnitId")]
	public txnShippingUnitDbEntity ShippingUnit { get; set; }
	public int IndexInShippingUnit { get; set; }
	// Back relationship for txnTask.StartReference
	[InverseProperty(nameof(txnTaskDbEntity.StartReference))]
	public List<txnTaskDbEntity> Tasks_StartReference { get; set; } = new List<txnTaskDbEntity>();
	// Back relationship for txnTask.EndReference
	[InverseProperty(nameof(txnTaskDbEntity.EndReference))]
	public List<txnTaskDbEntity> Tasks_EndReference { get; set; } = new List<txnTaskDbEntity>();
	// Back relationship for txnTask.Receipent
	[InverseProperty(nameof(txnTaskDbEntity.Receipent))]
	public List<txnTaskDbEntity> Tasks_Receipent { get; set; } = new List<txnTaskDbEntity>();
	// Back reference for txnTask.ReferenceIds
	public Guid? TaskId { get; set; }
	[ForeignKey("TaskId")]
	public txnTaskDbEntity Task { get; set; }
	public int IndexInTask { get; set; }
	// Back relationship for txnConsignment.StartReference
	[InverseProperty(nameof(txnConsignmentDbEntity.StartReference))]
	public List<txnConsignmentDbEntity> Consignments_StartReference { get; set; } = new List<txnConsignmentDbEntity>();
	// Back relationship for txnConsignment.EndReference
	[InverseProperty(nameof(txnConsignmentDbEntity.EndReference))]
	public List<txnConsignmentDbEntity> Consignments_EndReference { get; set; } = new List<txnConsignmentDbEntity>();
	// Back relationship for txnConsignment.Receipent
	[InverseProperty(nameof(txnConsignmentDbEntity.Receipent))]
	public List<txnConsignmentDbEntity> Consignments_Receipent { get; set; } = new List<txnConsignmentDbEntity>();
	// Back reference for txnConsignment.ReferenceIds
	public Guid? ConsignmentId { get; set; }
	[ForeignKey("ConsignmentId")]
	public txnConsignmentDbEntity Consignment { get; set; }
	public int IndexInConsignment { get; set; }
	// Back relationship for txnCargoRequest.StartReference
	[InverseProperty(nameof(txnCargoRequestDbEntity.StartReference))]
	public List<txnCargoRequestDbEntity> CargoRequests_StartReference { get; set; } = new List<txnCargoRequestDbEntity>();
	// Back relationship for txnCargoRequest.EndReference
	[InverseProperty(nameof(txnCargoRequestDbEntity.EndReference))]
	public List<txnCargoRequestDbEntity> CargoRequests_EndReference { get; set; } = new List<txnCargoRequestDbEntity>();
	// Back relationship for txnCargoRequest.Receipent
	[InverseProperty(nameof(txnCargoRequestDbEntity.Receipent))]
	public List<txnCargoRequestDbEntity> CargoRequests_Receipent { get; set; } = new List<txnCargoRequestDbEntity>();
	// Back reference for txnCargoRequest.ReferenceIds
	public Guid? CargoRequestId { get; set; }
	[ForeignKey("CargoRequestId")]
	public txnCargoRequestDbEntity CargoRequest { get; set; }
	public int IndexInCargoRequest { get; set; }
	// Back relationship for txnWorkItem.StartReference
	[InverseProperty(nameof(txnWorkItemDbEntity.StartReference))]
	public List<txnWorkItemDbEntity> WorkItems_StartReference { get; set; } = new List<txnWorkItemDbEntity>();
	// Back relationship for txnWorkItem.EndReference
	[InverseProperty(nameof(txnWorkItemDbEntity.EndReference))]
	public List<txnWorkItemDbEntity> WorkItems_EndReference { get; set; } = new List<txnWorkItemDbEntity>();
	// Back relationship for txnWorkItem.Receipent
	[InverseProperty(nameof(txnWorkItemDbEntity.Receipent))]
	public List<txnWorkItemDbEntity> WorkItems_Receipent { get; set; } = new List<txnWorkItemDbEntity>();
	// Back reference for txnWorkItem.ReferenceIds
	public Guid? WorkItemId { get; set; }
	[ForeignKey("WorkItemId")]
	public txnWorkItemDbEntity WorkItem { get; set; }
	public int IndexInWorkItem { get; set; }
	// Back relationship for txnWorkOrder.StartReference
	[InverseProperty(nameof(txnWorkOrderDbEntity.StartReference))]
	public List<txnWorkOrderDbEntity> WorkOrders_StartReference { get; set; } = new List<txnWorkOrderDbEntity>();
	// Back relationship for txnWorkOrder.EndReference
	[InverseProperty(nameof(txnWorkOrderDbEntity.EndReference))]
	public List<txnWorkOrderDbEntity> WorkOrders_EndReference { get; set; } = new List<txnWorkOrderDbEntity>();
	// Back relationship for txnWorkOrder.Receipent
	[InverseProperty(nameof(txnWorkOrderDbEntity.Receipent))]
	public List<txnWorkOrderDbEntity> WorkOrders_Receipent { get; set; } = new List<txnWorkOrderDbEntity>();
	// Back reference for txnWorkOrder.ReferenceIds
	public Guid? WorkOrderId { get; set; }
	[ForeignKey("WorkOrderId")]
	public txnWorkOrderDbEntity WorkOrder { get; set; }
	public int IndexInWorkOrder { get; set; }
}
// generated class, do not modify, source here: file:///placeholder
[Table("SUPathwayDistributionItems")]
public class txnSUPathwayDistributionItemDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public txnSUPathwayDistributionState State { get; set; } = txnSUPathwayDistributionState.Undefined;
	public int TotalQty { get; set; } = 0;
	public decimal TotalWeight { get; set; } = 0;
	public decimal TotalVolume { get; set; } = 0;
	// Navigation properties
	// Back reference for txnSUPathwayDistribution.ItemIds
	public Guid? SUPathwayDistributionId { get; set; }
	[ForeignKey("SUPathwayDistributionId")]
	public txnSUPathwayDistributionDbEntity SUPathwayDistribution { get; set; }
	public int IndexInSUPathwayDistribution { get; set; }
}
// generated class, do not modify, source here: file:///placeholder
[Table("ShippingActivityItems")]
public class txnShippingActivityItemDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public txnShippingActivityMetricState State { get; set; } = txnShippingActivityMetricState.Undefined;
	public int TotalQty { get; set; } = 0;
	// Navigation properties
	// Back reference for txnShippingActivityType.ItemIds
	public Guid? ShippingActivityTypeId { get; set; }
	[ForeignKey("ShippingActivityTypeId")]
	public txnShippingActivityTypeDbEntity ShippingActivityType { get; set; }
	public int IndexInShippingActivityType { get; set; }
}
// generated class, do not modify, source here: file:///placeholder
[Table("ShippingActivityTypes")]
public class txnShippingActivityTypeDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public txnShippingActivityMetricType Type { get; set; } = txnShippingActivityMetricType.Undefined;

	// Relationship to txnShippingActivityItem, Coposite
	public List<txnShippingActivityItemDbEntity> Items { get; set; } = new List<txnShippingActivityItemDbEntity>();

	// Navigation properties
	// Back reference for txnShippingActivity.TypeIds
	public Guid? ShippingActivityId { get; set; }
	[ForeignKey("ShippingActivityId")]
	public txnShippingActivityDbEntity ShippingActivity { get; set; }
	public int IndexInShippingActivity { get; set; }
}
// generated class, do not modify, source here: file:///placeholder
[Table("CargoReports")]
public class txnCargoReportDbRecord : IDbRecord
{
	public long Id { get; set; }
	public long TransactionId { get; set; } = 0;
	public Guid ShippingUnitId { get; set; } = Guid.Empty;
	public Nullable<Guid> InventoryItemId { get; set; } = null;
	public Nullable<Guid> ContainerId { get; set; } = null;
	public Nullable<Guid> TransportTypeId { get; set; } = null;
	public Nullable<Guid> PathwayId { get; set; } = null;
	public Nullable<Guid> StartNodeId { get; set; } = null;
	public Nullable<Guid> EndNodeId { get; set; } = null;
	public Nullable<Guid> ConsignmentId { get; set; } = null;
	public Nullable<Guid> ManifestId { get; set; } = null;
	public Guid OwnerId { get; set; } = Guid.Empty;
	public DateTime Date { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	string _MonthTerm = "";
	public string MonthTerm { get => _MonthTerm ?? ""; set => _MonthTerm = value; }
	public decimal Length { get; set; } = 0;
	public decimal Breadth { get; set; } = 0;
	public decimal Height { get; set; } = 0;
	public decimal Area { get; set; } = 0;
	public decimal Volume { get; set; } = 0;
	public decimal Weight { get; set; } = 0;
	public decimal TEU { get; set; } = 0;
	public bool NoAutoUpdate { get; set; } = false;
	public bool InTransit { get; set; } = false;
	public bool Rejected { get; set; } = false;
	public Nullable<Guid> CatalogueTypeId { get; set; } = null;
	public Nullable<Guid> ContainerTypeId { get; set; } = null;
	string _Configuration = "";
	public string Configuration { get => _Configuration ?? ""; set => _Configuration = value; }
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("SAPFeedbackItems")]
public class txnSAPFeedbackItemDbRecord : IDbRecord
{
	public long Id { get; set; }
	public long TransactionId { get; set; } = 0;
	public DateTime TransactionDate { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public Guid SupplierId { get; set; } = Guid.Empty;
	string _SupplierCode = "";
	public string SupplierCode { get => _SupplierCode ?? ""; set => _SupplierCode = value; }
	string _SupplierName = "";
	public string SupplierName { get => _SupplierName ?? ""; set => _SupplierName = value; }
	public Guid RequisitionOrderId { get; set; } = Guid.Empty;
	public Guid LineItemId { get; set; } = Guid.Empty;
	string _RequisitionOrder = "";
	public string RequisitionOrder { get => _RequisitionOrder ?? ""; set => _RequisitionOrder = value; }
	string _LineItem = "";
	public string LineItem { get => _LineItem ?? ""; set => _LineItem = value; }
	public decimal Qty { get; set; } = 0;
	string _UOM = "";
	public string UOM { get => _UOM ?? ""; set => _UOM = value; }
	public bool Receipted { get; set; } = false;
	public DateTime? DeliveryDate { get; set; } = null;
	string _DeliveryDetails = "";
	public string DeliveryDetails { get => _DeliveryDetails ?? ""; set => _DeliveryDetails = value; }
	public bool SAPAck { get; set; } = false;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("EntitySummaryReferences")]
public class txnEntitySummaryReferenceDbEntity : IDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	string _EntityType = "";
	public string EntityType { get => _EntityType ?? ""; set => _EntityType = value; }
	public Guid EntityId { get; set; } = Guid.Empty;
	public long Revision { get; set; } = 0;

	// Reference to txnEntitySummary
	public Guid SummaryId { get; set; }
	[ForeignKey("SummaryId")]
	public txnEntitySummaryDbEntity Summary { get; set; }

	// Navigation properties
	// Back relationship for txnReference.Entity
	[InverseProperty(nameof(txnReferenceDbEntity.Entity))]
	public List<txnReferenceDbEntity> References_Entity { get; set; } = new List<txnReferenceDbEntity>();
}
// generated class, do not modify, source here: file:///placeholder
[Table("SUPathwayDistributions")]
public class txnSUPathwayDistributionDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public Guid PathwayId { get; set; } = Guid.Empty;

	// Relationship to txnSUPathwayDistributionItem, Coposite
	public List<txnSUPathwayDistributionItemDbEntity> Items { get; set; } = new List<txnSUPathwayDistributionItemDbEntity>();

	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("ShippingActivities")]
public class txnShippingActivityDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Relationship to txnShippingActivityType, Coposite
	public List<txnShippingActivityTypeDbEntity> Types { get; set; } = new List<txnShippingActivityTypeDbEntity>();

	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("RevisionCounters")]
public class txnRevisionCounterDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public txnRevisionCounterType CounterType { get; set; } = txnRevisionCounterType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("InventoryItems")]
public class txnInventoryItemDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid InventoryItemId { get; set; } = Guid.Empty;
	public txnInventoryItemEventType Event { get; set; } = txnInventoryItemEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("Containers")]
public class txnContainerDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid ContainerId { get; set; } = Guid.Empty;
	public txnContainerEventType Event { get; set; } = txnContainerEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("ShippingUnits")]
public class txnShippingUnitDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid ShippingUnitId { get; set; } = Guid.Empty;
	public txnShippingUnitEventType Event { get; set; } = txnShippingUnitEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("Tasks")]
public class txnTaskDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid TaskId { get; set; } = Guid.Empty;
	public txnTaskEventType Event { get; set; } = txnTaskEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("Consignments")]
public class txnConsignmentDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid ConsignmentId { get; set; } = Guid.Empty;
	public txnConsignmentEventType Event { get; set; } = txnConsignmentEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("CargoRequests")]
public class txnCargoRequestDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid CargoRequestId { get; set; } = Guid.Empty;
	public txnCargoRequestEventType Event { get; set; } = txnCargoRequestEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("WorkItems")]
public class txnWorkItemDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid WorkItemId { get; set; } = Guid.Empty;
	public txnWorkItemEventType Event { get; set; } = txnWorkItemEventType.Undefined;
	// Navigation properties
}
// generated class, do not modify, source here: file:///placeholder
[Table("WorkOrders")]
public class txnWorkOrderDbEntity : ITopLevelDbEntity
{
	public Guid Id { get; set; } = Guid.NewGuid();
	public long Revision { get; set; } = 0;
	public bool IsSystem { get; set; } = false;
	public DateTime DateCreated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public DateTime DateUpdated { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;
	public long TransactionId { get; set; } = 0;
	public DateTime DateTime { get; set; } = EntityCreationContext.SQL.DateTime.UtcNow;

	// Reference to txnAuthIdentity
	public Guid IdentityId { get; set; }
	[ForeignKey("IdentityId")]
	public txnAuthIdentityDbEntity Identity { get; set; }

	public decimal Quantity { get; set; } = 0;

	// Reference to txnReference
	public Guid? StartReferenceId { get; set; }
	[ForeignKey("StartReferenceId")]
	public txnReferenceDbEntity StartReference { get; set; }


	// Reference to txnReference
	public Guid? EndReferenceId { get; set; }
	[ForeignKey("EndReferenceId")]
	public txnReferenceDbEntity EndReference { get; set; }


	// Relationship to txnReference, Coposite
	public List<txnReferenceDbEntity> References { get; set; } = new List<txnReferenceDbEntity>();


	// Reference to txnReference
	public Guid? ReceipentId { get; set; }
	[ForeignKey("ReceipentId")]
	public txnReferenceDbEntity Receipent { get; set; }

	string _Comments = "";
	public string Comments { get => _Comments ?? ""; set => _Comments = value; }
	public Guid WorkOrderId { get; set; } = Guid.Empty;
	public txnWorkOrderEventType Event { get; set; } = txnWorkOrderEventType.Undefined;
	// Navigation properties
}
}
#pragma warning restore CS0612 // Type or member is obsolete
#pragma warning restore CS0105 // Using directive appeared previously in this namespace
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning restore IDE0028 // Collection Initialization
#pragma warning restore IDE0017 // Object Initialization
#pragma warning restore IDE1006 // Naming Styles