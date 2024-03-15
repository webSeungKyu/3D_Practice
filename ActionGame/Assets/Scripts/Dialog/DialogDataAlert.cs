﻿
using System;

public class DialogDataAlert : DialogData
{
    public string Title { get; private set; }
    public string Message { get; private set; }

    //유니티에서 사용할 수 있는 delegate Action
    //유저가 확인 버튼 눌렀을 때 호출되는 콜백 함수를 저장하겠습니다
    //콜백 함수는 
    public Action Callback { get; private set; }

    public DialogDataAlert(string title, string message, Action callback = null) : base(DialogType.Alert)
    {
        Title = title;
        Message = message;
        Callback = callback;
    }



}

