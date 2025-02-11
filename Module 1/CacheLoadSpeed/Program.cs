using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using CacheLoadSpeed;

var config = ManualConfig.Create(DefaultConfig.Instance)
                .WithOptions(ConfigOptions.DisableOptimizationsValidator)
                .AddLogger(ConsoleLogger.Default)
                .AddExporter(CsvExporter.Default)
                .AddExporter(HtmlExporter.Default)
                .WithSummaryStyle(SummaryStyle.Default.WithMaxParameterColumnWidth(50));

BenchmarkRunner.Run<TablePopulator>();
