using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifyManager : MonoBehaviour
{
    

    public bool WinCondition = false;
    bool GameWon = false;
    bool TimerEnded = false;

    private void OnEnable()
    {

        Shared_EventManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"

    }

    private void OnDisable()
    {

        Shared_EventManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"

    }


    // Update is called once per frame
    void Update()
    {
        
        if(WinCondition == true)
        {

            GameWon = true;

        }



    }


    void TimerLength()
    {

        TimerEnded = true;
        EndGame();

    }

    void EndGame()
    {
        if (GameWon == true && TimerEnded == true)
        {
            print("Winner");
            Shared_EventManager.GameWon();

        }
        else
        {
            print("Failure");
            Shared_EventManager.GameOver();

        }



    }
}
