using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIPractice : MonoBehaviour
{
    public Text nameText;
    public InputField nameInputField;
    public Button nameButton;
    public Dropdown nameDropdown;
    public Image nameImage;

    public void whatYourName()
    {
        string name = nameInputField.text;
        NameList nameList = new NameList();
        if (nameList.names.Contains(name))
        {
            nameText.text = $"이름 : {name} 있습니다!";
        }
        else
        {
            nameText.text = $"이름 : {name} 없습니다..";
        }
    }




    public void whatYourItem()
    {
        
    }

}
