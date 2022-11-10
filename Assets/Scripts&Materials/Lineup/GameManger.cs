using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    bool GameWon = false;
    bool TimerEnded = false;

    // Start is called before the first frame update
    void OnEnable()
    {
        Shared_EventManager.EndOfMicroGame += TimerLength;
    }

    void OnDisable()
    {
        Shared_EventManager.EndOfMicroGame -= TimerLength;
    }


    public void GameOver()
    {
        Endgame();

    }
    public void WinGame()
    {
        GameWon = true;
    }
    void TimerLength()
    {
        TimerEnded = true;
        Endgame();
    }

    void Endgame()
    {
        if (GameWon == true && TimerEnded == true)
        {
            Shared_EventManager.GameWon();
        }
        else
        {
            Shared_EventManager.GameOver();
        }


    }

}


