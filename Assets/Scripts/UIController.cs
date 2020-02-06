using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public InputField personName;
    public MenuController menuController;
    public Text contactName;


    void Start()
    {
        menuController.Load();
        personName.text = menuController.contactsData.name;
        contactName.text = menuController.contactsData.name.ToString();
    }

    public void ClickToSaveName()
    {
        contactName.text = menuController.contactsData.name.ToString();
        Debug.Log(contactName.text);
    }

    public void ChangeName(string text)
    {
        menuController.contactsData.name = text;
    }

    public void ClickToSave()
    {
        menuController.Save();
    }
}
