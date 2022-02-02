using Algostructures.Algorithms;
using Algostructures.DataGenerators;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;

namespace Algostructures;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.Method)]
[RankColumn]
public class SortsBenchmark
{
    private const int TinySize = 15;
    private const int SmallSize = 50;
    private const int MediumSize = 200;
    private const int StandardSize = 1000;
    private const int BigSize = 5000;
    private const int VeryBigSize = 20000;
    private const int CrazySize = 100000;

    [Params(
        TinySize    
    )]
    public static int size = 0;
    
    private List<int> _ordered = new List<int>();
    private List<int> _reverseOrdered = new List<int>();
    private List<int> _random = new List<int>();

    [GlobalSetup]
    public void InitArrays()
    {
        _ordered = ListDataGenerator.OrderedArray(size);
        _reverseOrdered = ListDataGenerator.ReverseOrderedArray(size);
        _random = ListDataGenerator.RandomArray(size);
    }
    
    [Benchmark]
    public void InsertionSortOrdered()
    {
        
        _ordered.CloneArray().InsertionSort();
    }
    
    [Benchmark]
    public void InsertionSortReverseOrdered()
    {
        _reverseOrdered.CloneArray().InsertionSort();
    }
    
    [Benchmark]
    public void InsertionSortRandomOrdered()
    {
        _random.CloneArray().InsertionSort();
    }
}