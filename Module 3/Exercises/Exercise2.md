### Exercise: Benchmarking Multiplication in Span<int> vs List<int> with BenchmarkDotNet

#### Objective:
Write a BenchmarkDotNet benchmark that uses `Params`, compares .NET 8 and .NET 9, and uses `GlobalSetup` to test the difference between multiplying each item in `Span<int>` and `List<int>`.

#### Steps:

1. **Create the Benchmarl Application**
   - It should contain Params
   - Comparison between .NET 8.0 & .NET 9.0
   - GlobalSetup

2. **Run the Benchmark**
   - Build and run the application. BenchmarkDotNet will execute the benchmarks and generate a detailed report comparing the performance of multiplying each item in `Span<int>` and `List<int>`.

3. **Analyze the Results**
   - Review the generated report to compare the performance differences between .NET 8 and .NET 9, and between `Span<int>` and `List<int>`.