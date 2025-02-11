// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using StructVsClassBenchmark;

var config = ManualConfig.Create(DefaultConfig.Instance)
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddLogger(ConsoleLogger.Default)
    .AddExporter(CsvExporter.Default)
    .AddExporter(HtmlExporter.Default)
    .WithSummaryStyle(SummaryStyle.Default.WithMaxParameterColumnWidth(50));

BenchmarkDotNet.Reports.Summary summary = BenchmarkRunner.Run<StructAndClassBenchmark>();
