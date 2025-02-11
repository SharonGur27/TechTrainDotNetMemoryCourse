using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClassBenchmark
{
    public class StructAndClassBenchmark
    {
        [Benchmark]
        public int TestStruct()
        {
            MyStructInt myStruct = new MyStructInt { Value = 1 };
            return myStruct.Value;
        }

        [Benchmark]
        public int TestClass()
        {
            MyClassInt myStruct = new MyClassInt { Value = 1 };
            return myStruct.Value;
        }
    }
}
