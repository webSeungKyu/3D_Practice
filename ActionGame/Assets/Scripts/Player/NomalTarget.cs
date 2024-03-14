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

    //Ʈ���� �浹 �� ����Ʈ ��ܿ� Ÿ���� ���
    private void OnTriggerEnter(Collider other)
    {
        targetList.Add(other);
    }
    //Ʈ���� �浹�� ������ ����Ʈ ��ܿ��� Ÿ���� ����   
    private void OnTriggerExit(Collider other)
    {
        targetList.Remove(other);
    }
}
