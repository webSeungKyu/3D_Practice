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
            nameText.text = $"�̸� : {name} �ֽ��ϴ�!";
        }
        else
        {
            nameText.text = $"�̸� : {name} �����ϴ�..";
        }
    }




    public void whatYourItem()
    {
        
    }

}
