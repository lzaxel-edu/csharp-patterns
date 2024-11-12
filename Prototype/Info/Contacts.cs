namespace Prototype.Info;

public class Contacts
{
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }

    public Contacts() {}
    public Contacts(Contacts contacts)
        :this(contacts.PhoneNumber, contacts.Email)
    {}
    public Contacts(string phoneNumber, string email)
    {
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public void SetEmail(string email)
    {
        Email = email;   
    }

    public override string ToString()
    {
        return $"PhoneNumber: {PhoneNumber}, Email: {Email}";
    }
}
