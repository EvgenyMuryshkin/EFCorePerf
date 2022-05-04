# EF Core migration issue (EF2 => EF6)

Experiencing major performance degradation on production database with lots of data in tables.
Overall perf impact after upgrade is from 2x to occasional 100x

## Test machine spec
* Windows 10 Pro, 64-bit operating system, x64-based processor
* Intel(R) Core(TM) i7-9700 CPU @ 3.00GHz   3.00 GHz
* 32.0 GB
* Microsoft SQL Server Developer (64-bit) 15.0.2000.5

## Test Summary

EF2CorePerfTests (10 sec) vs EF6CorePerfTests (50 sec)

![Test Summary](https://github.com/EvgenyMuryshkin/EFCorePerf/blob/main/img/summary.png)

## Benchmark.NET

**EF2**

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)

Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores

.NET SDK=6.0.202

  [Host]     : .NET Core 3.1.24 (CoreCLR 4.700.22.16002, CoreFX 4.700.22.17909), X64 RyuJIT
  
  DefaultJob : .NET Core 3.1.24 (CoreCLR 4.700.22.16002, CoreFX 4.700.22.17909), X64 RyuJIT


|                            Method | Idx |     Mean |    Error |   StdDev |
|---------------------------------- |---- |---------:|---------:|---------:|
| Default_Existing_ByShippingUnitId |   0 | 12.28 ms | 0.063 ms | 0.049 ms |
|  Default_Missing_ByShippingUnitId |   0 | 53.38 ms | 0.571 ms | 0.534 ms |
| Default_Existing_ByShippingUnitId |   1 | 11.02 ms | 0.051 ms | 0.042 ms |
|  Default_Missing_ByShippingUnitId |   1 | 53.30 ms | 0.627 ms | 0.586 ms |
| Default_Existing_ByShippingUnitId |   2 | 11.05 ms | 0.216 ms | 0.222 ms |
|  Default_Missing_ByShippingUnitId |   2 | 53.37 ms | 0.800 ms | 0.749 ms |
| Default_Existing_ByShippingUnitId |   3 | 15.28 ms | 0.074 ms | 0.070 ms |
|  Default_Missing_ByShippingUnitId |   3 | 53.66 ms | 0.723 ms | 0.676 ms |
| Default_Existing_ByShippingUnitId |   4 | 14.55 ms | 0.037 ms | 0.029 ms |
|  Default_Missing_ByShippingUnitId |   4 | 55.72 ms | 1.103 ms | 2.203 ms |

**EF6**

// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1645 (21H2)

Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores

.NET SDK=6.0.202

  [Host]     : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  
  DefaultJob : .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
  
|                            Method | Idx |      Mean |    Error |    StdDev |    Median |
|---------------------------------- |---- |----------:|---------:|----------:|----------:|
| Default_Existing_ByShippingUnitId |   0 |  50.05 ms | 0.808 ms |  0.993 ms |  49.61 ms |
|  Default_Missing_ByShippingUnitId |   0 | 402.18 ms | 8.005 ms | 20.375 ms | 397.92 ms |
| Default_Existing_ByShippingUnitId |   1 |  44.47 ms | 0.240 ms |  0.213 ms |  44.46 ms |
|  Default_Missing_ByShippingUnitId |   1 | 405.74 ms | 8.101 ms | 17.783 ms | 401.35 ms |
| Default_Existing_ByShippingUnitId |   2 |  55.78 ms | 1.095 ms |  1.261 ms |  56.12 ms |
|  Default_Missing_ByShippingUnitId |   2 | 403.93 ms | 8.002 ms | 18.226 ms | 397.08 ms |
| Default_Existing_ByShippingUnitId |   3 |  47.12 ms | 0.312 ms |  0.261 ms |  47.19 ms |
|  Default_Missing_ByShippingUnitId |   3 | 397.28 ms | 7.149 ms | 11.544 ms | 395.65 ms |
| Default_Existing_ByShippingUnitId |   4 |  54.75 ms | 0.593 ms |  0.555 ms |  54.78 ms |
|  Default_Missing_ByShippingUnitId |   4 | 402.92 ms | 8.058 ms | 17.172 ms | 396.61 ms |

## Multipart backup download links
Download multipart archive (5 Gb backup), extract into single backup file 'efperftest'

https://drive.google.com/drive/folders/1WgKX1SelapG1Iqa1XVCjGA2SMlk-_xZE?usp=sharing

## Database setup
* Create database efperftest
* Create login test/test and give it permission to database
* Restore database from backup
* Run EF2CorePerfTest (10 seconds duration)
* Run EF6CorePerfTest (50 seconds duration)
* Auxiliary test scenarios EF6CorePerfTests_AsSplitQuery (13 minutes duration)
* Auxiliary test scenarios EF6CorePerfTests_FPlusOptimized (50 seconds duration)

## Generated SQL differences

### EF2 generated SQL query, which works fast

**No nested select statement in first query**, query works fast when run with different query parameters (about 50ms per query)

