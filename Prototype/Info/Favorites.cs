namespace Prototype.Info;

public class Favorites
{
    public string[] Food { get; set; }
    public int[] PrimeNumbers { get; set; }
    
    public Favorites() {}
    public Favorites(Favorites favorites)
        :this(favorites.Food, favorites.PrimeNumbers)
    {}
    public Favorites(string[] food, int[] primeNumbers)
    {
        Food = food;
        PrimeNumbers = primeNumbers;
    }

    
    public override string ToString()
    {
        return $"Food: {string.Join(",", Food)}, PrimeNumbers: {string.Join(",", PrimeNumbers)}";
    }
}