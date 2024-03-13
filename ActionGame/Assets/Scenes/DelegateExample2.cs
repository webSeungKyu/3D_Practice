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
        델리게이트 체인
        델리게이트에서 함수를 + 또는 -를 통해 추가, 제거할 수 있습니다
        추가할 경우 추가 순서대로 함수 호출 시 싱핼됩니다 ( 함수 동시 실행 )
         */
        PlusDelegate killUnit = PlusCoin;
        killUnit += PlusPoint;
        killUnit += PlusExp;

        killUnit(100, 50, 500);

    }
}