```sql
exec sp_executesql N'SELECT [c].[id], [c].[comments], [c].[date_created], [c].[date_time], [c].[date_updated], [c].[end_reference_id], [c].[event], [c].[identity_id], [c].[is_system], [c].[quantity], [c].[receipent_id], [c].[revision], [c].[shipping_unit_id], [c].[start_reference_id], [c].[transaction_id], [c.StartReference].[id], [c.StartReference].[cargo_request_id], [c.StartReference].[consignment_id], [c.StartReference].[container_id], [c.StartReference].[date_id], [c.StartReference].[entity_id], [c.StartReference].[index_in_cargo_request], [c.StartReference].[index_in_consignment], [c.StartReference].[index_in_container], [c.StartReference].[index_in_inventory_item], [c.StartReference].[index_in_shipping_unit], [c.StartReference].[index_in_task], [c.StartReference].[index_in_work_item], [c.StartReference].[index_in_work_order], [c.StartReference].[inventory_item_id], [c.StartReference].[location_id], [c.StartReference].[shipping_unit_id], [c.StartReference].[task_id], [c.StartReference].[text_id], [c.StartReference].[work_item_id], [c.StartReference].[work_order_id], [c.StartReference.Date].[id], [c.StartReference.Date].[comments], [c.StartReference.Date].[date], [c.StartReference.Entity].[id], [c.StartReference.Entity].[entity_id], [c.StartReference.Entity].[entity_type], [c.StartReference.Entity].[revision], [c.StartReference.Entity].[summary_id], [c.StartReference.Entity.Summary].[id], [c.StartReference.Entity.Summary].[basic], 
[c.StartReference.Entity.Summary].[detailed], [c.StartReference.Entity.Summary].[extended], [c.StartReference.Location].[id], [c.StartReference.Location].[geo_mismatch], [c.StartReference.Location].[spatial_id], [c.StartReference.Location.Spatial].[id], [c.StartReference.Location.Spatial].[geometry_id], 
[c.StartReference.Location.Spatial.Geometry].[id], [c.StartReference.Location.Spatial.Geometry].[b], [c.StartReference.Location.Spatial.Geometry].[h], [c.StartReference.Location.Spatial.Geometry].[l], [c.StartReference.Text].[id], [c.StartReference.Text].[text], [c.Receipent].[id], 
[c.Receipent].[cargo_request_id], [c.Receipent].[consignment_id], [c.Receipent].[container_id], [c.Receipent].[date_id], [c.Receipent].[entity_id], [c.Receipent].[index_in_cargo_request], [c.Receipent].[index_in_consignment], [c.Receipent].[index_in_container], [c.Receipent].[index_in_inventory_item], 
[c.Receipent].[index_in_shipping_unit], [c.Receipent].[index_in_task], [c.Receipent].[index_in_work_item], [c.Receipent].[index_in_work_order], [c.Receipent].[inventory_item_id], [c.Receipent].[location_id], [c.Receipent].[shipping_unit_id], [c.Receipent].[task_id], [c.Receipent].[text_id], 
[c.Receipent].[work_item_id], [c.Receipent].[work_order_id], [c.Receipent.Date].[id], [c.Receipent.Date].[comments], [c.Receipent.Date].[date], [c.Receipent.Entity].[id], [c.Receipent.Entity].[entity_id], [c.Receipent.Entity].[entity_type], [c.Receipent.Entity].[revision], [c.Receipent.Entity].[summary_id], 
[c.Receipent.Entity.Summary].[id], [c.Receipent.Entity.Summary].[basic], [c.Receipent.Entity.Summary].[detailed], [c.Receipent.Entity.Summary].[extended], [c.Receipent.Location].[id], [c.Receipent.Location].[geo_mismatch], [c.Receipent.Location].[spatial_id], [c.Receipent.Location.Spatial].[id], 
[c.Receipent.Location.Spatial].[geometry_id], [c.Receipent.Location.Spatial.Geometry].[id], [c.Receipent.Location.Spatial.Geometry].[b], [c.Receipent.Location.Spatial.Geometry].[h], [c.Receipent.Location.Spatial.Geometry].[l], [c.Receipent.Text].[id], [c.Receipent.Text].[text], [c.Identity].[id], [c.Identity].[identity_json], [c.EndReference].[id], [c.EndReference].[cargo_request_id], [c.EndReference].[consignment_id], [c.EndReference].[container_id], [c.EndReference].[date_id], [c.EndReference].[entity_id], [c.EndReference].[index_in_cargo_request], [c.EndReference].[index_in_consignment], [c.EndReference].[index_in_container], [c.EndReference].[index_in_inventory_item], [c.EndReference].[index_in_shipping_unit], [c.EndReference].[index_in_task], [c.EndReference].[index_in_work_item], [c.EndReference].[index_in_work_order], [c.EndReference].[inventory_item_id], [c.EndReference].[location_id], [c.EndReference].[shipping_unit_id], [c.EndReference].[task_id], [c.EndReference].[text_id], [c.EndReference].[work_item_id], [c.EndReference].[work_order_id], [c.EndReference.Date].[id], [c.EndReference.Date].[comments], [c.EndReference.Date].[date], [c.EndReference.Entity].[id], [c.EndReference.Entity].[entity_id], [c.EndReference.Entity].[entity_type], [c.EndReference.Entity].[revision], [c.EndReference.Entity].[summary_id], [c.EndReference.Entity.Summary].[id], [c.EndReference.Entity.Summary].[basic], [c.EndReference.Entity.Summary].[detailed], [c.EndReference.Entity.Summary].[extended], [c.EndReference.Location].[id], [c.EndReference.Location].[geo_mismatch], [c.EndReference.Location].[spatial_id], [c.EndReference.Location.Spatial].[id], [c.EndReference.Location.Spatial].[geometry_id], [c.EndReference.Location.Spatial.Geometry].[id], [c.EndReference.Location.Spatial.Geometry].[b], [c.EndReference.Location.Spatial.Geometry].[h], [c.EndReference.Location.Spatial.Geometry].[l], [c.EndReference.Text].[id], [c.EndReference.Text].[text]
FROM [txn].[shipping_units] AS [c]
LEFT JOIN [txn].[references] AS [c.StartReference] ON [c].[start_reference_id] = [c.StartReference].[id]
LEFT JOIN [txn].[date_references] AS [c.StartReference.Date] ON [c.StartReference].[date_id] = [c.StartReference.Date].[id]
LEFT JOIN [txn].[entity_summary_references] AS [c.StartReference.Entity] ON [c.StartReference].[entity_id] = [c.StartReference.Entity].[id]
LEFT JOIN [txn].[entity_summaries] AS [c.StartReference.Entity.Summary] ON [c.StartReference.Entity].[summary_id] = [c.StartReference.Entity.Summary].[id]
LEFT JOIN [txn].[geo_location_references] AS [c.StartReference.Location] ON [c.StartReference].[location_id] = [c.StartReference.Location].[id]
LEFT JOIN [txn].[spatials] AS [c.StartReference.Location.Spatial] ON [c.StartReference.Location].[spatial_id] = [c.StartReference.Location.Spatial].[id]
LEFT JOIN [txn].[spatial_geometries] AS [c.StartReference.Location.Spatial.Geometry] ON [c.StartReference.Location.Spatial].[geometry_id] = [c.StartReference.Location.Spatial.Geometry].[id]
LEFT JOIN [txn].[text_references] AS [c.StartReference.Text] ON [c.StartReference].[text_id] = [c.StartReference.Text].[id]
LEFT JOIN [txn].[references] AS [c.Receipent] ON [c].[receipent_id] = [c.Receipent].[id]
LEFT JOIN [txn].[date_references] AS [c.Receipent.Date] ON [c.Receipent].[date_id] = [c.Receipent.Date].[id]
LEFT JOIN [txn].[entity_summary_references] AS [c.Receipent.Entity] ON [c.Receipent].[entity_id] = [c.Receipent.Entity].[id]
LEFT JOIN [txn].[entity_summaries] AS [c.Receipent.Entity.Summary] ON [c.Receipent.Entity].[summary_id] = [c.Receipent.Entity.Summary].[id]
LEFT JOIN [txn].[geo_location_references] AS [c.Receipent.Location] ON [c.Receipent].[location_id] = [c.Receipent.Location].[id]
LEFT JOIN [txn].[spatials] AS [c.Receipent.Location.Spatial] ON [c.Receipent.Location].[spatial_id] = [c.Receipent.Location.Spatial].[id]
LEFT JOIN [txn].[spatial_geometries] AS [c.Receipent.Location.Spatial.Geometry] ON [c.Receipent.Location.Spatial].[geometry_id] = [c.Receipent.Location.Spatial.Geometry].[id]
LEFT JOIN [txn].[text_references] AS [c.Receipent.Text] ON [c.Receipent].[text_id] = [c.Receipent.Text].[id]
INNER JOIN [txn].[auth_identities] AS [c.Identity] ON [c].[identity_id] = [c.Identity].[id]
LEFT JOIN [txn].[references] AS [c.EndReference] ON [c].[end_reference_id] = [c.EndReference].[id]
LEFT JOIN [txn].[date_references] AS [c.EndReference.Date] ON [c.EndReference].[date_id] = [c.EndReference.Date].[id]
LEFT JOIN [txn].[entity_summary_references] AS [c.EndReference.Entity] ON [c.EndReference].[entity_id] = [c.EndReference.Entity].[id]
LEFT JOIN [txn].[entity_summaries] AS [c.EndReference.Entity.Summary] ON [c.EndReference.Entity].[summary_id] = [c.EndReference.Entity.Summary].[id]
LEFT JOIN [txn].[geo_location_references] AS [c.EndReference.Location] ON [c.EndReference].[location_id] = [c.EndReference.Location].[id]
LEFT JOIN [txn].[spatials] AS [c.EndReference.Location.Spatial] ON [c.EndReference.Location].[spatial_id] = [c.EndReference.Location.Spatial].[id]
LEFT JOIN [txn].[spatial_geometries] AS [c.EndReference.Location.Spatial.Geometry] ON [c.EndReference.Location.Spatial].[geometry_id] = [c.EndReference.Location.Spatial.Geometry].[id]
LEFT JOIN [txn].[text_references] AS [c.EndReference.Text] ON [c.EndReference].[text_id] = [c.EndReference.Text].[id]
WHERE [c].[shipping_unit_id] IN (''1bc4529a-932c-4590-aeea-000f5221773d'', ''95d24784-64eb-42df-9fa6-001054d63865'') AND ([c].[transaction_id] < @__batchId_1)
ORDER BY [c.EndReference.Location.Spatial].[id], [c.Receipent.Location.Spatial].[id], [c].[id], [c.StartReference.Location.Spatial].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

```sql
exec sp_executesql N'SELECT [c.References].[id], [c.References].[cargo_request_id], [c.References].[consignment_id], [c.References].[container_id], [c.References].[date_id], [c.References].[entity_id], [c.References].[index_in_cargo_request], [c.References].[index_in_consignment], [c.References].[index_in_container], [c.References].[index_in_inventory_item], [c.References].[index_in_shipping_unit], [c.References].[index_in_task], [c.References].[index_in_work_item], [c.References].[index_in_work_order], [c.References].[inventory_item_id], [c.References].[location_id], [c.References].[shipping_unit_id], [c.References].[task_id], [c.References].[text_id], [c.References].[work_item_id], [c.References].[work_order_id], [t.Text].[id], [t.Text].[text], [t.Location].[id], [t.Location].[geo_mismatch], [t.Location].[spatial_id], [t.Location.Spatial].[id], [t.Location.Spatial].[geometry_id], [t.Location.Spatial.Geometry].[id], [t.Location.Spatial.Geometry].[b], [t.Location.Spatial.Geometry].[h], [t.Location.Spatial.Geometry].[l], [t.Entity].[id], [t.Entity].[entity_id], [t.Entity].[entity_type], [t.Entity].[revision], [t.Entity].[summary_id], [t.Entity.Summary].[id], [t.Entity.Summary].[basic], [t.Entity.Summary].[detailed], [t.Entity.Summary].[extended], [t.Date].[id], [t.Date].[comments], [t.Date].[date]
FROM [txn].[references] AS [c.References]
LEFT JOIN [txn].[text_references] AS [t.Text] ON [c.References].[text_id] = [t.Text].[id]
LEFT JOIN [txn].[geo_location_references] AS [t.Location] ON [c.References].[location_id] = [t.Location].[id]
LEFT JOIN [txn].[spatials] AS [t.Location.Spatial] ON [t.Location].[spatial_id] = [t.Location.Spatial].[id]
LEFT JOIN [txn].[spatial_geometries] AS [t.Location.Spatial.Geometry] ON [t.Location.Spatial].[geometry_id] = [t.Location.Spatial.Geometry].[id]
LEFT JOIN [txn].[entity_summary_references] AS [t.Entity] ON [c.References].[entity_id] = [t.Entity].[id]
LEFT JOIN [txn].[entity_summaries] AS [t.Entity.Summary] ON [t.Entity].[summary_id] = [t.Entity.Summary].[id]
LEFT JOIN [txn].[date_references] AS [t.Date] ON [c.References].[date_id] = [t.Date].[id]
INNER JOIN (
    SELECT DISTINCT [c2].[id], [c.EndReference.Location.Spatial2].[id] AS [id0], [c.Receipent.Location.Spatial2].[id] AS [id1]
    FROM [txn].[shipping_units] AS [c2]
    LEFT JOIN [txn].[references] AS [c.StartReference2] ON [c2].[start_reference_id] = [c.StartReference2].[id]
    LEFT JOIN [txn].[date_references] AS [c.StartReference.Date2] ON [c.StartReference2].[date_id] = [c.StartReference.Date2].[id]
    LEFT JOIN [txn].[entity_summary_references] AS [c.StartReference.Entity2] ON [c.StartReference2].[entity_id] = [c.StartReference.Entity2].[id]
    LEFT JOIN [txn].[entity_summaries] AS [c.StartReference.Entity.Summary2] ON [c.StartReference.Entity2].[summary_id] = [c.StartReference.Entity.Summary2].[id]
    LEFT JOIN [txn].[geo_location_references] AS [c.StartReference.Location2] ON [c.StartReference2].[location_id] = [c.StartReference.Location2].[id]
    LEFT JOIN [txn].[spatials] AS [c.StartReference.Location.Spatial2] ON [c.StartReference.Location2].[spatial_id] = [c.StartReference.Location.Spatial2].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [c.StartReference.Location.Spatial.Geometry2] ON [c.StartReference.Location.Spatial2].[geometry_id] = [c.StartReference.Location.Spatial.Geometry2].[id]
    LEFT JOIN [txn].[text_references] AS [c.StartReference.Text2] ON [c.StartReference2].[text_id] = [c.StartReference.Text2].[id]
    LEFT JOIN [txn].[references] AS [c.Receipent2] ON [c2].[receipent_id] = [c.Receipent2].[id]
    LEFT JOIN [txn].[date_references] AS [c.Receipent.Date2] ON [c.Receipent2].[date_id] = [c.Receipent.Date2].[id]
    LEFT JOIN [txn].[entity_summary_references] AS [c.Receipent.Entity2] ON [c.Receipent2].[entity_id] = [c.Receipent.Entity2].[id]
    LEFT JOIN [txn].[entity_summaries] AS [c.Receipent.Entity.Summary2] ON [c.Receipent.Entity2].[summary_id] = [c.Receipent.Entity.Summary2].[id]
    LEFT JOIN [txn].[geo_location_references] AS [c.Receipent.Location2] ON [c.Receipent2].[location_id] = [c.Receipent.Location2].[id]
    LEFT JOIN [txn].[spatials] AS [c.Receipent.Location.Spatial2] ON [c.Receipent.Location2].[spatial_id] = [c.Receipent.Location.Spatial2].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [c.Receipent.Location.Spatial.Geometry2] ON [c.Receipent.Location.Spatial2].[geometry_id] = [c.Receipent.Location.Spatial.Geometry2].[id]
    LEFT JOIN [txn].[text_references] AS [c.Receipent.Text2] ON [c.Receipent2].[text_id] = [c.Receipent.Text2].[id]
    INNER JOIN [txn].[auth_identities] AS [c.Identity2] ON [c2].[identity_id] = [c.Identity2].[id]
    LEFT JOIN [txn].[references] AS [c.EndReference2] ON [c2].[end_reference_id] = [c.EndReference2].[id]
    LEFT JOIN [txn].[date_references] AS [c.EndReference.Date2] ON [c.EndReference2].[date_id] = [c.EndReference.Date2].[id]
    LEFT JOIN [txn].[entity_summary_references] AS [c.EndReference.Entity2] ON [c.EndReference2].[entity_id] = [c.EndReference.Entity2].[id]
    LEFT JOIN [txn].[entity_summaries] AS [c.EndReference.Entity.Summary2] ON [c.EndReference.Entity2].[summary_id] = [c.EndReference.Entity.Summary2].[id]
    LEFT JOIN [txn].[geo_location_references] AS [c.EndReference.Location2] ON [c.EndReference2].[location_id] = [c.EndReference.Location2].[id]
    LEFT JOIN [txn].[spatials] AS [c.EndReference.Location.Spatial2] ON [c.EndReference.Location2].[spatial_id] = [c.EndReference.Location.Spatial2].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [c.EndReference.Location.Spatial.Geometry2] ON [c.EndReference.Location.Spatial2].[geometry_id] = [c.EndReference.Location.Spatial.Geometry2].[id]
    LEFT JOIN [txn].[text_references] AS [c.EndReference.Text2] ON [c.EndReference2].[text_id] = [c.EndReference.Text2].[id]
    WHERE [c2].[shipping_unit_id] IN (''1bc4529a-932c-4590-aeea-000f5221773d'', ''95d24784-64eb-42df-9fa6-001054d63865'') AND ([c2].[transaction_id] < @__batchId_1)
) AS [t1] ON [c.References].[shipping_unit_id] = [t1].[id]
ORDER BY [t1].[id0], [t1].[id1], [t1].[id], [t.Location.Spatial].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

