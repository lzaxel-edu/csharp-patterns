namespace Builder;

public class Burger
{
    public Burger(List<string> ingredients)
    {
        Ingredients = ingredients;
    }

    public List<string> Ingredients { get; set; }
}