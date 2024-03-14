using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    Transform player;
    NavMeshAgent nav;
    // Start is called before the first frame update

    private void Awake()
    {
        //���忡�� Player �±׸� ���� ������Ʈ�� ������ �� ������Ʈ�� Ʈ������ ������ ����
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //�������� ������ �ִ� NavMeshAgent ���� ����
        nav = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nav.enabled)
        {
            nav.SetDestination(player.position);
        }
    }
}
