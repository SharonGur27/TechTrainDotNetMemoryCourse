```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method       | Mean      | Error     | StdDev    | Median    | Gen0   | Allocated |
|------------- |----------:|----------:|----------:|----------:|-------:|----------:|
| BoxValueType | 5.0320 ns | 0.4198 ns | 1.1772 ns | 4.6090 ns | 0.0038 |      24 B |
| UseGeneric   | 0.0007 ns | 0.0027 ns | 0.0031 ns | 0.0000 ns |      - |         - |
