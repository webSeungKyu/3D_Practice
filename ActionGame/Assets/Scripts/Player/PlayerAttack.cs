using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("플레이어 데미지")]
    public int NomalDamage = 10;
    public int SkillDamage = 100;
    public int DashDamage = 30;

    [Header("공격 대상")]
    public NomalTarget nomalTarget;
    public SkillTarget skillTarget;
    // Start is called before the first frame update
    
    /// <summary>
    /// 일반 공격 시 호출
    /// </summary>
    public void NomalAttack()
    {
        // 노멀 타겟 리스트를 조회
        List<Collider> targetList = new List<Collider>(nomalTarget.targetList);

        //타겟 리스트 안의 몬스터를 전체 조회

        foreach(var one in targetList)
        {
            EnemyHealth enemy = one.GetComponent<EnemyHealth>();

            //몬스터에게 데미지를 줍니다
            if(enemy != null)
            {
                //데미지를 주고 얼마나 뒤로 밀려날지 처리합니다
                StartCoroutine(enemy.StartDamage(NomalDamage, transform.position, 0.5f, 0.5f));
            }
        }

    }

    /// <summary>
    /// 스킬 공격 시 호출
    /// </summary>
    public void SkillAttack()
    {
        //스킬 타겟의 리스트 조회
        List<Collider> targets = new List<Collider>(skillTarget.skillTargetList);
        // 리스트 안의 몬스터를 전체 조회
        foreach(var one in targets)
        {
            EnemyHealth enemy = one.GetComponent<EnemyHealth>();

            if(enemy != null)
            {
                // 스킬 데미지만큼 데미지를 주며 1초 딜레이 2만큼 pushback
                StartCoroutine(enemy.StartDamage(NomalDamage, transform.position, 1f, 2f));
            }
        }

        
    }

    /// <summary>
    /// 대쉬 스킬 시 호출
    /// </summary>
    public void DashAttack()
    {
        //대쉬 타겟의 리스트 조회
        List<Collider> targets = new List<Collider>(skillTarget.skillTargetList);
        // 리스트 안의 몬스터를 전체 조회
        foreach (var one in targets)
        {
            EnemyHealth enemy = one.GetComponent<EnemyHealth>();

            if (enemy != null)
            {
                // 대쉬 데미지만큼 데미지를 주며 1초 딜레이 2만큼 pushback
                StartCoroutine(enemy.StartDamage(NomalDamage, transform.position, 1f, 2f));
            }
        }
    }
}
