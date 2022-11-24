public class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> inputStream = new List<int>() { 3, 2, 0, 4, 5, 9, 8, 5, 5 };
        int sortFactor = 4;
        int maxValue = 9;
        var newArr = Sort(inputStream, sortFactor, maxValue);

        foreach (var item in newArr)
        {
            Console.Write($"{item} ");
        }
    }

    static IEnumerable<int> Sort(IEnumerable<int> inputStream, int sortFactor, int maxValue)
    {
        var values = new int[maxValue + 1];

        foreach (int x in inputStream)
        {
            ++values[x];

            if (x == sortFactor)
            {
                for (int i = 0; i < x; i++)
                {
                    while (values[i]-- > 0)
                        yield return i;
                }
            }
        }

        for (int i = sortFactor; i < values.Length; i++)
        {
            while (values[i]-- > 0)
                yield return i;
        }
    }
}