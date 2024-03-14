using Palmmedia.ReportGenerator.Core.CodeAnalysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    #region 필드
    [Header("슬라임의 체력 정보")]
    public int startingHealth = 100;
    public int currentHealth;

    [Header("공격받을 시 색 변경")]
    public float flashSpeed;
    public Color flashColor = new Color(1, 0, 0, 0.1f);

    [Header("죽은 이후 처리")]
    public float sinkSpeed = 1.0f;

    AudioSource audioSource;
    //슬라임의 상태를 구분해 상황에 맞는 효과를 슬라임에게 전달하는 역할
    bool isDead;
    bool isSinking;
    bool damaged;
    #endregion
    // Use this for initialization
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        currentHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //데미지를 받았을 경우 색을 설정한 색으로 변경합니다
        if (damaged)
        {
            //Slime -> Model에 접근
            //transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_OutlineColor", flashColor);
            transform.GetComponentInChildren<Renderer>().material.SetColor("_OutlineColor", flashColor);
        }
        //아닐 경우는 다시 자연스럽게 색 복구 > Color.Lerp(a, b);는 a 컬러를 b 컬러로 천천히 바꾸는 코드
        else
        {
            transform.GetChild(0).GetComponent<Renderer>().material.SetColor("_OutlineColor", Color.Lerp(transform.GetChild(0).
                GetComponent<Renderer>().material.GetColor("_OutlineColor"), Color.black, flashSpeed * Time.deltaTime));
        }

        damaged = false;

        //싱크 처리(사후 처리) 시 슬라임을 아래로 서서히 내려가게 연출합니다
       if(isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }
    }


    /// <summary>
    /// 슬라임이 플레이어로부터 공격을 받았을 때 상황을 처리하는 함수
    /// </summary>
    /// <param name="damage">데미지 수치</param>
    public void TakeDamage(int damageSize)
    {
        damaged = true;
        currentHealth -= damageSize;

        if(!isDead && currentHealth <= 0)
        {
            Death();
        }
    }
    /// <summary>
    /// 슬라임이 플레이어로부터 공격을 받았을 때 넉백 효과 연출
    /// </summary>
    /// <param name="damage">데미지</param>
    /// <param name="playerPosition">플레이어 위치</param>
    /// <param name="delay">딜레이 수치</param>
    /// <param name="pushback">푸시백</param>
    /// <returns></returns>
    public IEnumerator StartDamage(int damage, Vector3 playerPosition, float delay, float pushback)
    {
        yield return new WaitForSeconds(delay);

        try
        {
            TakeDamage(damage);
            Vector3 diff = playerPosition - transform.position;
            diff /= diff.sqrMagnitude;
            GetComponent<Rigidbody>().AddForce((transform.position - new Vector3(diff.x, diff.y, 0.0f)) * 50 * pushback);
        }
        catch(MissingReferenceException e)
        {
            Debug.LogError(e.ToString());
        }
    }

    /// <summary>
    /// 슬라임 죽음 시 호출할 함수
    /// </summary>
    void Death()
    {
        isDead = true;

        transform.GetChild(0).GetComponent<BoxCollider>().isTrigger = true;

        //애니메이션 트리거 작동
        // < 넣을 예정 >
        //죽을 때 사용할 클립으로 변경 후 오디오 실행

        StartSinking();
    }

    /// <summary>
    ///    사후 처리
    /// </summary>
    public void StartSinking()
    {
        //NavMeshAgent 비활성화
        GetComponent<NavMeshAgent>().enabled = false;

        //외부에서 가해지는 물리적인 힘에 반응하지 않겠습니다
        GetComponent<Rigidbody>().isKinematic = true;

        isSinking = true;

        Destroy(gameObject, 2.0f);

    }
}