### EF6 generated SQL query, which works slow

**Nested select statement** in single query, query works slow when run with different query parameters (about 500ms per query), works fast for the same query parameters (about 50ms)

```sql
exec sp_executesql N'SELECT [s].[id], [s].[comments], [s].[date_created], [s].[date_time], [s].[date_updated], [s].[end_reference_id], [s].[event], [s].[identity_id], [s].[is_system], [s].[quantity], [s].[receipent_id], [s].[revision], [s].[shipping_unit_id], [s].[start_reference_id], [s].[transaction_id], [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], 
[r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id], [d].[id], [d].[comments], [d].[date], [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id], [e0].[id], [e0].[basic], 
[e0].[detailed], [e0].[extended], [g].[id], [g].[geo_mismatch], [g].[spatial_id], [s0].[id], [s0].[geometry_id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], 
[t1].[id], [s6].[id], [s6].[elevation], [s6].[index_in_spatial], [s6].[latitude], [s6].[longitude], [s6].[spatial_id], [s6].[timestamp], [s1].[b], [s1].[h], [s1].[l], [t].[text], [a].[identity_json], [r0].[cargo_request_id], [r0].[consignment_id], [r0].[container_id], [r0].[date_id], [r0].[entity_id], 
[r0].[index_in_cargo_request], [r0].[index_in_consignment], [r0].[index_in_container], [r0].[index_in_inventory_item], [r0].[index_in_shipping_unit], [r0].[index_in_task], [r0].[index_in_work_item], [r0].[index_in_work_order], [r0].[inventory_item_id], [r0].[location_id], [r0].[shipping_unit_id], 
[r0].[task_id], [r0].[text_id], [r0].[work_item_id], [r0].[work_order_id], [d0].[comments], [d0].[date], [e1].[entity_id], [e1].[entity_type], [e1].[revision], [e1].[summary_id], [e2].[basic], [e2].[detailed], [e2].[extended], [g0].[geo_mismatch], [g0].[spatial_id], [s2].[geometry_id], [s7].[id], 
[s7].[elevation], [s7].[index_in_spatial], [s7].[latitude], [s7].[longitude], [s7].[spatial_id], [s7].[timestamp], [s3].[b], [s3].[h], [s3].[l], [t0].[text], [t2].[id], [t2].[cargo_request_id], [t2].[consignment_id], [t2].[container_id], [t2].[date_id], [t2].[entity_id], [t2].[index_in_cargo_request], [t2].[index_in_consignment], [t2].[index_in_container], [t2].[index_in_inventory_item], [t2].[index_in_shipping_unit], [t2].[index_in_task], [t2].[index_in_work_item], [t2].[index_in_work_order], [t2].[inventory_item_id], [t2].[location_id], [t2].[shipping_unit_id], [t2].[task_id], [t2].[text_id], [t2].[work_item_id], [t2].[work_order_id], [t2].[id0], [t2].[comments], [t2].[date], [t2].[id1], [t2].[entity_id0], [t2].[entity_type], [t2].[revision], [t2].[summary_id], [t2].[id2], [t2].[basic], [t2].[detailed], [t2].[extended], [t2].[id3], [t2].[geo_mismatch], [t2].[spatial_id], [t2].[id4], [t2].[geometry_id], [t2].[id5], [t2].[id6], [t2].[id7], [t2].[elevation], [t2].[index_in_spatial], [t2].[latitude], [t2].[longitude], [t2].[spatial_id0], [t2].[timestamp], [t2].[b], [t2].[h], [t2].[l], [t2].[text], [r1].[cargo_request_id], [r1].[consignment_id], [r1].[container_id], [r1].[date_id], [r1].[entity_id], [r1].[index_in_cargo_request], [r1].[index_in_consignment], [r1].[index_in_container], [r1].[index_in_inventory_item], [r1].[index_in_shipping_unit], [r1].[index_in_task], [r1].[index_in_work_item], [r1].[index_in_work_order], [r1].[inventory_item_id], [r1].[location_id], [r1].[shipping_unit_id], [r1].[task_id], [r1].[text_id], [r1].[work_item_id], [r1].[work_order_id], [d1].[comments], [d1].[date], [e3].[entity_id], [e3].[entity_type], [e3].[revision], [e3].[summary_id], [e4].[basic], [e4].[detailed], [e4].[extended], [g1].[geo_mismatch], [g1].[spatial_id], [s4].[geometry_id], [s11].[id], [s11].[elevation], [s11].[index_in_spatial], [s11].[latitude], [s11].[longitude], [s11].[spatial_id], [s11].[timestamp], [s5].[b], [s5].[h], [s5].[l], [t1].[text]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
LEFT JOIN [txn].[spatial_geographies] AS [s6] ON [s0].[id] = [s6].[spatial_id]
LEFT JOIN [txn].[spatial_geographies] AS [s7] ON [s2].[id] = [s7].[spatial_id]
LEFT JOIN (
    SELECT [r2].[id], [r2].[cargo_request_id], [r2].[consignment_id], [r2].[container_id], [r2].[date_id], [r2].[entity_id], [r2].[index_in_cargo_request], [r2].[index_in_consignment], [r2].[index_in_container], [r2].[index_in_inventory_item], [r2].[index_in_shipping_unit], [r2].[index_in_task], [r2].[index_in_work_item], [r2].[index_in_work_order], [r2].[inventory_item_id], [r2].[location_id], [r2].[shipping_unit_id], [r2].[task_id], [r2].[text_id], [r2].[work_item_id], [r2].[work_order_id], [d2].[id] AS [id0], [d2].[comments], [d2].[date], [e5].[id] AS [id1], [e5].[entity_id] AS [entity_id0], [e5].[entity_type], [e5].[revision], [e5].[summary_id], [e6].[id] AS [id2], [e6].[basic], [e6].[detailed], [e6].[extended], [g2].[id] AS [id3], [g2].[geo_mismatch], [g2].[spatial_id], [s8].[id] AS [id4], [s8].[geometry_id], [s9].[id] AS [id5], [t3].[id] AS [id6], [s10].[id] AS [id7], [s10].[elevation], [s10].[index_in_spatial], [s10].[latitude], [s10].[longitude], [s10].[spatial_id] AS [spatial_id0], [s10].[timestamp], [s9].[b], [s9].[h], [s9].[l], [t3].[text]
    FROM [txn].[references] AS [r2]
    LEFT JOIN [txn].[date_references] AS [d2] ON [r2].[date_id] = [d2].[id]
    LEFT JOIN [txn].[entity_summary_references] AS [e5] ON [r2].[entity_id] = [e5].[id]
    LEFT JOIN [txn].[entity_summaries] AS [e6] ON [e5].[summary_id] = [e6].[id]
    LEFT JOIN [txn].[geo_location_references] AS [g2] ON [r2].[location_id] = [g2].[id]
    LEFT JOIN [txn].[spatials] AS [s8] ON [g2].[spatial_id] = [s8].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [s9] ON [s8].[geometry_id] = [s9].[id]
    LEFT JOIN [txn].[text_references] AS [t3] ON [r2].[text_id] = [t3].[id]
    LEFT JOIN [txn].[spatial_geographies] AS [s10] ON [s8].[id] = [s10].[spatial_id]
) AS [t2] ON [s].[id] = [t2].[shipping_unit_id]
LEFT JOIN [txn].[spatial_geographies] AS [s11] ON [s4].[id] = [s11].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id], [s6].[id], [s7].[id], [t2].[id], [t2].[id0], [t2].[id1], [t2].[id2], [t2].[id3], [t2].[id4], [t2].[id5], [t2].[id6], [t2].[id7]',N'@__batchId_1 bigint',@__batchId_1=200000
```

