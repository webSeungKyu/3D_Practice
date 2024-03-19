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
        Debug.Log("게임 시작 ...");

    }
    /// <summary>
    /// 1부터 9까지의 숫자 중 3개가 랜덤으로 선택됩니다 ( 중복 X )
    /// </summary>
    public void StartGame()
    {
        text.text = "게임 시작..";
        Debug.Log("게임 시작 버튼 클릭됨...");
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

        Debug.Log($"내가 입력한 숫자{oneMy},{twoMy},{threeMy}");

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

        Debug.Log($"스트라이크 : {strikes}, 볼 : {balls}, 아웃 : {outs}");

        text.text += $"내가 입력한 숫자 : {oneMy},{twoMy},{threeMy}\n";
        text.text += $"스트라이크 : {strikes}, 볼 : {balls}, 아웃 : {outs}\n";

        if(strikes == 3)
        {
            point += round * 100;
            text.text += $"3스트라이크! 이겼습니다.. {round * 100}점을 획득합니다\n당신이 가진 포인트는 {point}와 같습니다";

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
            text.text = "다시 시작 불가 ..포인트가 부족합니다..";
        }
        
    }
}
