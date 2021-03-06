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
        public void GenerateIncrementalQuery()
        {
			var versions = new[] { "2", "6" };

			foreach (var version in versions)
            {
				var linqOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}CorePerf.Model\model\transactions.queries.benchmark.cs";
				var benchmarkOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}Benchmark\EF{version}CoreBenchmark.generated.cs";
				var unitTestOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}CorePerf.Tests\EF{version}CorePerf.generated.cs";

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

					if (version == "6")
                    {
						linqBuilder.AppendLine($"\t\tpublic IQueryable<txnShippingUnitDbEntity> ShippingUnitsWithComposites{idx}AsSplitQuery => ShippingUnitsWithComposites{idx}.AsSplitQuery();");
					}
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

					if (version == "6")
                    {
						benchmarkBuilder.AppendLine($"\t\t[Benchmark]");
						benchmarkBuilder.AppendLine($"\t\tpublic void ShippingUnitsWithComposites{idx}AsSplitQuery()");
						benchmarkBuilder.AppendLine("\t\t{");
						benchmarkBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites{idx}AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
						benchmarkBuilder.AppendLine("\t\t}");
					}
				}
				benchmarkBuilder.AppendLine("\t} // end benchmark");
				benchmarkBuilder.AppendLine("} // end ns");

				File.WriteAllText(benchmarkOutput, benchmarkBuilder.ToString());

				// geneate tests

				var unitTestsBuilder = new StringBuilder();
				unitTestsBuilder.AppendLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
				unitTestsBuilder.AppendLine("using System;");
				unitTestsBuilder.AppendLine("using System.Linq;");
				unitTestsBuilder.AppendLine($"namespace EF{version}PerfUnitTests");
				unitTestsBuilder.AppendLine("{");

				unitTestsBuilder.AppendLine($"\t[TestClass]");
				unitTestsBuilder.AppendLine($"\tpublic partial class EF{version}PerfUnitTests");
				unitTestsBuilder.AppendLine("\t{");

				foreach (var idx in Enumerable.Range(0, linqLines.Length + 1))
				{
					unitTestsBuilder.AppendLine($"\t\t[TestMethod]");
					unitTestsBuilder.AppendLine($"\t\tpublic void ShippingUnitsWithComposites{idx}()");
					unitTestsBuilder.AppendLine("\t\t{");
					unitTestsBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites{idx}.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
					unitTestsBuilder.AppendLine("\t\t}");

					if (version == "6")
					{
						unitTestsBuilder.AppendLine($"\t\t[TestMethod]");
						unitTestsBuilder.AppendLine($"\t\tpublic void ShippingUnitsWithComposites{idx}AsSplitQuery()");
						unitTestsBuilder.AppendLine("\t\t{");
						unitTestsBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsWithComposites{idx}AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
						unitTestsBuilder.AppendLine("\t\t}");
					}
				}
				unitTestsBuilder.AppendLine("\t} // end benchmark");
				unitTestsBuilder.AppendLine("} // end ns");

				File.WriteAllText(unitTestOutput, unitTestsBuilder.ToString());
			}
		}

		[TestMethod]
		public void GenerateTopPlusOneQuery()
		{
			var versions = new[] { "2", "6" };

			foreach (var version in versions)
			{
				var linqOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}CorePerf.Model\model\transactions.queries.TopPlusOne.cs";
				var benchmarkOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}Benchmark\EF{version}BenchmarkTopPlusOne.generated.cs";
				var unitTestOutput = @$"C:\code\EFCorePerf\ef{version}\EF{version}CorePerf.Tests\EF{version}PerfTopPlusOne.generated.cs";

				var linqLines = new string[]
				{
					"Include(c => c.EndReference).ThenInclude(c => c.Date)",
					"Include(c => c.EndReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)",
					"Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)",
					"Include(c => c.EndReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)",
					"Include(c => c.EndReference).ThenInclude(c => c.Text)",
					"Include(c => c.Identity)",
					"Include(c => c.Receipent).ThenInclude(c => c.Date)",
					"Include(c => c.Receipent).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)",
					"Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)",
					"Include(c => c.Receipent).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)",
					"Include(c => c.Receipent).ThenInclude(c => c.Text)",
					"Include(c => c.References).ThenInclude(c => c.Date)",
					"Include(c => c.References).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)",
					"Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)",
					"Include(c => c.References).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)",
					"Include(c => c.References).ThenInclude(c => c.Text)",
					"Include(c => c.StartReference).ThenInclude(c => c.Date)",
					"Include(c => c.StartReference).ThenInclude(c => c.Entity).ThenInclude(c => c.Summary)",
					"Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geographies)",
					"Include(c => c.StartReference).ThenInclude(c => c.Location).ThenInclude(c => c.Spatial).ThenInclude(c => c.Geometry)",
					"Include(c => c.StartReference).ThenInclude(c => c.Text)"
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
					var lines = linqLines.Skip(idx).Take(1);

					linqBuilder.AppendLine($"\t\tpublic IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne{idx} =>");
					linqBuilder.AppendLine("\t\t\tShippingUnits");

					foreach (var line in lines)
					{
						linqBuilder.AppendLine($"\t\t\t.{line}");
					}

					linqBuilder.AppendLine("\t\t;");

					if (version == "6")
					{
						linqBuilder.AppendLine($"\t\tpublic IQueryable<txnShippingUnitDbEntity> ShippingUnitsTopPlusOne{idx}AsSplitQuery => ShippingUnitsTopPlusOne{idx}.AsSplitQuery();");
					}
				}

				linqBuilder.AppendLine("\t} // end context");
				linqBuilder.AppendLine("} // end ns");

				File.WriteAllText(linqOutput, linqBuilder.ToString());

				var benchmarkBuilder = new StringBuilder();
				benchmarkBuilder.AppendLine("using BenchmarkDotNet.Attributes;");
				benchmarkBuilder.AppendLine("using System;");
				benchmarkBuilder.AppendLine("using System.Linq;");
				benchmarkBuilder.AppendLine($"namespace EF{version}BenchmarkTopPlusOne");
				benchmarkBuilder.AppendLine("{");

				benchmarkBuilder.AppendLine($"\tpublic partial class EF{version}CoreBenchmarkTopPlusOne");
				benchmarkBuilder.AppendLine("\t{");

				foreach (var idx in Enumerable.Range(0, linqLines.Length + 1))
				{
					benchmarkBuilder.AppendLine($"\t\t[Benchmark]");
					benchmarkBuilder.AppendLine($"\t\tpublic void ShippingUnitsTopPlusOne{idx}()");
					benchmarkBuilder.AppendLine("\t\t{");
					benchmarkBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne{idx}.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
					benchmarkBuilder.AppendLine("\t\t}");

					if (version == "6")
					{
						benchmarkBuilder.AppendLine($"\t\t[Benchmark]");
						benchmarkBuilder.AppendLine($"\t\tpublic void ShippingUnitsTopPlusOne{idx}AsSplitQuery()");
						benchmarkBuilder.AppendLine("\t\t{");
						benchmarkBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne{idx}AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
						benchmarkBuilder.AppendLine("\t\t}");
					}
				}
				benchmarkBuilder.AppendLine("\t} // end benchmark");
				benchmarkBuilder.AppendLine("} // end ns");

				File.WriteAllText(benchmarkOutput, benchmarkBuilder.ToString());

				// geneate tests

				var unitTestsBuilder = new StringBuilder();
				unitTestsBuilder.AppendLine("using Microsoft.VisualStudio.TestTools.UnitTesting;");
				unitTestsBuilder.AppendLine("using System;");
				unitTestsBuilder.AppendLine("using System.Linq;");
				unitTestsBuilder.AppendLine($"namespace EF{version}PerfUnitTests");
				unitTestsBuilder.AppendLine("{");

				unitTestsBuilder.AppendLine($"\t[TestClass]");
				unitTestsBuilder.AppendLine($"\tpublic partial class EF{version}PerfTopPlusOneUnitTests");
				unitTestsBuilder.AppendLine("\t{");

				foreach (var idx in Enumerable.Range(0, linqLines.Length + 1))
				{
					unitTestsBuilder.AppendLine($"\t\t[TestMethod]");
					unitTestsBuilder.AppendLine($"\t\tpublic void ShippingUnitsTopPlusOne{idx}()");
					unitTestsBuilder.AppendLine("\t\t{");
					unitTestsBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne{idx}.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
					unitTestsBuilder.AppendLine("\t\t}");

					if (version == "6")
					{
						unitTestsBuilder.AppendLine($"\t\t[TestMethod]");
						unitTestsBuilder.AppendLine($"\t\tpublic void ShippingUnitsTopPlusOne{idx}AsSplitQuery()");
						unitTestsBuilder.AppendLine("\t\t{");
						unitTestsBuilder.AppendLine($@"
            using (var ctx = Context)
            {{
                var shippingUnitIds = suIds[Idx];
                var entities = ctx.ShippingUnitsTopPlusOne{idx}AsSplitQuery.Where(i => shippingUnitIds.Contains(i.ShippingUnitId) && i.TransactionId < batchId).ToList();
                if (entities.Count == 0) 
                    throw new Exception();
            }}
");
						unitTestsBuilder.AppendLine("\t\t}");
					}
				}
				unitTestsBuilder.AppendLine("\t} // end benchmark");
				unitTestsBuilder.AppendLine("} // end ns");

				File.WriteAllText(unitTestOutput, unitTestsBuilder.ToString());
			}
		}
	}
}