### EF6 with split query, which snailed along

First set of queries are fast and do not have nested select
Subsequent query with nested select is stalling data fetch

```sql
exec sp_executesql N'SELECT [s].[id], [s].[comments], [s].[date_created], [s].[date_time], [s].[date_updated], [s].[end_reference_id], [s].[event], [s].[identity_id], [s].[is_system], [s].[quantity], [s].[receipent_id], [s].[revision], 
[s].[shipping_unit_id], [s].[start_reference_id], [s].[transaction_id], [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], 
[r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], 
[r].[text_id], [r].[work_item_id], [r].[work_order_id], [d].[id], [d].[comments], [d].[date], [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id], [e0].[id], [e0].[basic], [e0].[detailed], [e0].[extended], [g].[id], 
[g].[geo_mismatch], [g].[spatial_id], [s0].[id], [s0].[geometry_id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id], [s1].[b], [s1].[h], [s1].[l], [t].[text], [a].[identity_json], [r0].[cargo_request_id], [r0].[consignment_id], [r0].[container_id], [r0].[date_id], [r0].[entity_id], [r0].[index_in_cargo_request], [r0].[index_in_consignment], [r0].[index_in_container], [r0].[index_in_inventory_item], [r0].[index_in_shipping_unit], [r0].[index_in_task], [r0].[index_in_work_item], [r0].[index_in_work_order], [r0].[inventory_item_id], [r0].[location_id], [r0].[shipping_unit_id], [r0].[task_id], [r0].[text_id], [r0].[work_item_id], [r0].[work_order_id], [d0].[comments], [d0].[date], [e1].[entity_id], [e1].[entity_type], [e1].[revision], [e1].[summary_id], [e2].[basic], [e2].[detailed], [e2].[extended], [g0].[geo_mismatch], [g0].[spatial_id], [s2].[geometry_id], [s3].[b], [s3].[h], [s3].[l], [t0].[text], [r1].[cargo_request_id], [r1].[consignment_id], [r1].[container_id], [r1].[date_id], [r1].[entity_id], [r1].[index_in_cargo_request], [r1].[index_in_consignment], [r1].[index_in_container], [r1].[index_in_inventory_item], [r1].[index_in_shipping_unit], [r1].[index_in_task], [r1].[index_in_work_item], [r1].[index_in_work_order], [r1].[inventory_item_id], [r1].[location_id], [r1].[shipping_unit_id], [r1].[task_id], [r1].[text_id], [r1].[work_item_id], [r1].[work_order_id], [d1].[comments], [d1].[date], [e3].[entity_id], [e3].[entity_type], [e3].[revision], [e3].[summary_id], [e4].[basic], [e4].[detailed], [e4].[extended], [g1].[geo_mismatch], [g1].[spatial_id], [s4].[geometry_id], [s5].[b], [s5].[h], [s5].[l], [t1].[text]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

```sql
exec sp_executesql N'SELECT [s6].[id], [s6].[elevation], [s6].[index_in_spatial], [s6].[latitude], [s6].[longitude], [s6].[spatial_id], [s6].[timestamp], [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
INNER JOIN [txn].[spatial_geographies] AS [s6] ON [s0].[id] = [s6].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

