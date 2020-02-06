using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.IO;

public class MenuController : MonoBehaviour
{
    public List<Canvas> listOfCanvas;
    private string file = "ContactsFile.txt";
    public ContactsList contactsList;
    public ContactsData contactsData;

    [SerializeField]
    private UIController uiController;

    public void Load()
    {
        contactsData = new ContactsData();
    }

    public void Save()
    {

        contactsList.ListOfContacts.Add(new ContactsData()
        {
            name = "name 1"
        });
        contactsList.ListOfContacts.Add(new ContactsData()
        {
            name = "name 2"
        });
        //contactsList.ListOfContacts.Add(new ContactsData()
        //{
        //    name = uiController.contactName.text
        //}); 


        string serializedContacts = JsonConvert.SerializeObject(contactsList);
        Debug.Log(serializedContacts);
        WriteToFile(file, serializedContacts);
    }

    public string ReadFromFile(string filename)
    {
        string path = GetFilePath(filename);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }

        else
            Debug.LogWarning("File Not Found");

        return "";
    }

    public void WriteToFile(string filename,string json)
    {
        string path = GetFilePath(filename);
        FileStream fileStream = new FileStream(path, FileMode.Append);
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.WriteLine(json);
            Debug.Log("File Created");
        }
    }

    public string GetFilePath(string filename)
    {
        return Application.persistentDataPath + "/" + filename;
    }

    public void OpenMenu(int i)
    {
        listOfCanvas[i].enabled = true;
        listOfCanvas[0].enabled = false;

    }
}
