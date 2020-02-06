using System.Collections.Generic;

public class ContactsData
{

    public string name;
    //public ContactsData(string name)
    //{
    //    this.name = name;
    //}

}

[System.Serializable]
public class ContactsList
{
    public List<ContactsData> ListOfContacts = new List<ContactsData>();

}
