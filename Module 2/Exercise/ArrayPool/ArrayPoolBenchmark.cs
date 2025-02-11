using BenchmarkDotNet.Attributes;
using System.Buffers;

namespace ArrayPool
{
    [MemoryDiagnoser]
    public class ArrayPoolBenchmark
    {
        private const int ArraySize = 1000;

        [Benchmark]
        public void ArrayAllocation()
        {
            int[] array = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                array[i] = i;
            }
        }

        [Benchmark]
        public void ArrayPoolAllocation()
        {
            int[] array = ArrayPool<int>.Shared.Rent(ArraySize);
            try
            {
                for (int i = 0; i < ArraySize; i++)
                {
                    array[i] = i;
                }
            }
            finally
            {
                ArrayPool<int>.Shared.Return(array);
            }
        }
    }
}
