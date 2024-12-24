namespace Strategy.Strategies;

public class BubbleSortStrategy: ISortStrategy
{
    public IEnumerable<T> Sort<T>(IEnumerable<T> collection) where T: IComparable
    {
        if (collection == null)
        {
            throw new ArgumentNullException(nameof(collection));
        }

        var list = collection.ToList();

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j].CompareTo(list[j + 1]) > 0)
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }

        return list;
    }
}