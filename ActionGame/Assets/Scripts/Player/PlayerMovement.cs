using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Animator�� ���� �䱸(�ݵ�� �ʿ��ϴ�)
//���� ��� �ڵ����� 1ȸ �߰��ȴ�
//Animator�� �����Ϳ��� ������Ʈ ������ �� ����.
//���� Animator ������Ʈ�� ���ٸ� ���� �������� ���� �ʴ´�.
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    //���� ������Ʈ ���� ����Ǿ��ִ� Animator ������Ʈ�� �����ͼ� ����մϴ�.
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
    /// ���� ��Ʈ�ѷ����� ��Ʈ�ѷ��� ������ �Ͼ ��� ȣ���� �Լ�
    /// </summary>
    /// <param name="stickPos">��ƽ�� ��ǥ</param>
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
                    //�ش� ���� ������ �ٶ󺸴� ȸ�� ���¸� ��ȯ�ϴ� �ڵ�
                }
            }
        }
    }
}