```sql
exec sp_executesql N'SELECT [s6].[id], [s6].[elevation], [s6].[index_in_spatial], [s6].[latitude], [s6].[longitude], [s6].[spatial_id], [s6].[timestamp], [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
INNER JOIN [txn].[spatial_geographies] AS [s6] ON [s2].[id] = [s6].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

```sql
exec sp_executesql N'SELECT [t2].[id], [t2].[cargo_request_id], [t2].[consignment_id], [t2].[container_id], [t2].[date_id], [t2].[entity_id], [t2].[index_in_cargo_request], [t2].[index_in_consignment], [t2].[index_in_container], [t2].[index_in_inventory_item], [t2].[index_in_shipping_unit], [t2].[index_in_task], [t2].[index_in_work_item], [t2].[index_in_work_order], [t2].[inventory_item_id], [t2].[location_id], [t2].[shipping_unit_id], [t2].[task_id], [t2].[text_id], [t2].[work_item_id], [t2].[work_order_id], [t2].[id0], [t2].[comments], [t2].[date], [t2].[id1], [t2].[entity_id0], [t2].[entity_type], [t2].[revision], [t2].[summary_id], [t2].[id2], [t2].[basic], [t2].[detailed], [t2].[extended], [t2].[id3], [t2].[geo_mismatch], [t2].[spatial_id], [t2].[id4], [t2].[geometry_id], [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id], [t2].[id5], [t2].[id6], [t2].[b], [t2].[h], [t2].[l], [t2].[text]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
INNER JOIN (
    SELECT [r2].[id], [r2].[cargo_request_id], [r2].[consignment_id], [r2].[container_id], [r2].[date_id], [r2].[entity_id], [r2].[index_in_cargo_request], [r2].[index_in_consignment], [r2].[index_in_container], [r2].[index_in_inventory_item], [r2].[index_in_shipping_unit], [r2].[index_in_task], [r2].[index_in_work_item], [r2].[index_in_work_order], [r2].[inventory_item_id], [r2].[location_id], [r2].[shipping_unit_id], [r2].[task_id], [r2].[text_id], [r2].[work_item_id], [r2].[work_order_id], [d2].[id] AS [id0], [d2].[comments], [d2].[date], [e5].[id] AS [id1], [e5].[entity_id] AS [entity_id0], [e5].[entity_type], [e5].[revision], [e5].[summary_id], [e6].[id] AS [id2], [e6].[basic], [e6].[detailed], [e6].[extended], [g2].[id] AS [id3], [g2].[geo_mismatch], [g2].[spatial_id], [s6].[id] AS [id4], [s6].[geometry_id], [s7].[id] AS [id5], [s7].[b], [s7].[h], [s7].[l], [t3].[id] AS [id6], [t3].[text]
    FROM [txn].[references] AS [r2]
    LEFT JOIN [txn].[date_references] AS [d2] ON [r2].[date_id] = [d2].[id]
    LEFT JOIN [txn].[entity_summary_references] AS [e5] ON [r2].[entity_id] = [e5].[id]
    LEFT JOIN [txn].[entity_summaries] AS [e6] ON [e5].[summary_id] = [e6].[id]
    LEFT JOIN [txn].[geo_location_references] AS [g2] ON [r2].[location_id] = [g2].[id]
    LEFT JOIN [txn].[spatials] AS [s6] ON [g2].[spatial_id] = [s6].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [s7] ON [s6].[geometry_id] = [s7].[id]
    LEFT JOIN [txn].[text_references] AS [t3] ON [r2].[text_id] = [t3].[id]
) AS [t2] ON [s].[id] = [t2].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''3af6a089-4381-4b4b-a421-003a72fe9a61'', ''8b4fe27d-9cd3-466d-af2b-003b8145f0a7'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id], [t2].[id], [t2].[id0], [t2].[id1], [t2].[id2], [t2].[id3], [t2].[id4], [t2].[id5], [t2].[id6]',N'@__batchId_1 bigint',@__batchId_1=200000
```

```sql
exec sp_executesql N'SELECT [s8].[id], [s8].[elevation], [s8].[index_in_spatial], [s8].[latitude], [s8].[longitude], [s8].[spatial_id], [s8].[timestamp], [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id], [t2].[id], [t2].[id0], [t2].[id1], [t2].[id2], [t2].[id3], [t2].[id4], [t2].[id5], [t2].[id6]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
INNER JOIN (
    SELECT [r2].[id], [r2].[shipping_unit_id], [d2].[id] AS [id0], [e5].[id] AS [id1], [e6].[id] AS [id2], [g2].[id] AS [id3], [s6].[id] AS [id4], [s7].[id] AS [id5], [t3].[id] AS [id6]
    FROM [txn].[references] AS [r2]
    LEFT JOIN [txn].[date_references] AS [d2] ON [r2].[date_id] = [d2].[id]
    LEFT JOIN [txn].[entity_summary_references] AS [e5] ON [r2].[entity_id] = [e5].[id]
    LEFT JOIN [txn].[entity_summaries] AS [e6] ON [e5].[summary_id] = [e6].[id]
    LEFT JOIN [txn].[geo_location_references] AS [g2] ON [r2].[location_id] = [g2].[id]
    LEFT JOIN [txn].[spatials] AS [s6] ON [g2].[spatial_id] = [s6].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [s7] ON [s6].[geometry_id] = [s7].[id]
    LEFT JOIN [txn].[text_references] AS [t3] ON [r2].[text_id] = [t3].[id]
) AS [t2] ON [s].[id] = [t2].[shipping_unit_id]
INNER JOIN [txn].[spatial_geographies] AS [s8] ON [t2].[id4] = [s8].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id], [t2].[id], [t2].[id0], [t2].[id1], [t2].[id2], [t2].[id3], [t2].[id4], [t2].[id5], [t2].[id6]',N'@__batchId_1 bigint',@__batchId_1=200000
```

```sql
exec sp_executesql N'SELECT [s6].[id], [s6].[elevation], [s6].[index_in_spatial], [s6].[latitude], [s6].[longitude], [s6].[spatial_id], [s6].[timestamp], [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]
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
LEFT JOIN [txn].[references] AS [r1] ON [s].[start_reference_id] = [r1].[id]
LEFT JOIN [txn].[date_references] AS [d1] ON [r1].[date_id] = [d1].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e3] ON [r1].[entity_id] = [e3].[id]
LEFT JOIN [txn].[entity_summaries] AS [e4] ON [e3].[summary_id] = [e4].[id]
LEFT JOIN [txn].[geo_location_references] AS [g1] ON [r1].[location_id] = [g1].[id]
LEFT JOIN [txn].[spatials] AS [s4] ON [g1].[spatial_id] = [s4].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s5] ON [s4].[geometry_id] = [s5].[id]
LEFT JOIN [txn].[text_references] AS [t1] ON [r1].[text_id] = [t1].[id]
INNER JOIN [txn].[spatial_geographies] AS [s6] ON [s4].[id] = [s6].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''341fc4bf-55b7-456f-8d85-0002cbed978f'', ''f6a17a98-e060-4834-a2f4-00060ec83bf0'') AND ([s].[transaction_id] < @__batchId_1)
ORDER BY [s].[id], [r].[id], [d].[id], [e].[id], [e0].[id], [g].[id], [s0].[id], [s1].[id], [t].[id], [a].[id], [r0].[id], [d0].[id], [e1].[id], [e2].[id], [g0].[id], [s2].[id], [s3].[id], [t0].[id], [r1].[id], [d1].[id], [e3].[id], [e4].[id], [g1].[id], [s4].[id], [s5].[id], [t1].[id]',N'@__batchId_1 bigint',@__batchId_1=200000
```

### EF6 with EFPlus optimized, which somehow in between

Lots of small sub-queries, nested select is also there, but smaller dataset is being joined

```sql
exec sp_executesql N'-- EF+ Query Future: 1 of 38
SELECT [s].[id], [s].[comments], [s].[date_created], [s].[date_time], [s].[date_updated], [s].[end_reference_id], [s].[event], [s].[identity_id], [s].[is_system], [s].[quantity], [s].[receipent_id], [s].[revision], [s].[shipping_unit_id], [s].[start_reference_id], [s].[transaction_id]
FROM [txn].[shipping_units] AS [s]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_1___batchId_1)
;

