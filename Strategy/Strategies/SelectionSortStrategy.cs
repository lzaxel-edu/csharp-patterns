namespace Strategy.Strategies;

public class SelectionSortStrategy: ISortStrategy
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
            int minIndex = i;
            
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j].CompareTo(list[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                (list[i], list[minIndex]) = (list[minIndex], list[i]);
            }
        }

        return list;
    }
}