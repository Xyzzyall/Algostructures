using Algostructures.Algorithms;
using Algostructures.DataGenerators;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algostructures;

public static class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<SortsBenchmark>();
    }
}
