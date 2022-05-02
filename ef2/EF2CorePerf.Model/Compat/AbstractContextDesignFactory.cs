using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crosscutting.sql
{
    public abstract class AbstractContextDesignFactory<TContext> : IDesignTimeDbContextFactory<TContext>
         where TContext : DbContext
    {
        // design time and for migrations
        TContext IDesignTimeDbContextFactory<TContext>.CreateDbContext(string[] args)
        {
            return CreateDbContext(Guid.Empty, args);
        }

        public abstract TContext CreateDbContext(Guid platformId, params string[] args);

        protected TContext InternalCreateDbContext(
            Guid platformId,
            string localConnectionString,
            string schemaName,
            string[] args
            )
        {
            args = args ?? Array.Empty<string>();

            var designOptionsBuilder = new DbContextOptionsBuilder<TContext>();

            var isDebugging = args.Any(a => a.ToLower() == "debug");
            var connectionString = args.FirstOrDefault(a => a.ToLower().Contains("data source")) ?? localConnectionString;

            if (isDebugging)
            {
                designOptionsBuilder = designOptionsBuilder
                    .UseLoggerFactory(new LoggerFactory(new[] { new DebugLoggerProvider() }))
                    .EnableSensitiveDataLogging();
            }

            designOptionsBuilder.UseSqlServer(connectionString, (x) => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName, schemaName));

            // smells
            var ctx = (TContext)Activator.CreateInstance(typeof(TContext), platformId, designOptionsBuilder.Options);

            ctx.Database.SetCommandTimeout(TimeSpan.FromMinutes(5));

            return ctx;
        }
    }
}
