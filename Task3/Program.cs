
public class Program
{
    static void Main(string[] args)
    {
        IEnumerable<int> lst = new List<int>() { 1, 2, 3, 4 };
        var newlst = lst.EnumerateFromTail(2);

        foreach (var item in newlst)
        {
            Console.Write($"{item}, ");
        }
    }
}

public static class ExtensionMethods
{
    public static IEnumerable<(T item, int? tail)> EnumerateFromTail<T>(this IEnumerable<T> enumerable, int? tailLength)
    {
        if (tailLength > enumerable.Count())
            throw new ArgumentException("tailLenght must be less or equal than size of collection");
        int iterator = enumerable.Count();
        foreach (T item in enumerable)
        {
            int? tail;
            if (iterator > tailLength)
                tail = null;
            else
                tail = iterator;
            iterator--;

            yield return (item, --tail);
        }
    }
}