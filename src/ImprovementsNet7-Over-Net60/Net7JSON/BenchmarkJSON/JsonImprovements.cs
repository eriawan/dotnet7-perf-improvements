using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BenchmarkJSON
{

    [SimpleJob(RuntimeMoniker.Net60, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(true)]
    public class JsonImprovements
    {
        private JsonSerializerOptions _options = new JsonSerializerOptions();
        private MyAmazingClass _instance = new MyAmazingClass();

        [Benchmark(Baseline = true)]
        public string ImplicitOptions() => JsonSerializer.Serialize(_instance);

        [Benchmark]
        public string WithCached() => JsonSerializer.Serialize(_instance, _options);

        [Benchmark]
        public string WithoutCached() => JsonSerializer.Serialize(_instance, new JsonSerializerOptions());
    }
}
