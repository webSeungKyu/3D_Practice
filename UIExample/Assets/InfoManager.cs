using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO; // File, Directory ����� ���� using

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
        //���ҽ� ������ �ִ� Info(TextAsset) �ε� �ϰڽ��ϴ�.
        //Text Asset�� �ؽ�Ʈ ������ ������ �ǹ��մϴ�.
        Debug.Log(loadedJson.ToString());

        playerInfo = JsonUtility.FromJson<Info>(loadedJson.text);
        //JsonUtility.FromJson<T>(string json);
        //json ���Ϸκ��� �о�� ������ �������� �����͸� �����ϴ� �ڵ�
        id.text = playerInfo.name.ToString();
        point.text = playerInfo.point.ToString();
        gold.text = playerInfo.gold.ToString();

    }

    /// <summary>
    /// ����Ʈ�� ����ؼ� ���� �����ϴ� �ڵ� ( 100 ����Ʈ > 10,000 ��� )
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
            //��ü�� ������ json ���Ϸ� ������ ���
            //�÷��̾� ������ json ���Ͽ� ����

        }
        else
        {
            Debug.Log("��ȯ�� ����Ʈ�� �����մϴ�");
        }
    }

    private string ResourcePath = Application.dataPath + "/Resources/";

    //[ ����Ƽ ������ ���]
    private string SavePath => Application.persistentDataPath;
    //���� ������ ������ ��ġ, Ư�� �ü������ ���� ����� �� �ֵ��� ����ϴ� ���
    //C:\Users\[user name]\AppData\LocalLow\[company name]\[product name]

    private string DataPath = Application.dataPath;
    //�������� ���� ���(�б� ����)���� ������Ʈ ���� ����(Asset)�� �ǹ��մϴ�

    private string StreamingPath = Application.streamingAssetsPath;
    //Application.dataPath + StreamingAssets = Application.treamingAssetsPath

    public void SaveData(Info info)
    {
        //������ ���� ��쿡�� ������ �����մϴ�.
        if (!Directory.Exists(ResourcePath)) Directory.CreateDirectory(ResourcePath);

        var sJson = JsonUtility.ToJson(info);

        var FilePath = ResourcePath + "Info.json";

        File.WriteAllText(FilePath, sJson);
    }
}