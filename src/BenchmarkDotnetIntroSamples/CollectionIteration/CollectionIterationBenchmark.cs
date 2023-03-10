using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionIteration
{

    [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(true)]
    public class CollectionIterationBenchmark
    {
        [Params(100, 1000)]
        public int Size { get; set; }

        private List<int> DataItems = new List<int>();

        [GlobalSetup]
        public void SetupBenchmark()
        {
            DataItems = Enumerable.Range(0, Size).ToList();
        }

        [Benchmark]
        public void ForEach()
        {
            foreach (var item in DataItems)
            {

            }
        }

        [Benchmark]
        public void For()
        {
            for (int i = 0; i < DataItems.Count; i++)
            {

            }
        }

        [Benchmark]
        public void ListForEach()
        {
            DataItems.ForEach(item => { });
        }

        [Benchmark]
        public void ForEachParallel()
        {
            Parallel.ForEach(DataItems, item => { });
        }

        [Benchmark]
        public void ForParallel()
        {
            Parallel.For(0, DataItems.Count - 1, item => { });
        }
    }
}