-- EF+ Query Future: 2 of 38
SELECT [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_2___batchId_1)
;

-- EF+ Query Future: 3 of 38
SELECT [d].[id], [d].[comments], [d].[date]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[date_references] AS [d] ON [r].[date_id] = [d].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_3___batchId_1)
;

-- EF+ Query Future: 4 of 38
SELECT [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_4___batchId_1)
;

-- EF+ Query Future: 5 of 38
SELECT [e0].[id], [e0].[basic], [e0].[detailed], [e0].[extended]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
LEFT JOIN [txn].[entity_summaries] AS [e0] ON [e].[summary_id] = [e0].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_5___batchId_1)
;

-- EF+ Query Future: 6 of 38
SELECT [g].[id], [g].[geo_mismatch], [g].[spatial_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_6___batchId_1)
;

-- EF+ Query Future: 7 of 38
SELECT [s0].[id], [s0].[geometry_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_7___batchId_1)
;

-- EF+ Query Future: 8 of 38
SELECT [s].[id], [r].[id], [g].[id], [s0].[id], [s1].[id], [s1].[elevation], [s1].[index_in_spatial], [s1].[latitude], [s1].[longitude], [s1].[spatial_id], [s1].[timestamp]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geographies] AS [s1] ON [s0].[id] = [s1].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_8___batchId_1)
ORDER BY [s].[id], [r].[id], [g].[id], [s0].[id]
;

