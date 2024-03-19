using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum ItemType
{
    WEAPON, ARMOR, POTION
}

[CreateAssetMenu(fileName = "item", menuName ="SO/Item")]
/*
��ũ���ͺ� ������Ʈ(Scriptable Object)
����Ƽ���� �����ϴ� �뷮�� �����͸� ������ �� �ִ� ������ �����̳��Դϴ�.
���� �纻�� �����Ǵ� ���� ������ �� �ֽ��ϴ�.

���� ������Ʈ�� ������Ʈ�� ������ �Ұ����ϸ�, ������Ʈ���� �������� ����˴ϴ�.
*/
public class Item : ScriptableObject
{
    [SerializeField] ItemType type;
    [SerializeField] string description; // ����

    public ItemType Type { get => type; set => type = value; }
    public string Description { get => description; set => description = value; }

    public static Item Create()
    {
        Item asset = CreateInstance<Item>();
        //CreateInstance�� ScriptableObject���� �ν��Ͻ��� �����ϴ� ���
        AssetDatabase.CreateAsset(asset, "Assets/Resources/Item/item1.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    public static Item Load()
    {
        Item item = AssetDatabase.LoadAssetAtPath("Assets/Resources/Item/item1.asset", typeof(Item)) as Item;
        return item;
    }

}
