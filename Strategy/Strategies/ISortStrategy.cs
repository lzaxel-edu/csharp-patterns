namespace Strategy.Strategies;

public interface ISortStrategy
{
    public IEnumerable<T> Sort<T>(IEnumerable<T> list) where T: IComparable;
}