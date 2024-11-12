using Prototype;
using Prototype.Info;

namespace ProducersTests;

public class PrototypeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DeepCloningTest()
    {
        User initialUser = new User(1, "User1", 
            new Contacts("+111 1111 1111", "user1@mail.com"), 
            new Favorites(new List<string>(){"Pasta", "Doner"}, new List<int>(){1,2}));

        User testUser = initialUser.Clone();
        testUser.SetUsername("UserNew");
        testUser.Contacts.SetEmail("user2@mail.com");
        testUser.Favorites.Food.Add("Kebab");
        testUser.Favorites.PrimeNumbers.Add(5);

        
        Assert.AreNotSame(initialUser, testUser);
        Assert.AreNotSame(initialUser.Contacts.Email, testUser.Contacts.Email);
        Assert.AreNotSame(initialUser.Favorites.PrimeNumbers, testUser.Favorites.PrimeNumbers);
        Assert.AreNotSame(initialUser.Favorites.Food, testUser.Favorites.Food);
        
        Assert.Pass();
    }
}