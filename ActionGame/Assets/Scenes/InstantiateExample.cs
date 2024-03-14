using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour
{
    [Header("생성할 오브젝트")]
    public GameObject gameObjects;
    [Header("생성 위치")]
    public Vector3 respawn;
    private int temp;


    private void Awake()
    {
        respawn = gameObjects.transform.position + new Vector3(0, 10);
        Instantiate(gameObjects, respawn, gameObjects.transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        respawn = gameObjects.transform.position + new Vector3(0, 20);
        Instantiate(gameObjects, respawn, gameObjects.transform.rotation);
        Destroy(GameObject.FindGameObjectWithTag("Player"), 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(오브젝트, 위치, 회전값) Update에 넣었으므로 프레임마다 쫙 생성됨
        temp++;
        respawn = gameObjects.transform.position + new Vector3(0, temp);
        Instantiate(gameObjects, respawn, gameObjects.transform.rotation);
        Debug.Log(temp);

    }
}
