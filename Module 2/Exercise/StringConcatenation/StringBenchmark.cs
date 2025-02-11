using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        [Benchmark]
        public string StringConcatenation()
        {
            string result = string.Empty;
            foreach (var num in Enumerable.Range(0, 64))
                result += string.Format("{0:D4}", num);
            return result;
        }

        [Benchmark]
        public string StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var num in Enumerable.Range(0, 64))
                sb.AppendFormat("{0:D4}", num);
            return sb.ToString();
        }
    }
}
