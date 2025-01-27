namespace TemplateMethod;

public class Coffee : Buffet
{
    protected override void Ingredient()
    {
        Console.WriteLine("Coffee");
    }

    protected override void Adds()
    {
        Console.WriteLine("Syrup");
    }
}