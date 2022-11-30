using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public static float WinCount;

    public static void WinCheck()
    {
        if(WinCount == 6)
        {
            print("you win!");
            FindObjectOfType<BurgerGameManager>().WinGame();
        }
        else
        {
            print("win count is now " + WinCondition.WinCount);
        }
    }
}
