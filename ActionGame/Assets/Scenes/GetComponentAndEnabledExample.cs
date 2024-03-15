using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentAndEnabledExample : MonoBehaviour
{
    /*private Rigidbody rbody;*/
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
/*        rbody = GetComponent<Rigidbody>();
        rbody.useGravity = true;*/
        light = GetComponent<Light>();
        light.color = Color.red;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("���콺 ���� Ŭ��");
            light.enabled = false;
            
            
        }
        else if (Input.GetKey(KeyCode.Mouse1))
        {
            Debug.Log("���콺 ������ Ŭ��");
            light.enabled = true;
        }
    }
}
