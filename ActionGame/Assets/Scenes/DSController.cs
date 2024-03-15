using System.Collections;
using System.Collections.Generic;
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
        exp.Sort( (a,b) => b.CompareTo(a)  );

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

    //�ش� �Լ� ȣ�� �� ȭ�鿡 �����ִ� �ؽ�Ʈ�� ���� ���
    public void DSResultReset()
    {
        resultText.text = "";
    }
}
