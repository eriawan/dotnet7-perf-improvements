using BenchmarkDotNet.Running;

namespace BenchmarkJSON;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Benchmark JSON!");
        BenchmarkRunner.Run<JsonImprovements>();
    }
}
