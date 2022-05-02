using common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using transactions.sql;

namespace EF2CorePerf
{
    [TestClass]
    public class Seed
    {
        string LogPath => @"c:\code\EFCorePerf\seed.log.txt";

        txnReferenceDbEntity newReference(txnTransactionsDBContext targetCtx, Action<txnReferenceDbEntity> modifier = null)
        {
            var summary = new txnEntitySummaryDbEntity() { Basic = "".PadLeft(10, '*'), Extended = "".PadLeft(20, '*'), Detailed = "".PadLeft(30, '*') };
            targetCtx.Add(summary);

            var entity = new txnEntitySummaryReferenceDbEntity() { EntityId = Guid.NewGuid(), SummaryId = summary.Id };
            targetCtx.Add(entity);

            var text = new txnTextReferenceDbEntity() { Text = "".PadLeft(15, '*') };
            targetCtx.Add(text);

            var date = new txnDateReferenceDbEntity();
            targetCtx.Add(date);

            var geometry = new txnSpatialGeometryDbEntity();
            targetCtx.Add(geometry);

            var spacial = new txnSpatialDbEntity() { GeometryId = geometry.Id };
            targetCtx.Add(spacial);

            var geography1 = new txnSpatialGeographyDbEntity() { SpatialId = spacial.Id };
            targetCtx.Add(geography1);

            var geography2 = new txnSpatialGeographyDbEntity() { SpatialId = spacial.Id };
            targetCtx.Add(geography2);

            var location = new txnGeoLocationReferenceDbEntity() { SpatialId = spacial.Id };
            targetCtx.Add(location);

            var reference = new txnReferenceDbEntity() { EntityId = entity.Id, TextId = text.Id, DateId = date.Id, LocationId = location.Id };

            modifier?.Invoke(reference);
            targetCtx.Add(reference);

            return reference;
        }

        void Log(string line)
        {
            if (Directory.Exists(Path.GetDirectoryName(LogPath)))
                File.AppendAllLines(LogPath, new[] { line });
        }

        async Task BatchIterator(string type, int total, Action<txnTransactionsDBContext, int> iterator)
        {
            var batchSize = 1000;
            var batches = (int)Math.Ceiling(total / (float)batchSize);

            foreach (var batch in Enumerable.Range(0, batches))
            {
                if (total == 0)
                    break;

                Log($"{DateTime.Now}: {type} batch {batch + 1}/{batches}");

                using (var targetCtx = new TransactionsDbContextDesignFactory().CreateDbContext(Guid.Empty, EFPerfTestValues.ds))
                {
                    foreach (var idx in Enumerable.Range(0, batchSize))
                    {
                        if (total-- == 0)
                            break;

                        iterator(targetCtx, batch * batchSize + idx);
                    }

                    await targetCtx.SaveChangesAsync();
                }
            }
        }

        //[TestMethod, Timeout(TestTimeout.Infinite)]
        /// <summary>
        /// Setup large amount of dummy data.
        /// EF2 and EF6 seems to work rather good on dummy data, but EF6 is slow on production dataset.
        /// It takes about an hour to run this test and get seed data.
        /// </summary>
        /// <returns></returns>
        public async Task CodeSeed()
        {
            if (File.Exists(LogPath))
                File.Delete(LogPath);

            using (var targetCtx = new TransactionsDbContextDesignFactory().CreateDbContext(Guid.Empty, EFPerfTestValues.ds))
            {
                await targetCtx.Database.EnsureDeletedAsync();
                await targetCtx.Database.EnsureCreatedAsync();
            }

            // inventory
            await BatchIterator("inventory", 10000, (targetCtx, idx) =>
            {
                var identity = new txnAuthIdentityDbEntity();
                targetCtx.Add(identity);

                var tx = new txnInventoryItemDbEntity()
                {
                    IdentityId = identity.Id,
                    StartReferenceId = newReference(targetCtx).Id,
                    EndReferenceId = newReference(targetCtx).Id,
                    InventoryItemId = Guid.NewGuid(),
                    TransactionId = idx
                };

                targetCtx.Add(tx);

                newReference(targetCtx, (r) => r.InventoryItemId = tx.Id);
                newReference(targetCtx, (r) => r.InventoryItemId = tx.Id);
            });

            // container
            await BatchIterator("container", 150000, (targetCtx, idx) =>
            {
                var identity = new txnAuthIdentityDbEntity();
                targetCtx.Add(identity);

                var tx = new txnContainerDbEntity()
                {
                    IdentityId = identity.Id,
                    StartReferenceId = newReference(targetCtx).Id,
                    EndReferenceId = newReference(targetCtx).Id,
                    ContainerId = Guid.NewGuid(),
                    TransactionId = idx
                };

                targetCtx.Add(tx);

                newReference(targetCtx, (r) => r.ContainerId = tx.Id);
                newReference(targetCtx, (r) => r.ContainerId = tx.Id);
            });

            // shipping unit
            await BatchIterator("su", 170000, (targetCtx, idx) =>
            {
                var identity = new txnAuthIdentityDbEntity();
                targetCtx.Add(identity);

                var tx = new txnShippingUnitDbEntity()
                {
                    IdentityId = identity.Id,
                    StartReferenceId = newReference(targetCtx).Id,
                    EndReferenceId = newReference(targetCtx).Id,
                    ShippingUnitId = Guid.NewGuid(),
                    TransactionId = idx
                };

                targetCtx.Add(tx);

                newReference(targetCtx, (r) => r.ShippingUnitId = tx.Id);
                newReference(targetCtx, (r) => r.ShippingUnitId = tx.Id);
            });

            // consignments
            await BatchIterator("consignment", 50000, (targetCtx, idx) =>
            {
                var identity = new txnAuthIdentityDbEntity();
                targetCtx.Add(identity);

                var tx = new txnConsignmentDbEntity()
                {
                    IdentityId = identity.Id,
                    StartReferenceId = newReference(targetCtx).Id,
                    EndReferenceId = newReference(targetCtx).Id,
                    ConsignmentId = Guid.NewGuid(),
                    TransactionId = idx
                };

                targetCtx.Add(tx);

                newReference(targetCtx, (r) => r.ConsignmentId = tx.Id);
                newReference(targetCtx, (r) => r.ConsignmentId = tx.Id);
            });
        }
    }
}