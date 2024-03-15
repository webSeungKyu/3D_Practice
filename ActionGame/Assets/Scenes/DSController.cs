using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//이벤트 트리거를 통해 전달
public class DSController : MonoBehaviour
{
    private int temp = 1;
    //사용할 결과를 출력할 텍스트
    //TMP 사용할 경우에는 TMP의 형태로 작업합니다
    public Text resultText;

    public void DSArray()
    {
        //자료형[] 배열명 = new 자료형[배열의 길이];
        int[] exp = new int[10];
        for (int i = 0; i < exp.Length; i++)
        {
            exp[i] = i * 100 + (i * 50);
            resultText.text += $"[DSArray] 다음 레벨 {temp + 1}까지 요구 경험치 = {exp[i]} 입니다.\n";
            temp += 1;
        }

    }

    public void DSList()
    {
        //리스트<T> 리스트명 = new List<T>
        List<int> exp = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            exp.Add(i * 100 + (i * 50));
            /*resultText.text += $"[DSList] 다음 레벨 {temp + 1}까지 요구 경험치 = {exp[i]} 입니다.\n";*/
            temp += 1;
        }

        //exp.RemoveAll(x => (x % 4) == 0); 
        exp.Sort( (a,b) => b.CompareTo(a)  );

        for (int i = 0; i < exp.Count; i++)
        {
            resultText.text += $"[DSList] 다음 레벨 {i}까지 요구 경험치 = {exp[i]} 입니다.\n";
        }


        /*
         C#에서 사용되는 리스트 문법
        1. Add(값) : 해당 값을 리스트에 추가합니다
        2. Remove(값) : 해당 값을 리스트에서 제거합니다
        3. Insert(위치, 값) : 리스트에 해당 위치에 값을 추가합니다
        4. Contains(값) : 리스트가 해당 값을 가지고 있는지를 판단합니다 (bool)
        5. Clear() : 리스트의 모든 요소를 제거합니다
        6. Reverse() : 요소를 역순으로 정렬합니다
        7. RemoveAll(조건식) : 해당 조건을 만족하는 모든 요소를 삭제합니다
        8. Sort() : 오름차순으로 정렬합니다
        9. Sort((a,b) => a.CompareTo(b)); 내림차순
         */


    }

    //해당 함수 호출 시 화면에 나와있는 텍스트를 비우는 기능
    public void DSResultReset()
    {
        resultText.text = "";
    }
}
