using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;
using System.Text;

namespace EF6CorePerfBenchmarkGenerator
{
    [TestClass]
    public class EF6CorePerfBenchmarkGenerator
    {
        [TestMethod]
        public void Generate()
        {
			var versions = new[] { "2", "6" };

			foreach (var version in versions)
            {
				var linqOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}CorePerf.Model\model\transactions.queries.benchmark.cs";
				var benchmarkOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}Benchmark\EF{version}CoreBenchmark.generated.cs";

				var linqLines = new string[]
				{
					"Include(c => c.EndReference)",
					"ThenInclude(c => c.Date)",
					"Include(c => c.EndReference)",
					"ThenInclude(c => c.Entity)",
					"ThenInclude(c => c.Summary)",
					"Include(c => c.EndReference)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geographies)",
					"Include(c => c.EndReference)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geometry)",
					"Include(c => c.EndReference)",
					"ThenInclude(c => c.Text)",
					"Include(c => c.Identity)",
					"Include(c => c.Receipent)",
					"ThenInclude(c => c.Date)",
					"Include(c => c.Receipent)",
					"ThenInclude(c => c.Entity)",
					"ThenInclude(c => c.Summary)",
					"Include(c => c.Receipent)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geographies)",
					"Include(c => c.Receipent)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geometry)",
					"Include(c => c.Receipent)",
					"ThenInclude(c => c.Text)",
					"Include(c => c.References)",
					"ThenInclude(c => c.Date)",
					"Include(c => c.References)",
					"ThenInclude(c => c.Entity)",
					"ThenInclude(c => c.Summary)",
					"Include(c => c.References)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geographies)",
					"Include(c => c.References)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geometry)",
					"Include(c => c.References)",
					"ThenInclude(c => c.Text)",
					"Include(c => c.StartReference)",
					"ThenInclude(c => c.Date)",
					"Include(c => c.StartReference)",
					"ThenInclude(c => c.Entity)",
					"ThenInclude(c => c.Summary)",
					"Include(c => c.StartReference)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geographies)",
					"Include(c => c.StartReference)",
					"ThenInclude(c => c.Location)",
					"ThenInclude(c => c.Spatial)",
					"ThenInclude(c => c.Geometry)",
					"Include(c => c.StartReference)",
					"ThenInclude(c => c.Text)"
				};

				var linqBuilder = new StringBuilder();
				linqBuilder.AppendLine("using Microsoft.EntityFrameworkCore;");
				linqBuilder.AppendLine("using System.Linq;");
				linqBuilder.AppendLine($"namespace transactions.sql");
				linqBuilder.AppendLine("{");

				linqBuilder.AppendLine("\tpublic partial class txnTransactionsDBContext");
				linqBuilder.AppendLine("\t{");

				foreach (var idx in Enumerable.Range(0, linqLines.Length + 1))
				{
					var lines = linqLines.Take(idx);

					linqBuilder.AppendLine($"\t\tpublic IQueryable<txnShippingUnitDbEntity> ShippingUnitsWithComposites{idx} =>");
					linqBuilder.AppendLine("\t\t\tShippingUnits");

					foreach (var line in lines)
					{
						linqBuilder.AppendLine($"\t\t\t.{line}");
					}

					linqBuilder.AppendLine("\t\t;");
				}

				linqBuilder.AppendLine("\t} // end context");
				linqBuilder.AppendLine("} // end ns");

				File.WriteAllText(linqOutput, linqBuilder.ToString());

				var benchmarkBuilder = new StringBuilder();
				benchmarkBuilder.AppendLine("using BenchmarkDotNet.Attributes;");
				benchmarkBuilder.AppendLine("using System;");
				benchmarkBuilder.AppendLine("using System.Linq;");
				benchmarkBuilder.AppendLine($"namespace EF{version}Benchmark");
				benchmarkBuilder.AppendLine("{");

				benchmarkBuilder.AppendLine($"\tpublic partial class EF{version}CoreBenchmark");
				benchmarkBuilder.AppendLine("\t{");

				foreach (var idx in Enumerable.Range(0, linqLines.Length + 1))
				{
					benchmarkBuilder.AppendLine($"\t\t[Benchmark]");
					benchmarkBuilder.AppendLine($"\t\tpublic void ShippingUnitsWithComposites{idx}()");
					benchmarkBuilder.AppendLine("\t\t{");
					benchmarkBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites{idx}.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
					benchmarkBuilder.AppendLine("\t\t}");
				}
				benchmarkBuilder.AppendLine("\t} // end benchmark");
				benchmarkBuilder.AppendLine("} // end ns");

				File.WriteAllText(benchmarkOutput, benchmarkBuilder.ToString());
			}
		}
    }
}
