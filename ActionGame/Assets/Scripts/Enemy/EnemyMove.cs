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
        //월드에서 Player 태그를 가진 오브젝트를 조사해 그 오브젝트의 트랜스폼 값으로 설정
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //슬라임이 가지고 있는 NavMeshAgent 값에 접근
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
