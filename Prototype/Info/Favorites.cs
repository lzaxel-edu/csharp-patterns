namespace Prototype.Info;

public class Favorites
{
    public List<string> Food { get; private set; }
    public List<int> PrimeNumbers { get; private set; }

    public Favorites()
    {
        Food = new List<string>{};
        PrimeNumbers = new List<int>{};
    }
    public Favorites(Favorites favorites)
        :this(favorites.Food, favorites.PrimeNumbers)
    {}
    public Favorites(List<string> food, List<int> primeNumbers)
    {
        Food = food.ToList();
        PrimeNumbers = primeNumbers.ToList();
    }

    public void AddFood(string item)
    {
        Food.Add(item);
    }
    public void AddNumber(int number)
    {
        PrimeNumbers.Add(number);
    }
    
    public override string ToString()
    {
        return $"Food: {string.Join(",", Food)}, PrimeNumbers: {string.Join(",", PrimeNumbers)}";
    }
}