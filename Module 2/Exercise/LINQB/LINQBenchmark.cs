using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    [MemoryDiagnoser]
    public class LINQBenchmark
    {
        private List<int> _data;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random();
            _data = Enumerable.Range(1, 10000).Select(_ => random.Next(1, 100)).ToList();
        }

        [Benchmark]
        public List<int> LinqMethod()
        {
            return _data.Where(x => x % 2 == 0).ToList();
        }

        [Benchmark]
        public List<int> LoopMethod()
        {
            var result = new List<int>();
            foreach (var x in _data)
            {
                if (x % 2 == 0)
                {
                    result.Add(x);
                }
            }
            return result;
        }
    }
}
