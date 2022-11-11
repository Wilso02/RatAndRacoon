using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //the score for the micro game
    public int rubbishRemoved;

    //enable shared event
    void OnEnable()
    {
        EventManagerFind.rubbishDestroyed += AddScore;
        //from the Shared_EventManager script for the timer
        Shared_EventManager.EndOfMicroGame += TimerLength;
    }

    //disable shared event
    void OnDisable()
    {
        EventManagerFind.rubbishDestroyed -= AddScore;
        //from the Shared_EventManager script for the timer
        Shared_EventManager.EndOfMicroGame -= TimerLength;
    }

    //adding to the score when called 
    void AddScore()
    {
        rubbishRemoved++;
        //if 5 or more rubbish removed,
        if (rubbishRemoved >= 5)
        {
            //win condition met
            Debug.Log("Win");
            EndGame();
        }
    }
}