-- EF+ Query Future: 9 of 38
SELECT [s1].[id], [s1].[b], [s1].[h], [s1].[l]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s1] ON [s0].[geometry_id] = [s1].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_9___batchId_1)
;

-- EF+ Query Future: 10 of 38
SELECT [t].[id], [t].[text]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[end_reference_id] = [r].[id]
LEFT JOIN [txn].[text_references] AS [t] ON [r].[text_id] = [t].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_10___batchId_1)
;

-- EF+ Query Future: 11 of 38
SELECT [a].[id], [a].[identity_json]
FROM [txn].[shipping_units] AS [s]
INNER JOIN [txn].[auth_identities] AS [a] ON [s].[identity_id] = [a].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_11___batchId_1)
;

-- EF+ Query Future: 12 of 38
SELECT [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_12___batchId_1)
;

-- EF+ Query Future: 13 of 38
SELECT [d].[id], [d].[comments], [d].[date]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[date_references] AS [d] ON [r].[date_id] = [d].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_13___batchId_1)
;

-- EF+ Query Future: 14 of 38
SELECT [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_14___batchId_1)
;

-- EF+ Query Future: 15 of 38
SELECT [e0].[id], [e0].[basic], [e0].[detailed], [e0].[extended]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
LEFT JOIN [txn].[entity_summaries] AS [e0] ON [e].[summary_id] = [e0].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_15___batchId_1)
;

-- EF+ Query Future: 16 of 38
SELECT [g].[id], [g].[geo_mismatch], [g].[spatial_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_16___batchId_1)
;

-- EF+ Query Future: 17 of 38
SELECT [s0].[id], [s0].[geometry_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_17___batchId_1)
;

-- EF+ Query Future: 18 of 38
SELECT [s].[id], [r].[id], [g].[id], [s0].[id], [s1].[id], [s1].[elevation], [s1].[index_in_spatial], [s1].[latitude], [s1].[longitude], [s1].[spatial_id], [s1].[timestamp]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geographies] AS [s1] ON [s0].[id] = [s1].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_18___batchId_1)
ORDER BY [s].[id], [r].[id], [g].[id], [s0].[id]
;

-- EF+ Query Future: 19 of 38
SELECT [s1].[id], [s1].[b], [s1].[h], [s1].[l]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s1] ON [s0].[geometry_id] = [s1].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_19___batchId_1)
;

-- EF+ Query Future: 20 of 38
SELECT [t].[id], [t].[text]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[receipent_id] = [r].[id]
LEFT JOIN [txn].[text_references] AS [t] ON [r].[text_id] = [t].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_20___batchId_1)
;

-- EF+ Query Future: 21 of 38
SELECT [s].[id], [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[id] = [r].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_21___batchId_1)
ORDER BY [s].[id]
;

-- EF+ Query Future: 22 of 38
SELECT [s].[id], [t].[id], [t].[comments], [t].[date], [t].[id0]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [d].[id], [d].[comments], [d].[date], [r].[id] AS [id0], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[date_references] AS [d] ON [r].[date_id] = [d].[id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_22___batchId_1)
ORDER BY [s].[id], [t].[id0]
;

-- EF+ Query Future: 23 of 38
SELECT [s].[id], [t].[id], [t].[entity_id], [t].[entity_type], [t].[revision], [t].[summary_id], [t].[id0]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id], [r].[id] AS [id0], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_23___batchId_1)
ORDER BY [s].[id], [t].[id0]
;

-- EF+ Query Future: 24 of 38
SELECT [s].[id], [t].[id], [t].[basic], [t].[detailed], [t].[extended], [t].[id0], [t].[id1]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [e0].[id], [e0].[basic], [e0].[detailed], [e0].[extended], [r].[id] AS [id0], [e].[id] AS [id1], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
    LEFT JOIN [txn].[entity_summaries] AS [e0] ON [e].[summary_id] = [e0].[id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_24___batchId_1)
ORDER BY [s].[id], [t].[id0], [t].[id1]
;

-- EF+ Query Future: 25 of 38
SELECT [s].[id], [t].[id], [t].[geo_mismatch], [t].[spatial_id], [t].[id0]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [g].[id], [g].[geo_mismatch], [g].[spatial_id], [r].[id] AS [id0], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_25___batchId_1)
ORDER BY [s].[id], [t].[id0]
;

-- EF+ Query Future: 26 of 38
SELECT [s].[id], [t].[id], [t].[geometry_id], [t].[id0], [t].[id1]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [s0].[id], [s0].[geometry_id], [r].[id] AS [id0], [g].[id] AS [id1], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
    LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_26___batchId_1)
ORDER BY [s].[id], [t].[id0], [t].[id1]
;

-- EF+ Query Future: 27 of 38
SELECT [s].[id], [t].[id], [t].[id0], [t].[id1], [t].[id2], [t].[elevation], [t].[index_in_spatial], [t].[latitude], [t].[longitude], [t].[spatial_id], [t].[timestamp]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [r].[id], [g].[id] AS [id0], [s0].[id] AS [id1], [s1].[id] AS [id2], [s1].[elevation], [s1].[index_in_spatial], [s1].[latitude], [s1].[longitude], [s1].[spatial_id], [s1].[timestamp], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
    LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
    LEFT JOIN [txn].[spatial_geographies] AS [s1] ON [s0].[id] = [s1].[spatial_id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_27___batchId_1)
ORDER BY [s].[id], [t].[id], [t].[id0], [t].[id1]
;

