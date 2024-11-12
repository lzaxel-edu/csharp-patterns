using Prototype.Info;

namespace Prototype;

public class PrototypeExample
{
    public void Run()
    {
        User user = new User(1, "aboba", new Contacts("+323 23232 323", "aboba@lol.com"), new Favorites());
        user.Favorites.AddFood("Food1");
        user.Favorites.AddFood("Food2");
        user.Favorites.AddNumber(3);
        user.Favorites.AddNumber(7);
        
        
        var cloneUser = (User)user.Clone();

        cloneUser.Favorites.AddFood("NewFood3");
        cloneUser.Favorites.AddFood("NewFood4");
        cloneUser.Favorites.AddNumber(11);
        cloneUser.SetUsername("Grishka O.");
        cloneUser.Contacts.SetEmail("newemail@aboba.com");
        
        Console.WriteLine(user);
        Console.WriteLine(cloneUser);
    }
}

