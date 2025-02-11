using BenchmarkDotNet.Attributes;

namespace StructAndClassArray
{
    [MemoryDiagnoser]
    public class StructAndClassArrayBenchmark
    {
        public struct SmallStruct
        {
            public int Value1;
            public int Value2;
        }
        public class SmallClass
        {
            public int Value1;
            public int Value2;
        }

        [Params(10, 100, 1000, 10000, 100000, 1000000)] // Different sizes to test
        public int Size { get; set; }

        // both arrays are initialized with elements
        private SmallClass[]? _classes;
        private SmallStruct[]? _structs;

        [GlobalSetup]
        public void Setup()
        {
            _classes = new SmallClass[Size];
            _structs = new SmallStruct[Size];

            for (int i = 0; i < Size; i++)
            {
                _classes[i] = new SmallClass { Value1 = i };
                _structs[i] = new SmallStruct { Value1 = i };
            }
        }

        [Benchmark]
        public int StructArrayAccess()
        {
            int result = 0;
            for (int i = 0; i < Size; i++)
                result += Helper1(_structs!, i);
            return result;
        }

        [Benchmark]
        public int ClassArrayAccess()
        {
            int result = 0;
            for (int i = 0; i < Size; i++)
                result += Helper2(_classes!, i);
            return result;
        }

        public int Helper1(SmallStruct[] data, int index)
        {
            return data[index].Value1;
        }
        public int Helper2(SmallClass[] data, int index)
        {
            return data[index].Value1;
        }
    }
}