-- EF+ Query Future: 28 of 38
SELECT [s].[id], [t].[id], [t].[b], [t].[h], [t].[l], [t].[id0], [t].[id1], [t].[id2]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [s1].[id], [s1].[b], [s1].[h], [s1].[l], [r].[id] AS [id0], [g].[id] AS [id1], [s0].[id] AS [id2], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
    LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
    LEFT JOIN [txn].[spatial_geometries] AS [s1] ON [s0].[geometry_id] = [s1].[id]
) AS [t] ON [s].[id] = [t].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_28___batchId_1)
ORDER BY [s].[id], [t].[id0], [t].[id1], [t].[id2]
;

-- EF+ Query Future: 29 of 38
SELECT [s].[id], [t0].[id], [t0].[text], [t0].[id0]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN (
    SELECT [t].[id], [t].[text], [r].[id] AS [id0], [r].[shipping_unit_id]
    FROM [txn].[references] AS [r]
    LEFT JOIN [txn].[text_references] AS [t] ON [r].[text_id] = [t].[id]
) AS [t0] ON [s].[id] = [t0].[shipping_unit_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_29___batchId_1)
ORDER BY [s].[id], [t0].[id0]
;

-- EF+ Query Future: 30 of 38
SELECT [r].[id], [r].[cargo_request_id], [r].[consignment_id], [r].[container_id], [r].[date_id], [r].[entity_id], [r].[index_in_cargo_request], [r].[index_in_consignment], [r].[index_in_container], [r].[index_in_inventory_item], [r].[index_in_shipping_unit], [r].[index_in_task], [r].[index_in_work_item], [r].[index_in_work_order], [r].[inventory_item_id], [r].[location_id], [r].[shipping_unit_id], [r].[task_id], [r].[text_id], [r].[work_item_id], [r].[work_order_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_30___batchId_1)
;

-- EF+ Query Future: 31 of 38
SELECT [d].[id], [d].[comments], [d].[date]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[date_references] AS [d] ON [r].[date_id] = [d].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_31___batchId_1)
;

-- EF+ Query Future: 32 of 38
SELECT [e].[id], [e].[entity_id], [e].[entity_type], [e].[revision], [e].[summary_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_32___batchId_1)
;

-- EF+ Query Future: 33 of 38
SELECT [e0].[id], [e0].[basic], [e0].[detailed], [e0].[extended]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[entity_summary_references] AS [e] ON [r].[entity_id] = [e].[id]
LEFT JOIN [txn].[entity_summaries] AS [e0] ON [e].[summary_id] = [e0].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_33___batchId_1)
;

-- EF+ Query Future: 34 of 38
SELECT [g].[id], [g].[geo_mismatch], [g].[spatial_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_34___batchId_1)
;

-- EF+ Query Future: 35 of 38
SELECT [s0].[id], [s0].[geometry_id]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_35___batchId_1)
;

-- EF+ Query Future: 36 of 38
SELECT [s].[id], [r].[id], [g].[id], [s0].[id], [s1].[id], [s1].[elevation], [s1].[index_in_spatial], [s1].[latitude], [s1].[longitude], [s1].[spatial_id], [s1].[timestamp]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geographies] AS [s1] ON [s0].[id] = [s1].[spatial_id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_36___batchId_1)
ORDER BY [s].[id], [r].[id], [g].[id], [s0].[id]
;

-- EF+ Query Future: 37 of 38
SELECT [s1].[id], [s1].[b], [s1].[h], [s1].[l]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[geo_location_references] AS [g] ON [r].[location_id] = [g].[id]
LEFT JOIN [txn].[spatials] AS [s0] ON [g].[spatial_id] = [s0].[id]
LEFT JOIN [txn].[spatial_geometries] AS [s1] ON [s0].[geometry_id] = [s1].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_37___batchId_1)
;

-- EF+ Query Future: 38 of 38
SELECT [t].[id], [t].[text]
FROM [txn].[shipping_units] AS [s]
LEFT JOIN [txn].[references] AS [r] ON [s].[start_reference_id] = [r].[id]
LEFT JOIN [txn].[text_references] AS [t] ON [r].[text_id] = [t].[id]
WHERE [s].[shipping_unit_id] IN (''d6a3711c-effb-4037-a180-001063253c46'', ''ade7579d-1ed9-4d33-a33a-0010ada1b33e'') AND ([s].[transaction_id] < @Z_38___batchId_1)
;

',N'@Z_1___batchId_1 bigint,@Z_2___batchId_1 bigint,@Z_3___batchId_1 bigint,@Z_4___batchId_1 bigint,@Z_5___batchId_1 bigint,@Z_6___batchId_1 bigint,@Z_7___batchId_1 bigint,@Z_8___batchId_1 bigint,@Z_9___batchId_1 bigint,@Z_10___batchId_1 bigint,@Z_11___batchId_1 bigint,@Z_12___batchId_1 bigint,@Z_13___batchId_1 bigint,@Z_14___batchId_1 bigint,@Z_15___batchId_1 bigint,@Z_16___batchId_1 bigint,@Z_17___batchId_1 bigint,@Z_18___batchId_1 bigint,@Z_19___batchId_1 bigint,@Z_20___batchId_1 bigint,@Z_21___batchId_1 bigint,@Z_22___batchId_1 bigint,@Z_23___batchId_1 bigint,@Z_24___batchId_1 bigint,@Z_25___batchId_1 bigint,@Z_26___batchId_1 bigint,@Z_27___batchId_1 bigint,@Z_28___batchId_1 bigint,@Z_29___batchId_1 bigint,@Z_30___batchId_1 bigint,@Z_31___batchId_1 bigint,@Z_32___batchId_1 bigint,@Z_33___batchId_1 bigint,@Z_34___batchId_1 bigint,@Z_35___batchId_1 bigint,@Z_36___batchId_1 bigint,@Z_37___batchId_1 bigint,@Z_38___batchId_1 bigint',@Z_1___batchId_1=200000,@Z_2___batchId_1=200000,@Z_3___batchId_1=200000,@Z_4___batchId_1=200000,@Z_5___batchId_1=200000,@Z_6___batchId_1=200000,@Z_7___batchId_1=200000,@Z_8___batchId_1=200000,@Z_9___batchId_1=200000,@Z_10___batchId_1=200000,@Z_11___batchId_1=200000,@Z_12___batchId_1=200000,@Z_13___batchId_1=200000,@Z_14___batchId_1=200000,@Z_15___batchId_1=200000,@Z_16___batchId_1=200000,@Z_17___batchId_1=200000,@Z_18___batchId_1=200000,@Z_19___batchId_1=200000,@Z_20___batchId_1=200000,@Z_21___batchId_1=200000,@Z_22___batchId_1=200000,@Z_23___batchId_1=200000,@Z_24___batchId_1=200000,@Z_25___batchId_1=200000,@Z_26___batchId_1=200000,@Z_27___batchId_1=200000,@Z_28___batchId_1=200000,@Z_29___batchId_1=200000,@Z_30___batchId_1=200000,@Z_31___batchId_1=200000,@Z_32___batchId_1=200000,@Z_33___batchId_1=200000,@Z_34___batchId_1=200000,@Z_35___batchId_1=200000,@Z_36___batchId_1=200000,@Z_37___batchId_1=200000,@Z_38___batchId_1=200000
```
