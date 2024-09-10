namespace Builder;

public class Burger
{
    public List<string> Ingredients { get; set; }

    public Burger(List<string> ingredients)
    {
        Ingredients = ingredients;
    }
}