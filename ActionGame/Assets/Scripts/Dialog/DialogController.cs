using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//일반 팝업 창과 확인 팝첩 창을 관리하는 DialogControllerAlert, DialogControllerConfrim
public class DialogController : MonoBehaviour
{
    //팝업창의 프랜스폼
    public Transform window;


    //팝업 창이 보이는지 조회하는 기능, 보이지 않게 설정하기 위한 속성
    public bool Visible
    {
        get
        {
            return window.gameObject.activeSelf;
            //해당 오브젝트가 활성화되어있는지 아닌지를 판단하는 읽기 전용
        }

        private set
        {
            window.gameObject.SetActive(value);
            //visible의 결과에 따라 활성화를 처리하는 코드
            //private이므로 외부에서 간섭할 수 없습니다
        }
    }

    //가상 함수 : 자식 쪽에서 오버라이딩 할 것이 예상될 경우에 작성되는 키워드
    public virtual void Awake() { }

    public virtual void Start() { }

    public virtual void Build(DialogData data) { }

    public void Show(Action callback) => StartCoroutine(OnEntert(callback));

    public void Close(Action callback) => StartCoroutine(OnExit(callback));

    //전달받은 기능을 실행하세요
    IEnumerator OnEntert(Action callback)
    {
        Visible = true;

        if(callback != null)
        {
            callback();
        }
        yield break; // 작업 종료 
    }

    IEnumerator OnExit(Action callback)
    {
        Visible = false;

        if (callback != null)
        {
            callback();
        }
        yield break; // 작업 종료 
    }







}
