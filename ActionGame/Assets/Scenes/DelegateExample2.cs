using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateExample2 : MonoBehaviour
{
    static int coins = 0;
    static int points = 0;
    static int exps = 0;

    public delegate void PlusDelegate(int coin, int point, int exp);
    static void PlusCoin(int coin, int point, int exp)
    {
        coins += coin;
        Debug.Log(coins);
    }

    static void PlusPoint(int coin, int point, int exp)
    {
        points += point;
        Debug.Log(points);
    }

    static void PlusExp(int coin, int point, int exp)
    {
        exps += exp;
        Debug.Log(exps);
    }

    private void Start()
    {
        /*
        ��������Ʈ ü��
        ��������Ʈ���� �Լ��� + �Ǵ� -�� ���� �߰�, ������ �� �ֽ��ϴ�
        �߰��� ��� �߰� ������� �Լ� ȣ�� �� ���۵˴ϴ� ( �Լ� ���� ���� )
         */
        PlusDelegate killUnit = PlusCoin;
        killUnit += PlusPoint;
        killUnit += PlusExp;

        killUnit(100, 50, 500);

    }
}
