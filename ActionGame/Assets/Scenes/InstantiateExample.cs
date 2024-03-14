using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour
{
    [Header("������ ������Ʈ")]
    public GameObject gameObjects;
    [Header("���� ��ġ")]
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
        //Instantiate(������Ʈ, ��ġ, ȸ����) Update�� �־����Ƿ� �����Ӹ��� �� ������
        temp++;
        respawn = gameObjects.transform.position + new Vector3(0, temp);
        Instantiate(gameObjects, respawn, gameObjects.transform.rotation);
        Debug.Log(temp);

    }
}
