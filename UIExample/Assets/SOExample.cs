using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SOExample : MonoBehaviour
{
    public Item itemObject;
    public ItemList itemList;


    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log($"{itemObject.Type}");
        Debug.Log($"{itemObject.Description}");*/

        itemList = ItemList.Create();
        Item itemObj = Item.Create();
        itemList.iList.Add( itemObj );



        for ( int i = 0; i < itemList.iList.Count; i++)
        {
            Debug.Log(itemList.iList[i].name);
        }

        ItemList itemList2 = ItemList.Load();
        Debug.Log(AssetDatabase.GetAssetPath(itemList2));
        /*
        AssetDatabase�� ���ο� ������ ������ ��ο� ������ �� ����մϴ�
        ��ο��� Ȯ���ڸ� �������� �մϴ�
        ������ �̹� path ��ο� �����ϴ� ��� ��������ϴ�
        ��� ��δ� ������Ʈ�� ������ �������� �����մϴ� 

        ��� ���� : ������ �ҽ� ���Ͽ��� ���� �Ǵ� �ǽð� �ۿ��� ����� �� �ִ� ���·� �����͸� ��ȯ�ؾ� �ϴµ�
        ����Ƽ�� ��ȯ�� ����, ��ȯ�� ���ϰ� ����� �����͸� ���� �����ͺ��̽��� �����մϴ�
         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
