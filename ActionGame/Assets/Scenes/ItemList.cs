using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    
    public List<string> items = new List<string>{};
    
    public int str;
    public int con;
    public int itemLV;
    public string ability;
    public string introduce;


    public ItemList(int str, int con, int itemLV, string ability, string introduce)
    {
        this.str = str;
        this.con = con;
        this.itemLV = itemLV;
        this.ability = ability;
        this.introduce = introduce;
    }

    public Dictionary<string, ItemList> itemList = new Dictionary<string, ItemList>();

    

    


    

}
