using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkLINQ
{
    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser]
    public class LinqImprovements
    {
        [Params(4, 1024)]
        public int Length { get; set; }

        private IEnumerable<int> _source = new int[1];

        [GlobalSetup]
        public void Setup() => _source = Enumerable.Range(1, Length).ToArray();

        [Benchmark]
        public int Min() => _source.Min();

        [Benchmark]
        public int Max() => _source.Max();
    }
}
