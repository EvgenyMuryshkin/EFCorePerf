/*************************************************************************
* SUPPLYLite [2017] - [2018]
* All Rights Reserved.
*/

namespace crosscutting.sql
{
    using crosscutting.cqrs;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Npgsql.NameTranslation;
    using Npgsql.NameTranslation.Compat;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="EntityDbContext{TContext}" />
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class EntityDbContext<TContext> : DbContext where TContext : DbContext
    {
        public readonly Guid PlatformId;

        //IDisposable _watchdog;
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDbContext{TContext}"/> class.
        /// </summary>
        /// <param name="options">The <see cref="DbContextOptions{TContext}"/></param>
        public EntityDbContext(Guid platformId, DbContextOptions<TContext> options) : base(options)
        {
            PlatformId = platformId;
            //var listener = this.GetService<DiagnosticSource>();
            //_watchdog = (listener as DiagnosticListener).SubscribeWithAdapter(new NullableRefQueryWatchdog());
        }

        public override void Dispose()
        {
            //_watchdog.Dispose();
            base.Dispose();
        }
        /// <summary>
        /// The OnContextCreated
        /// </summary>
        /// <param name="options">The <see cref="DbContextOptions{TContext}"/></param>
        protected void OnContextCreated(DbContextOptions<TContext> options)
        {
        }

        // https://stackoverflow.com/questions/16437083/dbcontext-discard-changes-without-disposing/16437305
        /// <summary>
        /// The RollbackChanges
        /// </summary>
        public async Task RollbackChanges()
        {
            foreach (var entry in ChangeTracker.Entries().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        await entry.ReloadAsync();
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        /// <summary>
        /// The PostModelCreating
        /// </summary>
        /// <param name="builder">The <see cref="ModelBuilder"/></param>
        protected void PostModelCreating(ModelBuilder builder)
        {
            var mapper = new NpgsqlSnakeCaseNameTranslator();

            foreach (var entity in builder.Model.GetEntityTypes())
            {
                var tableName = entity.GetTableName();
                
                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(mapper.TranslateMemberName(property.GetColumnName(StoreObjectIdentifier.Create(entity, StoreObjectType.Table).Value)));
                }

                entity.SetTableName(mapper.TranslateMemberName(tableName));
            }

            // disable cascading delete option
            // https://stackoverflow.com/questions/46526230/disable-cascade-delete-on-ef-core-2-globally
            var cascadeFKs = builder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
