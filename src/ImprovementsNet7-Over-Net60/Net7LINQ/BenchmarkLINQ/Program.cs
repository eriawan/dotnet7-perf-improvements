using BenchmarkDotNet.Running;

namespace BenchmarkLINQ;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BenchmarkRunner.Run<LinqImprovements>();
    }
}
