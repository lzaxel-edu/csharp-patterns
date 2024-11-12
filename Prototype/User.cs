using Prototype.Info;

namespace Prototype;

public class User
{
    public int ID { get; private set; }
    public string Username { get; private set;}
    public Contacts Contacts { get; private set;}
    public Favorites Favorites { get; private set;}

    public User(int id, string username)
    {
        ID = id;
        Username = username;
        Contacts = new Contacts();
        Favorites = new Favorites();
    }
    public User(int id, string username, Contacts contacts, Favorites favorites)
    {
        ID = id;
        Username = username;
        Contacts = contacts;
        Favorites = favorites;
    }

    public User Clone()   
    {
        User clone = (User)MemberwiseClone();
        clone.Contacts = new Contacts(this.Contacts);
        clone.Favorites = new Favorites(this.Favorites);

        return clone;
    }

    public void SetUsername(string username)
    {
        this.Username = username;
    }

    public override string ToString()
    {
        return $"ID: {ID} Username:{Username} Favorites: \"{Favorites}\" Contacts: \"{Contacts}\"";
    }
}