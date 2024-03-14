using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalTarget : MonoBehaviour
{
    public List<Collider> targetList;
    // Start is called before the first frame update
    void Start()
    {
        targetList = new List<Collider>();
    }

    //트리거 충돌 시 리스트 명단에 타겟을 등록
    private void OnTriggerEnter(Collider other)
    {
        targetList.Add(other);
    }
    //트리거 충돌이 끝나면 리스트 명단에서 타겟을 제거   
    private void OnTriggerExit(Collider other)
    {
        targetList.Remove(other);
    }
}
