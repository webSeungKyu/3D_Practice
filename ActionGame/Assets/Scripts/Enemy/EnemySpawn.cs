using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3.0f;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Spawn", spawnTime, spawnTime);
        //InvokeRepeating("함수", "딜레이시간, 반복시간);
        //해당 함수를 딜레이 시간 이후 호출 , 반복 시간을 주기로 해당 함수를 반복 호출
    }

    void Spawn()
    {
        if(playerHealth.currentHealth <= 0.0f)
        {
            return; // 플레이어 체력이 0이라면...
        }
        int spawnPoolIndex = Random.Range(0, spawnPoints.Length);
        //생성 지역의 개수만큼 랜덤한 수치의 값을 인덱스로 가지겠습니다

        Instantiate(enemy, spawnPoints[spawnPoolIndex].position, spawnPoints[spawnPoolIndex].rotation);
    }

}
