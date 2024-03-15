using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//스테이지를 관리하는 컨트롤러
//스테이지 시작과 종료 시점에 스테이지의 시작과 마감을 처리하는 기능
//스테이지 내에서 획득하는 포인트를 관리하는 시스템
public class StageController : MonoBehaviour
{
    //스테이지에서 쌓은 포인트를 저장할 변수
    public int stagePoint = 0;

    //포인트 표시용 텍스트
    public Text pointText;

    //스테이지 컨트롤러의 인스턴스를 저장하는 static 변수
    public static StageController instance;

    //다른 코드 내에서 StageContoller.instance.AddPoint(10)과 같은 형태로 사용할 수 있게 됩니다.
    // 따로 연결해서 쓸 필요가 없어 편리합니다

    private void Start()
    {
        instance = this;
        var alert = new DialogDataAlert("아래를 참고하세요", "점수 2000점을 향해..", delegate () { Debug.Log("OK를 눌렀습니다.."); });

        DialogManager.Instance.Push(alert);
    }

    public void AddPoint(int point)
    {
        stagePoint += point;
        pointText.text = stagePoint.ToString();
        if(stagePoint > 2000 )
        {
            FinishGame();
        }
    }

    public void FinishGame()
    {
        //Application.LoadLevel(Application.loadedLevel); 구 버전 코드( 현재는 쓰지 않음 )
        SceneManager.LoadScene("Game");
    }

}
