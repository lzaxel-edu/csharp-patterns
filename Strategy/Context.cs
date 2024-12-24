using Strategy.Strategies;

namespace Strategy;

public class Context
{
    private ISortStrategy _sortStrategy;

    public Context(ISortStrategy sortStrategy)
    {
        if (sortStrategy == null)
        {
            throw new ArgumentNullException(nameof(sortStrategy));
        }
        _sortStrategy = sortStrategy;
    }

    public IEnumerable<double> SoSmartOperation(IEnumerable<double> list)
    {
        return _sortStrategy.Sort(list);
    }
}