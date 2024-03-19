using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : Countable, UseAble
{
   public bool Use()
    {
        //포션의 개수가 충분할 경우 개수를 1개 감소합니다
        
        return true;
    }
}
