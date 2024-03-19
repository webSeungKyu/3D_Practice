using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(fileName = "itemList", menuName = "SO/ItemList")]
public class ItemList : ScriptableObject
{
    public List<Item> iList;


    /// <summary>
    /// 아이템 생성 함수
    /// </summary>
    /// <returns></returns>
    public static ItemList Create()
    {
        ItemList asset = CreateInstance<ItemList>();
        //CreateInstance는 ScriptableObject에서 인스턴스를 생성하는 기능
        AssetDatabase.CreateAsset(asset, "Assets/Resources/Item/itemExample01.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    public static ItemList Load()
    {
        ItemList itemList = AssetDatabase.LoadAssetAtPath("Assets/Resources/Item/itemExample01", typeof(ItemList)) as ItemList;
        return itemList;
    }
}

