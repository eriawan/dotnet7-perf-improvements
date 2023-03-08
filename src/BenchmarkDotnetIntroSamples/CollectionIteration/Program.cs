using System;
using BenchmarkDotNet.Running;

namespace CollectionIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Benchmark!");
            BenchmarkRunner.Run<CollectionIterationBenchmark>();
        }
    }
}