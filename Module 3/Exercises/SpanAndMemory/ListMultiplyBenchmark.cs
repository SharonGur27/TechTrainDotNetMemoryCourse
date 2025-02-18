using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Runtime.InteropServices;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
public class ListMultiplyBenchmark
{
    [Params(100, 1000, 10000)]
    public int _arraySize;

    private int _value = 42;

    private List<int> _list;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _list = Enumerable.Range(0, _arraySize).ToList();
    }

    [Benchmark(Baseline = true)]
    public int TraditionalListMultiply()
    {
        int sum = 0;

        for (int i = 0; i < _list.Count; i++)
        {
            _list[i] *= _value;
        }
        return _list[0]; // Return value to prevent optimization
    }

    [Benchmark]
    public int SpanListMultiply()
    {
        Span<int> span = CollectionsMarshal.AsSpan(_list);
        int sum = 0;

        for (int i = 0; i < _list.Count; i++)
        {
            span[i] *= _value;
        }
        return span[0]; // Return value to prevent optimization
    }
}