using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameManager : MonoBehaviour
{
    //the score for the micro game
    public int rubbishRemoved;
    bool GameWon = false;
    bool TimerEnded = false;

    //allow the event manager and this script to interact when asked
    void OnEnable()
    {
        EventManagerFind.rubbishDestroyed += AddScore;
        Shared_EventManager.EndOfMicroGame += TimerLength;
    }

    //otherwise don't interact
    void OnDisable()
    {
        EventManagerFind.rubbishDestroyed -= AddScore;
        Shared_EventManager.EndOfMicroGame -= TimerLength;
    }

    //adding to the score when called 
    void AddScore()
    {
        rubbishRemoved++;
        //if 6 or more rubbish removed,
        if (rubbishRemoved >= 6)
        {
            GameWon = true;
            Endgame();
            //win condition met
            Debug.Log("Win");
        }
    }

    void TimerLength()
    {
        TimerEnded = true;
        Endgame();
    }

    void Endgame()
    {
        if(GameWon == true)
        {
            Shared_EventManager.GameWon();
        }
        else
        {
            Shared_EventManager.GameOver();
        }

    }

}
