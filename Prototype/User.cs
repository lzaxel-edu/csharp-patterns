using Prototype.Info;

namespace Prototype;

public class User: ICloneable
{
    public int ID { get; set; }
    public string Username { get; set; }
    public Contacts Contacts { get; set; }
    public Favorites Favorites { get; set; }

    public User(int id, string username)
    {
        ID = id;
        Username = username;
        Contacts = new Contacts();
        Favorites = new Favorites();
    }

    public object Clone()   
    {
        User clone = (User)MemberwiseClone();
        clone.Contacts = new Contacts(this.Contacts);
        clone.Favorites = new Favorites(this.Favorites);

        return clone;
    }

    public override string ToString()
    {
        return $"ID: {ID} Username:{Username} Favorites: '{Favorites}' Contacts: '{Contacts}'";
    }
}