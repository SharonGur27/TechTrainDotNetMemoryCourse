using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Finalization
{
    [MemoryDiagnoser]
    public class FinalizationBenchmark
    {
        [Params(10, 100, 1000, 10000, 100000, 1000000)] // Different sizes to test
        public int Size;

        public int Data = 100;

        [Benchmark]
        public void ConsumeNonFinalizableClass()
        {
            for (int i = 0; i < Size; ++i)
            {
                var obj = new NonFinalizableClass();
                obj.Value1 = Data;
            }
        }
        [Benchmark]
        public void ConsumeFinalizableClass()
        {
            for (int i = 0; i < Size; ++i)
            {
                var obj = new FinalizableClass();
                obj.Value1 = Data;
            }
        }
    }
}
