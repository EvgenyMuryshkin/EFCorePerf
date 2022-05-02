using crosscutting.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace transactions
{
    public enum txnRevisionCounterType
    {
        Undefined,
        InventoryItem,
        ShippingUnit,
        Container,
        ShippingActivity,
        SUPathwayDistribution,
        Task,
        Consignment,
        CargoRequest,
        WorkItem,
        WorkOrder
    }

    public enum txnContainerEventType
    {
        Undefined,
        BroughtOn,
        OnOrder,
        Sourced,
        Unsourced,
        Packed,
        Unpacked,
        WrittenOff,
        SUCreated,
        SUBroken,
        OnHold,
        OffHold,
        Released,
        Receipted,
        Teleported,
        Accepted,
        Planned,
        StandUpRO,
        Shipped,
        Moved,
        Assigned,
        Transferred,
        Unloaded,
        Loaded,
        [Label(Value = "Split SKU")]
        Splited,
        GeoTag,
        [Label(Value = "End of Life")]
        EOL,
        Damaged,
        Repaired,
        [Label(Value = "ERDL In")]
        ERDLIn,
        [Label(Value = "ERDL Out")]
        ERDLOut,
        HotShotSet,
        HotShotReset,
        Relocated,
        Recalculated,
        Repacked,
        ROWithhold,
        Measured,
        BulkModified,
        TaskAdded,
        TaskRemoved,
        TaskStatusChanged,
        Deleted,
        [Label(Value = "End of Journey")]
        EOJ,
        Locked,
        Unlocked,
        CargoRequestApproved,
        CargoRequestCancelled,
        RetrospectiveFix,
        BucketCheck,
        BucketMerge,
        Demobilised,
        Resurrected,
        Notification,
        ActivityNote,
        Unreceipted,
        MarineTrafficIntegration
    }

    public enum txnInventoryItemEventType
    {
        Undefined,
        Planned,
        BroughtOn,
        OnOrder,
        Sourced,
        Unsourced,
        Moved,
        Shipped,
        Packed,
        Unpacked,
        Merged,
        [Label(Value = "Split SKU")]
        Splited,
        HandedOver,
        Installed,
        Commissioned,
        Issued,
        Returned,
        Used,
        Consumed,
        Disposed,
        SUCreated,
        SUBroken,
        Locked,
        Unlocked,
        Released,
        Fabricate,
        Receipted,
        Damaged,
        Repaired,
        Loaded,
        Unloaded,
        Expended,
        Assigned,
        Demobilized,
        Subdivided,
        Rebuilt,
        Teleported,
        Accepted,
        Parked,
        Rejected,
        Transferred,
        Relocated,
        [Label(Value = "End of Life")]
        EOL,
        GeoTag,
        StandUpRO,
        ProcurementCycle,
        [Label(Value = "HOTSHOT Set")]
        HotShotSetted,
        [Label(Value = "HOTSHOT Complete")]
        HotShotResetted,
        ROLIUpdated,
        Repacked,
        AjustedDD,
        EstimatedDD,
        ROWithhold,
        Kit,
        Measured,
        SetDD,
        BulkModified,
        Resurrected,
        TaskAdded,
        TaskRemoved,
        TaskStatusChanged,
        QtyAdjusted,
        Deleted,
        [Label(Value = "End of Journey")]
        EOJ,
        CargoRequestApproved,
        CargoRequestCancelled,
        RetrospectiveFix,
        WorkItemCreated,
        WorkItemPending,
        WorkItemInProgress,
        WorkItemCompleted,
        WorkItemAdded,
        WorkItemRemoved,
        WorkItemCancelled,
        WorkItemAllocated,
        WorkItemDeleted,
        WorkItemEstimated,
        WorkItemAdjusted,
        BucketCheck,
        BucketMerge,
        WorkOrderCancelled,
        WorkItemReopened,
        Notification,
        ActivityNote,
        Unreceipted
    }

    public enum txnShippingUnitEventType
    {
        Undefined,
        Created,
        Manifested,
        Unmanifested,
        Consigned,
        Unconsigned,
        Stowed,
        Moved,
        Departed,
        Arrived,
        Cleared,
        NotCleared,
        Loaded,
        Unloaded,
        [Label(Value = "SU Accepted")]
        Accepted,
        [Label(Value = "SU Parked")]
        Parked,
        [Label(Value = "SU Rejected")]
        Rejected,
        Broken,
        OnHold,// no support in TL yet
        OffHold,// no support in TL yet
        Receipt,// no support in TL yet
        MarkedForInspection,
        Teleported,
        Measured,
        Uncleared,
        [Label(Value = "Accepted")]
        TeleportAccepted,
        BulkModified,
        TaskAdded,
        TaskRemoved,
        TaskStatusChanged,
        Deleted,
        [Label(Value = "End of Journey")]
        EOJ,
        [Label(Value = "Set RFD Date")]
        SetRFDDate,
        [Label(Value = "Adjust AFD Date")]
        AdjustAFDDate,
        Locked,
        Unlocked,
        HotShotSet,
        HotShotReset,
        Unstowed,
        Forwarded,
        CargoRequestApproved,
        CargoRequestCancelled,
        Backtracked,
        RetrospectiveFix,
        Finalised,
        ActivityNote,
        Updated,
        Notification
    }

    public enum txnSUPathwayDistributionState
    {
        Undefined,
        Planned,
        InTransit,
        Arrived
    }

    public enum txnShippingActivityMetricType
    {
        Undefined,
        Consignment,
        Manifest,
        Teleport
    }

    public enum txnShippingActivityMetricState
    {
        Undefined,
        Planned = 10,
        InTransit = 20,
        Completed = 30
    }

    public enum txnTaskEventType
    {
        Undefined,
        Created,
        Updated,
        Allocated,
        Passed,
        Accepted,
        ForReview,
        SignedOff,
        Cancelled,
        Commented,
        ItemAdded,
        ItemRemoved,
        ItemStatusChanged,
        Reopened,
        Withheld,
        Deleted,
        BulkModified,
        RetrospectiveFix,
        Notification,
        ActivityNote
    }

    public enum txnConsignmentEventType
    {
        Undefined,
        Created,
        Updated,
        Provisioned,
        Finalized,
        Departed,
        Arrived,
        Completed,
        Cancelled,
        DepartureDateSet,
        ArrivalDateSet,
        SUAdded,
        SURemoved,
        SUInspected,
        Deleted,
        [Label(Value = "End of Journey")]
        EOJ,
        Rerouted,
        ActivityNote,
        DocumentUploaded,
        ImageUploaded,
        Backtracked,
        BulkModified,
        RetrospectiveFix,
        Notification,
        UpdateETA,
        FastTrack,
        MarineTrafficIntegration
    }

    public enum txnCargoRequestEventType
    {
        Undefined,
        Created,
        Updated,
        Reassigned,
        LocationsSet,
        Approved,
        Completed,
        Denied,
        Cancelled,
        OriginatorChanged,
        Resubmitted,
        CancelApproved,
        BulkModified,
        RetrospectiveFix,
        Submitted,
        Withheld,
        Notification,
        ActivityNote
    }

    public enum txnWorkItemEventType
    {
        Undefined,
        Created,
        Updated,
        Notification,
        Pending,
        InProgress,
        Completed,
        Cancelled,
        Reopened,
        Allocated,
        Estimated,
        Adjusted,
        InventoryAdded,
        InventoryRemoved,
        ActivityNote,
        Unsourced
    }

    public enum txnWorkOrderEventType
    {
        Undefined,
        Created,
        Updated,
        Notification,
        Pending,
        InProgress,
        Completed,
        Cancelled,
        Reopened,
        Adjusted,
        Reassigned,
        OriginatorChanged,
        WorkItemAdded,
        WorkItemRemoved,
        ActivityNote
    }
}
