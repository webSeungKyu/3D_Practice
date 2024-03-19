using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����ʹ� abstract�� �����ϵ�, ������� �Ϲ� Ŭ����
/// </summary>
/// 
[CreateAssetMenu(fileName = "Potion", menuName ="Item/Item Data/Potion")]
public class PotionData : CountableData
{
    [SerializeField] private float _value; // �������� ȸ���� ��ġ

    public override Items Create()
    {
        return new Potion(this);
    }
}
