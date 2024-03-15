using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//���������� �����ϴ� ��Ʈ�ѷ�
//�������� ���۰� ���� ������ ���������� ���۰� ������ ó���ϴ� ���
//�������� ������ ȹ���ϴ� ����Ʈ�� �����ϴ� �ý���
public class StageController : MonoBehaviour
{
    //������������ ���� ����Ʈ�� ������ ����
    public int stagePoint = 0;

    //����Ʈ ǥ�ÿ� �ؽ�Ʈ
    public Text pointText;

    //�������� ��Ʈ�ѷ��� �ν��Ͻ��� �����ϴ� static ����
    public static StageController instance;

    //�ٸ� �ڵ� ������ StageContoller.instance.AddPoint(10)�� ���� ���·� ����� �� �ְ� �˴ϴ�.
    // ���� �����ؼ� �� �ʿ䰡 ���� ���մϴ�

    private void Start()
    {
        instance = this;
        var alert = new DialogDataAlert("�Ʒ��� �����ϼ���", "���� 2000���� ����..", delegate () { Debug.Log("OK�� �������ϴ�.."); });

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
        //Application.LoadLevel(Application.loadedLevel); �� ���� �ڵ�( ����� ���� ���� )
        SceneManager.LoadScene("Game");
    }

}
