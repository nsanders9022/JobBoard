using System.Collections.Generic;
//a better name for the namespace would be something like JobBoard
namespace Jobs.Objects
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phone;
    // private static List<Contact> _contactList = new List<Contact>{};

    public Contact(string contactName, string contactEmail, string contactPhone)
    {
      _name = contactName;
      _email = contactEmail;
      _phone = contactPhone;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }

  }
}
