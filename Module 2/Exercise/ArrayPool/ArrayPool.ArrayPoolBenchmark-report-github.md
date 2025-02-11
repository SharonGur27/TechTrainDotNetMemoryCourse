```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method              | Mean     | Error     | StdDev    | Median   | Gen0   | Allocated |
|-------------------- |---------:|----------:|----------:|---------:|-------:|----------:|
| ArrayAllocation     | 850.8 ns | 100.34 ns | 295.85 ns | 743.7 ns | 0.6409 |    4024 B |
| ArrayPoolAllocation | 347.8 ns |  20.06 ns |  59.14 ns | 329.2 ns |      - |         - |
