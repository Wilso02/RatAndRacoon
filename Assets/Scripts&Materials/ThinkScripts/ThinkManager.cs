using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinkManager : MonoBehaviour
{

    public bool WinCondition = false;
    bool GameWon = false;
    bool TimerEnded = false;

    public int destroyIntrusive = 0;

    void OnEnable() //enable called event
    {
        Shared_EventManager.EndOfMicroGame += TimerLength; //from the "Shared_EventsManager"
    }
    void OnDisable() //disable called event
    {
        Shared_EventManager.EndOfMicroGame -= TimerLength; //from the "Shared_EventsManager"
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyIntrusive == 4)
        {
            WinCondition = true;
        }

        if (WinCondition == true)
        {

            GameWon = true;
            EndGame();

        }
    }

    void TimerLength()
    {

        TimerEnded = true;
        EndGame();

    }

    void EndGame()
    {
        if (GameWon == true)
        {
            print("Winner");
            //Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameWon();

        }
        else
        {
            print("Failure");
            //Cursor.lockState = CursorLockMode.Locked;
            Shared_EventManager.GameOver();

        }
    }
}
