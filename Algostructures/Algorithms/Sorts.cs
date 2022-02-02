namespace Algostructures.Algorithms;

public static class Sorts
{
    public static void InsertionSort(this List<int> list)
    {
        for (var i = 1; i < list.Count; i++)
        {
            var key = list[i];
            var j = i - 1;
            while (j >= 0 && list[j].CompareTo(key) > 0)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = key;
        }
    }
}