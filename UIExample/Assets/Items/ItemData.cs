using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemData : ScriptableObject
{
    [SerializeField] private int _id; //������ �ĺ� ��ȣ
    [SerializeField] private string _name; //������ �̸�
    [SerializeField] private string _description; // ������ ����
    [SerializeField] private Sprite _icon; // ������ �̹���(������)
    [SerializeField] private GameObject _prefab; //������ ��� �� ǥ���� ���� ������Ʈ


    public abstract Items Create();

}
