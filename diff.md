## EF2

```sql
exec sp_executesql N'SELECT [c].[id], [c].[comments], [c].[date_created], [c].[date_time], [c].[date_updated], [c].[end_reference_id], [c].[event], [c].[identity_id], [c].[is_system], [c].[quantity], [c].[receipent_id], [c].[revision], [c].[shipping_unit_id], [c].[start_reference_id], [c].[transaction_id]
FROM [txn].[shipping_units] AS [c]
WHERE [c].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([c].[transaction_id] < @__batchId_1)
ORDER BY [c].[id]',N'@__batchId_1 bigint',@__batchId_1=200000

exec sp_executesql N'SELECT [c.References].[id], [c.References].[cargo_request_id], [c.References].[consignment_id], [c.References].[container_id], [c.References].[date_id], [c.References].[entity_id], [c.References].[index_in_cargo_request], [c.References].[index_in_consignment], [c.References].[index_in_container], [c.References].[index_in_inventory_item], [c.References].[index_in_shipping_unit], [c.References].[index_in_task], [c.References].[index_in_work_item], [c.References].[index_in_work_order], [c.References].[inventory_item_id], [c.References].[location_id], [c.References].[shipping_unit_id], [c.References].[task_id], [c.References].[text_id], [c.References].[work_item_id], [c.References].[work_order_id]
FROM [txn].[references] AS [c.References]
INNER JOIN (
    SELECT [c0].[id]
    FROM [txn].[shipping_units] AS [c0]
    WHERE [c0].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([c0].[transaction_id] < @__batchId_1)
) AS [t] ON [c.References].[shipping_unit_id] = [t].[id]
ORDER BY [t].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

## EF6 - Single Query
```sql
exec sp_executesql N'SELECT [s].[id], [s].[comments], [s].[date_created], [s].[date_time], [s].[date_updated], [s].[end_reference_id], [s].[event], [s].[identity_id], [s].[is_system], [s].[quantity], [s].[receipent_id], [s].[revision], [s].[shipping_unit_id], [s].[start_reference_id], [s].[transaction_id], [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[id] = [r].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''3b39873e-f8d2-49e8-a3fc-000711bd28f0'', ''694e3291-7833-4806-a4ba-000a782487d8'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

## EF6  - Split Qery
```sql
exec sp_executesql N'SELECT [s].[id], [s].[comments], [s].[date_created], [s].[date_time], [s].[date_updated], [s].[end_reference_id], [s].[event], [s].[identity_id], [s].[is_system], [s].[quantity], [s].[receipent_id], [s].[revision], [s].[shipping_unit_id], [s].[start_reference_id], [s].[transaction_id]
FROM [txn].[shipping_units] AS [s]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id]',N'@__batchId_1 bigint',@__batchId_1=200000

exec sp_executesql N'SELECT [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id], [s].[id]
FROM [txn].[shipping_units] AS [s]
INNER JOIN [txn].[references] AS [r] ON [s].[id] = [r].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```