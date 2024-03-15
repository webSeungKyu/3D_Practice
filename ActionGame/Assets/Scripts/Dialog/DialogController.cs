using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�Ϲ� �˾� â�� Ȯ�� ��ø â�� �����ϴ� DialogControllerAlert, DialogControllerConfrim
public class DialogController : MonoBehaviour
{
    //�˾�â�� ��������
    public Transform window;


    //�˾� â�� ���̴��� ��ȸ�ϴ� ���, ������ �ʰ� �����ϱ� ���� �Ӽ�
    public bool Visible
    {
        get
        {
            return window.gameObject.activeSelf;
            //�ش� ������Ʈ�� Ȱ��ȭ�Ǿ��ִ��� �ƴ����� �Ǵ��ϴ� �б� ����
        }

        private set
        {
            window.gameObject.SetActive(value);
            //visible�� ����� ���� Ȱ��ȭ�� ó���ϴ� �ڵ�
            //private�̹Ƿ� �ܺο��� ������ �� �����ϴ�
        }
    }

    //���� �Լ� : �ڽ� �ʿ��� �������̵� �� ���� ����� ��쿡 �ۼ��Ǵ� Ű����
    public virtual void Awake() { }

    public virtual void Start() { }

    public virtual void Build(DialogData data) { }

    public void Show(Action callback) => StartCoroutine(OnEntert(callback));

    public void Close(Action callback) => StartCoroutine(OnExit(callback));

    //���޹��� ����� �����ϼ���
    IEnumerator OnEntert(Action callback)
    {
        Visible = true;

        if(callback != null)
        {
            callback();
        }
        yield break; // �۾� ���� 
    }

    IEnumerator OnExit(Action callback)
    {
        Visible = false;

        if (callback != null)
        {
            callback();
        }
        yield break; // �۾� ���� 
    }







}
