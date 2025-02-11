```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method     | Mean     | Error    | StdDev   | Gen0    | Gen1   | Allocated |
|----------- |---------:|---------:|---------:|--------:|-------:|----------:|
| LinqMethod | 40.95 μs | 1.368 μs | 4.011 μs |  3.1128 | 0.1831 |  19.11 KB |
| LoopMethod | 50.25 μs | 1.004 μs | 2.095 μs | 10.4370 | 1.2817 |   64.3 KB |
