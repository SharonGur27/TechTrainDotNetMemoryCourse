```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.2894)
Intel Core i7-10850H CPU 2.70GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method            | Size    | Mean             | Error          | StdDev          | Median           | Allocated |
|------------------ |-------- |-----------------:|---------------:|----------------:|-----------------:|----------:|
| **StructArrayAccess** | **10**      |         **5.214 ns** |      **0.3334 ns** |       **0.9830 ns** |         **5.540 ns** |         **-** |
| ClassArrayAccess  | 10      |         6.162 ns |      0.1786 ns |       0.5266 ns |         6.267 ns |         - |
| **StructArrayAccess** | **100**     |        **41.577 ns** |      **0.8519 ns** |       **1.7969 ns** |        **41.103 ns** |         **-** |
| ClassArrayAccess  | 100     |        47.528 ns |      0.9740 ns |       2.4076 ns |        47.098 ns |         - |
| **StructArrayAccess** | **1000**    |       **356.056 ns** |      **7.0829 ns** |      **10.1581 ns** |       **353.338 ns** |         **-** |
| ClassArrayAccess  | 1000    |       523.770 ns |     27.8245 ns |      82.0411 ns |       525.947 ns |         - |
| **StructArrayAccess** | **10000**   |     **4,843.412 ns** |    **144.7285 ns** |     **419.8835 ns** |     **4,810.229 ns** |         **-** |
| ClassArrayAccess  | 10000   |     7,349.595 ns |    253.9056 ns |     748.6464 ns |     7,140.349 ns |         - |
| **StructArrayAccess** | **100000**  |    **47,711.148 ns** |  **2,303.5587 ns** |   **6,719.5892 ns** |    **46,459.543 ns** |         **-** |
| ClassArrayAccess  | 100000  |    83,613.128 ns |  2,985.7735 ns |   8,518.5804 ns |    81,862.708 ns |         - |
| **StructArrayAccess** | **1000000** |   **555,812.703 ns** | **29,398.8338 ns** |  **86,683.1310 ns** |   **521,311.328 ns** |         **-** |
| ClassArrayAccess  | 1000000 | 2,092,049.185 ns | 59,049.0979 ns | 173,180.7950 ns | 2,108,133.008 ns |         - |
