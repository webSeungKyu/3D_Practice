using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Animator에 대한 요구(반드시 필요하다)
//없을 경우 자동으로 1회 추가된다
//Animator를 에디터에서 컴포넌트 제거할 수 없다.
//만약 Animator 컴포넌트가 없다면 게임 실행조차 되지 않는다.
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    //게임 오브젝트 내에 연결되어있는 Animator 컴포넌트를 가져와서 사용합니다.
    protected Animator avatar;

    float h;
    float v;

    float lastAttackTime;
    float lastSkillTime;
    float lastDashTime;

    [Header("Animation Condition")]
    public bool attacking = false;
    public bool dashing = false;
    // Start is called before the first frame update
    void Start()
    {
        avatar = GetComponent<Animator>();
    }

    /// <summary>
    /// 방향 컨트롤러에서 컨트롤러의 변경이 일어날 경우 호출할 함수
    /// </summary>
    /// <param name="stickPos">스틱의 좌표</param>
    public void OnStickChanged(Vector2 stickPos)
    {
        h = stickPos.x;
        v = stickPos.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (avatar)
        {
            avatar.SetFloat("Speed", (h * h) + (v * v));
            Rigidbody rigidbody = GetComponent<Rigidbody>();

            if (rigidbody)
            {
                if(h != 0.0f &&  v != 0.0f)
                {
                    transform.rotation = Quaternion.LookRotation(new Vector3(h, 0.0f, v));
                    //해당 백터 방향을 바라보는 회전 상태를 반환하는 코드
                }
            }
        }
    }
}
