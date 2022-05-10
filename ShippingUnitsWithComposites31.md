```sql
exec sp_executesql N'SELECT [s].[id], [s].[comments], [s].[date_created], [s].[date_time], [s].[date_updated], [s].[end_reference_id], [s].[event], [s].[identity_id], [s].[is_system], [s].[quantity], [s].[receipent_id], [s].[revision], [s].[shipping_unit_id], [s].[start_reference_id], [s].[transaction_id], 
[r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id], [d].[id], [d].[comments], [d].[date], [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id], [e0].[id], [e0].[basic], [e0].[detailed], [e0].[extended], [g].[id], [g].[geo_mismatch], [g].[spatial_id], [s0].[id], [s0].[geometry_id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [s4].[id], [s4].[elevation], [s4].[index_in_spatial], [s4].[latitude], [s4].[longitude], [s4].[spatial_id], [s4].[timestamp], [s1].[b], [s1].[h], [s1].[l], [t].[text], [a].[identity_json], [r0].[cargo_request_id], [r0].[consignment_id], [r0].[container_id], [r0].[date_id], [r0].[entity_id], [r0].[index_in_cargo_request], [r0].[index_in_consignment], [r0].[index_in_container], [r0].[index_in_inventory_item], [r0].[index_in_shipping_unit], [r0].[index_in_task], [r0].[index_in_work_item], [r0].[index_in_work_order], [r0].[inventory_item_id], [r0].[location_id], [r0].[shipping_unit_id], [r0].[task_id], [r0].[text_id], [r0].[work_item_id], [r0].[work_order_id], [d0].[comments], [d0].[date], [e1].[entity_id], [e1].[entity_type], [e1].[revision], [e1].[summary_id], [e2].[basic], [e2].[detailed], [e2].[extended], [g0].[geo_mismatch], [g0].[spatial_id], [s2].[geometry_id], [s5].[id], [s5].[elevation], [s5].[index_in_spatial], [s5].[latitude], [s5].[longitude], [s5].[spatial_id], [s5].[timestamp], [s3].[b], [s3].[h], [s3].[l], [t0].[text]


FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[date_references] AS [d] ON [r].[date_id] = [d].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
LEFT JOIN [txn].[entity_summaries] AS [e0] ON [e].[summary_id] = [e0].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s1] ON [s0].[geometry_id] = [s1].[id]
LEFT JOIN [txn].[text_references] AS [t] ON [r].[text_id] = [t].[id]
INNER JOIN [txn].[auth_identities] AS [a] ON [s].[identity_id] = [a].[id]
LEFT JOIN [txn].[references] AS [r0] ON [s].[receipent_id] = [r0].[id]
LEFT JOIN [txn].[date_references] AS [d0] ON [r0].[date_id] = [d0].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e1] ON [r0].[entity_id] = [e1].[id]
LEFT JOIN [txn].[entity_summaries] AS [e2] ON [e1].[summary_id] = [e2].[id]
LEFT JOIN [txn].[geo_location_references] AS [g0] ON [r0].[location_id] = [g0].[id]
LEFT JOIN [txn].[spatials] AS [s2] ON [g0].[spatial_id] = [s2].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s3] ON [s2].[geometry_id] = [s3].[id]
LEFT JOIN [txn].[text_references] AS [t0] ON [r0].[text_id] = [t0].[id]
LEFT JOIN [txn].[spatial_geographies] AS [s4] ON [s0].[id] = [s4].[spatial_id]
LEFT JOIN [txn].[spatial_geographies] AS [s5] ON [s2].[id] = [s5].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [s4].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```