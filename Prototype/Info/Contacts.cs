namespace Prototype.Info;

public class Contacts
{
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Contacts() {}
    public Contacts(Contacts contacts)
        :this(contacts.PhoneNumber, contacts.Email)
    {}
    public Contacts(string phoneNumber, string email)
    {
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public override string ToString()
    {
        return $"PhoneNumber: {PhoneNumber}, Email: {Email}";
    }
}
