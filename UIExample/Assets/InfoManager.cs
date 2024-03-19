using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO; // File, Directory 사용을 위한 using

public class InfoManager : MonoBehaviour
{
    [SerializeField]
    Info playerInfo;

    public Text id;
    public Text point;
    public Text gold;


    private void Awake()
    {
        var loadedJson = Resources.Load<TextAsset>("info");
        //리소스 폴더에 있는 Info(TextAsset) 로드 하겠습니다.
        //Text Asset은 텍스트 형태의 에셋을 의미합니다.
        Debug.Log(loadedJson.ToString());

        playerInfo = JsonUtility.FromJson<Info>(loadedJson.text);
        //JsonUtility.FromJson<T>(string json);
        //json 파일로부터 읽어온 파일을 기준으로 데이터를 적용하는 코드
        id.text = playerInfo.name.ToString();
        point.text = playerInfo.point.ToString();
        gold.text = playerInfo.gold.ToString();

    }

    /// <summary>
    /// 포인트를 사용해서 골드로 변경하는 코드 ( 100 포인트 > 10,000 골드 )
    /// </summary>
    public void GoldPlus()
    {
        if (playerInfo.point >= 100)
        {
            playerInfo.point -= 100;
            playerInfo.gold += 10000;
            SaveData(playerInfo);


            //var classToJson = JsonUtility.ToJson(playerInfo);
            point.text = playerInfo.point.ToString();
            gold.text = playerInfo.gold.ToString();
            //JsonUtility.ToJson(object obj);
            //객체의 정보를 json 파일로 보내는 기능
            //플레이어 정보를 json 파일에 전달

        }
        else
        {
            Debug.Log("교환할 포인트가 부족합니다");
        }
    }

    public void PointPlus()
    {
        playerInfo.point += 100;
        SaveData(playerInfo);
        point.text = playerInfo.point.ToString();
        gold.text = playerInfo.gold.ToString();

    }



    private string ResourcePath = Application.dataPath + "/Resources/";

    //[ 유니티 데이터 경로]
    private string SavePath => Application.persistentDataPath;
    //쓰기 가능한 폴더의 위치, 특정 운영체제에서 앱이 사용할 수 있도록 허용하는 경로
    //C:\Users\[user name]\AppData\LocalLow\[company name]\[product name]

    private string DataPath = Application.dataPath;
    //데이터의 저장 경로(읽기 전용)으로 프로젝트 폴더 내부(Asset)을 의미합니다

    private string StreamingPath = Application.streamingAssetsPath;
    //Application.dataPath + StreamingAssets = Application.treamingAssetsPath

    public void SaveData(Info info)
    {
        //폴더가 없을 경우에는 폴더를 생성합니다.
        if (!Directory.Exists(ResourcePath)) Directory.CreateDirectory(ResourcePath);

        var sJson = JsonUtility.ToJson(info);

        var FilePath = ResourcePath + "Info.json";

        File.WriteAllText(FilePath, sJson);
    }
}
