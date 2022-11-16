using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //the score for the micro game
    public int rubbishRemoved;
    //public int addScore;
    bool TimerEnded = false;

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
            Endgame();
        }
    }

        void TimerLength()
        {
            TimerEnded = true;
            Endgame();


        }

        void Endgame()
        {
            if (rubbishRemoved >= 5)
            {
                Shared_EventManager.GameWon();
            }
          else if(TimerEnded == true)
            {
           Shared_EventManager.GameOver();
            }
    

        }
}
