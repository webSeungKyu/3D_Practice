using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

//�̺�Ʈ Ʈ���Ÿ� ���� ����
public class DSController : MonoBehaviour
{
    private int temp = 1;
    //����� ����� ����� �ؽ�Ʈ
    //TMP ����� ��쿡�� TMP�� ���·� �۾��մϴ�
    public Text resultText;

    public void DSArray()
    {
        //�ڷ���[] �迭�� = new �ڷ���[�迭�� ����];
        int[] exp = new int[10];
        for (int i = 0; i < exp.Length; i++)
        {
            exp[i] = i * 100 + (i * 50);
            resultText.text += $"[DSArray] ���� ���� {temp + 1}���� �䱸 ����ġ = {exp[i]} �Դϴ�.\n";
            temp += 1;
        }

    }

    public void DSList()
    {
        //����Ʈ<T> ����Ʈ�� = new List<T>
        List<int> exp = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            exp.Add(i * 100 + (i * 50));
            /*resultText.text += $"[DSList] ���� ���� {temp + 1}���� �䱸 ����ġ = {exp[i]} �Դϴ�.\n";*/
            temp += 1;
        }

        //exp.RemoveAll(x => (x % 4) == 0); 
        exp.Sort((a, b) => b.CompareTo(a));

        for (int i = 0; i < exp.Count; i++)
        {
            resultText.text += $"[DSList] ���� ���� {i}���� �䱸 ����ġ = {exp[i]} �Դϴ�.\n";
        }


        /*
         C#���� ���Ǵ� ����Ʈ ����
        1. Add(��) : �ش� ���� ����Ʈ�� �߰��մϴ�
        2. Remove(��) : �ش� ���� ����Ʈ���� �����մϴ�
        3. Insert(��ġ, ��) : ����Ʈ�� �ش� ��ġ�� ���� �߰��մϴ�
        4. Contains(��) : ����Ʈ�� �ش� ���� ������ �ִ����� �Ǵ��մϴ� (bool)
        5. Clear() : ����Ʈ�� ��� ��Ҹ� �����մϴ�
        6. Reverse() : ��Ҹ� �������� �����մϴ�
        7. RemoveAll(���ǽ�) : �ش� ������ �����ϴ� ��� ��Ҹ� �����մϴ�
        8. Sort() : ������������ �����մϴ�
        9. Sort((a,b) => a.CompareTo(b)); ��������
         */


    }

    public void DSDictionary()
    {
        //���� Dictionary<K, V> ��ųʸ��� = Dictionary<K, V>();

        //���� �� �ʱ�ȭ
        Dictionary<string, int> items = new Dictionary<string, int>
        {
            
            {"red apple", 10 },
            {"meat", 100 }

        };

        
        //��� �߰�
        items.Add("cake", 50);

        if (items.ContainsKey("cake"))
        {
            items.Remove("cake");
        }

        if (items.ContainsValue(100))
        {
            Debug.Log("�ش� ���� �����մϴ�.");
        }
        /*
         ��ųʸ��� �ٽ�
        1. Ű�� �̿��� ���� ���� ����
        2. �ش� Ű�� �����ϴ°��� ���� ����
        3. Ű, ���� ���� ������ ������ �� �ִ°�?(����Ʈ ��ȯ)
        4. ��ųʸ��� Ű�� ��쿡�� �ߺ��� ������� �ʰ�, ���� �ߺ��� ����մϴ�
        > ���� Add ������ ��, ������ �ִ� Ű�� �ٽ� Add�ϴ� ��� �� Ű�� ���� ���� ����
         */


        //��ųʸ��� Ű -> ����Ʈ�� �ٲٴ� ���
        var KList = new List<string>(items.Keys);

        //��ųʸ��� �� -> ����Ʈ�� �ٲٴ� ���
        var KList2 = new List<int>(items.Values);

        //����Ʈ - > ��ųʸ��� �ٲٴ¹�
        List<int> kToD = new List<int>() { 1, 2, 3, };
        List<string> vTod = new List<string>() { "a", "b" }; 

        //��ųʸ��� �����ϰ� Zip �Լ��� ���� �۾��� �����մϴ�
        //Ű.Zip(��, (k,v) => new {k, v}) Ű�� �� �ϳ��ϳ��� {Ű, ��}�� ���·� ���̰� �˴ϴ�.
        //ToDictionary�� ���� Ű�� ���� �����մϴ�. �׸��� ��ųʸ��� ���·� ��ȯ�մϴ�
        Dictionary<int, string> newD = kToD.Zip(vTod, (k,v) => new {k, v}).ToDictionary(a => a.k, a=> a.v);
    }

    //�ش� �Լ� ȣ�� �� ȭ�鿡 �����ִ� �ؽ�Ʈ�� ���� ���
    public void DSResultReset()
    {
        resultText.text = "";
    }
}
