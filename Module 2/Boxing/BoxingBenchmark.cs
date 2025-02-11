using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    [MemoryDiagnoser]
    public class BoxingBenchmark
    {
        private int _valueType = 42;

        [Benchmark]
        public object BoxValueType() => _valueType;

        [Benchmark]
        public int UseGeneric() => GenericMethod(_valueType);

        private T GenericMethod<T>(T input) => input;
    }
}
