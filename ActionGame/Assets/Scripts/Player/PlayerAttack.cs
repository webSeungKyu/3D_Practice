using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("�÷��̾� ������")]
    public int NomalDamage = 10;
    public int SkillDamage = 100;
    public int DashDamage = 30;

    [Header("���� ���")]
    public NomalTarget nomalTarget;
    public SkillTarget skillTarget;
    // Start is called before the first frame update
    
    /// <summary>
    /// �Ϲ� ���� �� ȣ��
    /// </summary>
    public void NomalAttack()
    {
        // ��� Ÿ�� ����Ʈ�� ��ȸ
        List<Collider> targetList = new List<Collider>(nomalTarget.targetList);

        //Ÿ�� ����Ʈ ���� ���͸� ��ü ��ȸ

        foreach(var one in targetList)
        {
            EnemyHealth enemy = one.GetComponent<EnemyHealth>();

            //���Ϳ��� �������� �ݴϴ�
            if(enemy != null)
            {
                //�������� �ְ� �󸶳� �ڷ� �з����� ó���մϴ�
                StartCoroutine(enemy.StartDamage(NomalDamage, transform.position, 0.5f, 0.5f));
            }
        }

    }

    /// <summary>
    /// ��ų ���� �� ȣ��
    /// </summary>
    public void SkillAttack()
    {
        //��ų Ÿ���� ����Ʈ ��ȸ
        List<Collider> targets = new List<Collider>(skillTarget.skillTargetList);
        // ����Ʈ ���� ���͸� ��ü ��ȸ
        foreach(var one in targets)
        {
            EnemyHealth enemy = one.GetComponent<EnemyHealth>();

            if(enemy != null)
            {
                // ��ų ��������ŭ �������� �ָ� 1�� ������ 2��ŭ pushback
                StartCoroutine(enemy.StartDamage(NomalDamage, transform.position, 1f, 2f));
            }
        }

        
    }

    /// <summary>
    /// �뽬 ��ų �� ȣ��
    /// </summary>
    public void DashAttack()
    {
        //�뽬 Ÿ���� ����Ʈ ��ȸ
        List<Collider> targets = new List<Collider>(skillTarget.skillTargetList);
        // ����Ʈ ���� ���͸� ��ü ��ȸ
        foreach (var one in targets)
        {
            EnemyHealth enemy = one.GetComponent<EnemyHealth>();

            if (enemy != null)
            {
                // �뽬 ��������ŭ �������� �ָ� 1�� ������ 2��ŭ pushback
                StartCoroutine(enemy.StartDamage(NomalDamage, transform.position, 1f, 2f));
            }
        }
    }
}
