namespace Prototype;

public class PrototypeExample
{
    public void Run()
    {
        User user = new User(1, "aboba");
        user.Contacts.Email = "testEmail@gmail.com";
        user.Contacts.PhoneNumber = "+373778228";

        user.Favorites.Food = new[] { "Burger", "Doner Kebab", "Pizza" };
        user.Favorites.PrimeNumbers = new[] { 3, 5 };
        
        var cloneUser = (User)user.Clone();

        cloneUser.ID = 228;
        cloneUser.Favorites.Food = new[] { "Doshik", "Pasta" };
        cloneUser.Contacts.PhoneNumber = "+8 800 555 3535";
        cloneUser.Username = "Grishka O.";
        
        Console.WriteLine(user);
        Console.WriteLine(cloneUser);
    }
}

