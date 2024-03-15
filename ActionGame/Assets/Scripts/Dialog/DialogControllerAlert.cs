//알림창
using UnityEngine;
using UnityEngine.UI;

public class DialogControllerAlert : DialogController
{
    public Text title;
    public Text message;

    //클래스에서 전달할 알림창의 데이터 객체 선언
    DialogDataAlert Data{get;set;}

    public void OnClickOK()
    {
        if (Data != null && Data.Callback != null)
        {
            Data.Callback();
        }

        //작업 끝난 후 현재의 팝업 창을 관리자에서 제거합니다
        DialogManager.Instance.Pop();
    }

    public override void Awake()
    {
        base.Awake();
    }

    public override void Build(DialogData data)
    {
        base.Build(data);

        if(!(data is DialogDataAlert))
        {
            //에러 메세지 출력
            Debug.LogError("Invaild dialog data!");
            return; //작업 종료
        }

        Data = data as DialogDataAlert;
        title.text = Data.Title;
        message.text = Data.Message;
    }

    public override void Start()
    {
        base.Start();
        DialogManager.Instance.Regist(DialogType.Alert, this);
    }
}

