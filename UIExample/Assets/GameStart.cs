using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameStart : MonoBehaviour
{
    int one;
    int two;
    int three;

    int balls;
    int strikes;
    int outs;

    int round;
    int point;

    public Text text;

    public InputField oneInputField;
    public InputField twoInputField;
    public InputField threeInputField;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("���� ���� ...");

    }
    /// <summary>
    /// 1���� 9������ ���� �� 3���� �������� ���õ˴ϴ� ( �ߺ� X )
    /// </summary>
    public void StartGame()
    {
        text.text = "���� ����..";
        Debug.Log("���� ���� ��ư Ŭ����...");
        one = Random.Range(1, 10);
        two = Random.Range(1, 10);
        three = Random.Range(1, 10);
        if (one != two)
        {
            three = Random.Range(1, 10);
        }
        else
        {
            while (one == two)
            {
                two = Random.Range(1, 10);
            }
        }
        while (one != two && one == three || two == three)
        {
            three = Random.Range(1, 10);
        }

        Debug.Log($"one : {one}, two : {two}, three : {three}");



    }

    public void WhatYourNum()
    {
        int oneMy = Convert.ToInt32(oneInputField.text);
        int twoMy = Convert.ToInt32(twoInputField.text);
        int threeMy = Convert.ToInt32(threeInputField.text);

        Debug.Log($"���� �Է��� ����{oneMy},{twoMy},{threeMy}");

        if(oneMy == one)
        {
            strikes++;
        }
        if (twoMy == two)
        {
            strikes++;
        }
        if (threeMy == three)
        {
            strikes++;
        }

        if(oneMy == two || oneMy == three)
        {
            balls++;
        }
        if (twoMy == one || twoMy == three)
        {
            balls++;
        }
        if (threeMy == two || threeMy == one)
        {
            balls++;
        }

        if(oneMy != one && oneMy != two && oneMy != three)
        {
            outs++;
        }
        if (twoMy != one && twoMy != two && twoMy != three)
        {
            outs++;
        }
        if (threeMy != one && threeMy != two && threeMy != three)
        {
            outs++;
        }

        Debug.Log($"��Ʈ����ũ : {strikes}, �� : {balls}, �ƿ� : {outs}");

        text.text += $"���� �Է��� ���� : {oneMy},{twoMy},{threeMy}\n";
        text.text += $"��Ʈ����ũ : {strikes}, �� : {balls}, �ƿ� : {outs}\n";

        if(strikes == 3)
        {
            point += round * 100;
            text.text += $"3��Ʈ����ũ! �̰���ϴ�.. {round * 100}���� ȹ���մϴ�\n����� ���� ����Ʈ�� {point}�� �����ϴ�";

        }

        strikes = 0;
        balls = 0;
        outs = 0;
        round++;

        
    }

    public void ReStartGame()
    {
        if(point > 50)
        {
            StartGame();
        }
        else
        {
            text.text = "�ٽ� ���� �Ұ� ..����Ʈ�� �����մϴ�..";
        }
        
    }
}
