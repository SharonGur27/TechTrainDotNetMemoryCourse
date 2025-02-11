```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2605)
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2


```
| Method          | Mean      | Error    | StdDev   | Gen0     | Gen1     | Gen2     | Allocated |
|---------------- |----------:|---------:|---------:|---------:|---------:|---------:|----------:|
| PopulateRows    |  20.81 ms | 0.306 ms | 0.239 ms | 968.7500 | 968.7500 | 968.7500 |  95.37 MB |
| PopulateColumns | 157.88 ms | 2.731 ms | 2.421 ms | 750.0000 | 750.0000 | 750.0000 |  95.37 MB |
