using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionExample : MonoBehaviour
{

    public bool isUse;
    public float cooltime = 10.0f;
    public float cooltimeMax = 10.0f;

    public void OnPotionDown()
    {
        if (!isUse)
        {
            Debug.Log("포션을 사용했습니다!");
            StartCoroutine("CooltimeCheck");
            //GetComponent<Image>().color = Color.black;
            //isUse = true;
            
        }
        
    }

    IEnumerator CooltimeCheck()
    {
        while (cooltime > 0.0f)
        {
            GetComponent<Image>().color = Color.black;
            isUse = true;
            
            cooltime -= Time.deltaTime;
            GetComponent<Image>().fillAmount = cooltime / cooltimeMax;

            yield return null;
        }
        GetComponent<Image>().color = Color.white; 
        GetComponent<Image>().fillAmount= 1f;
        cooltime = cooltimeMax;
        isUse = false;
    }



}
