using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static float WinCount;

    void Update()
    {
        if(WinCount == 5)
        {
            print("you win!");
        }
    }
}
