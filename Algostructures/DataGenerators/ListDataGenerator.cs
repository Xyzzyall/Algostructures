namespace Algostructures.DataGenerators;

public static class ListDataGenerator
{
    public static List<int> OrderedArray(int arraySize)
    {
        var res = new List<int>(arraySize);
        for (var i = 0; i < arraySize; i++)
        {
            res.Add(i);
        }

        return res;
    }

    public static List<int> ReverseOrderedArray(int arraySize)
    {
        var res = new List<int>(arraySize);
        for (var i = arraySize-1; i >= 0; i--)
        {
            res.Add(i);
        }

        return res;
    }

    private const int Seed = 228;
    public static List<int> RandomArray(int arraySize)
    {
        var g = new Random(Seed);
        var res = new List<int>(arraySize);
        for (var i = 0; i < arraySize; i++)
        {
            res.Add(g.Next());
        }

        return res;
    }

    public static List<int> CloneArray(this List<int> array)
    {
        var res = new List<int>(array.Count);
        for (var i = 0; i < array.Count; i++)
        {
            res.Add(array[i]);
        }
        return res;
    }
}